#include <stdio.h>
#include <LPC23xx.H>                    /* LPC23xx definitions                */
#include "LCD.h"
#include "sound.h"

#define true 1
#define false 0 
#define freq_mult 42950                       /* Graphic LCD function prototypes    */

/* Global variables */
int i = 1;
int n = 1;
int dur = 0;
int index = 0;
int freq = 0;
int accum = 0;
int flag = 0;
unsigned char sample = '0';
int iNumber,iTimeReset,h,m,s;
char c,cTime[6];


/* Function that initializes LEDs                                             */
void LED_Init(void) {
	PINSEL10 = 0;                         /* Disable ETM interface, enable LEDs */
	FIO2DIR  = 0x000000FF;                /* P2.0..7 defined as Outputs         */
	FIO2MASK = 0x00000000;
}

/* Function that turns on requested LED                                       */
void LED_On (unsigned int num) {
	FIO2SET = (1 << num);
}

/* Function that turns off requested LED                                      */
void LED_Off (unsigned int num) {
	FIO2CLR = (1 << num);
}

/* Function that outputs value to LEDs                                        */
void LED_Out(unsigned int value) {
	FIO2CLR = 0xFF;                       /* Turn off all LEDs                  */
	FIO2SET = (value & 0xFF);             /* Turn on requested LEDs             */
}


/* Function for displaying bargraph on the LCD display                        */
void Disp_Bargraph(int pos_x, int pos_y, int value) {
	int i;

	set_cursor (pos_x, pos_y);
	for (i = 0; i < 16; i++)  {
		if (value > 5)  {
			lcd_putchar (0x05);
			value -= 5;
		}  else  {
			lcd_putchar (value);
			value = 0;
		}
	}
}

/* Import external IRQ handlers from IRQ.c file                               */
extern __irq void T0_IRQHandler  (void);
extern __irq void ADC_IRQHandler (void);

/* Import external functions from Serial.c file                               */
extern       void init_serial    (void);

/* Import external variables from IRQ.c file                                  */
extern short AD_last;
extern unsigned char clock_1s;
void delay()
{
	for(i = 0;i<100000000;i++)
	{}
}

__irq void T0_Handler()
{
	n++;
	while(n==100000)
	{
		n = 1;
		FIO2SET0 = 1<<i;
		if(i!=0)
			FIO2CLR = 1<<i-1;
		else
			FIO2CLR = 1<<7;
		i++;
		if(i==8)
			i = 0;
	}
	EXTINT=0x01;
	VICVectAddr = 0;
}	

// Compare strings
int isEqualString(char* ch1, char* ch2) {
	int diff;
	// find the different character by character
	do {
		diff = *ch1 - *ch2;
		if (diff) {
			return 0;
		} 
		// compare next character
		ch1++;
		ch2++;
	} while (*ch1 != 0 && *ch2 != 0);

	// after checking if ch1 or ch2 still has chars left while the oter doesn't have return false
	if (*ch1 != 0 || *ch2 != 0) {
		return 0;
	}
	return 1;
}

// send string to serial port
void sendString(char* str) {
	while (*str != 0) {
		sendchar(*str);
		str++;
	}
}

__irq void WDTHandler()
{	
	VICIntEnClr=(1<<0);// xoa bit 1 ve 0
	VICVectAddr = 0;
}


void WDTInit( int time ) // time in seconds
{
	VICVectAddr0 = (unsigned long)WDTHandler;	/*Set Interrupt Vector*/
	VICVectCntl0 = 0; 							/*use it for Timer0 Interrupt*/
	VICIntEnable = (1 << 0); 					/*Enable Timer0 Interrupt*/
	
	WDTC 	= time * 1000000;	  //Micro seconds
	WDMOD 	= 0x03;
				/* 0x01= Interrupt */
				/* 0x03= reset */
	WDFEED = 0xAA;
	WDFEED = 0x55;
	
}

__irq void playSong()
{		
	dur++;
	if(dur == 20000)
	{
		freq = Keys[arrFreq[index++]];
		dur = 0;
		if(index==32)		// tat play song
		{
			index=0;
			//dur=0;
			freq=0;
			accum=0;
			T0TCR = 0; 
		}
		 	
	}
		
	accum += freq_mult * freq;
	sample = sine_table256[accum>>24];
	DACR = ((sample) << 6) & 0xFFC0;
	
	T0IR        = 1;    
	VICVectAddr = 0;
}
void InitplaySong(void)
{
	PINSEL1 &= ~(0x03<<20);
	PINSEL1 |= (0x02<<20);

	T0MR0         = 120;                         /* 1msec = 12000-1 at 12.0 MHz */
	T0MCR         = 3;                           /* Interrupt and Reset on MR0  */
	T0TCR         = 1;                           /* Timer0 Enable               */
	VICVectAddr4  = (unsigned long)playSong;		/* Set Interrupt Vector        */
	VICVectCntl4  = 15;                          /* use it for Timer0 Interrupt */
	VICIntEnable  = (1  << 4);                   /* Enable Timer0 Interrupt     */
}

void printTime()
{	
		lcd_clear();
	
		c = RTC_HOUR/10 + '0';
		lcd_print(&c);	  
		c = RTC_HOUR%10 + '0';
		lcd_print(&c);
		lcd_print(":");
	
		c = RTC_MIN/10 + '0';
		lcd_print(&c);	  
		c = RTC_MIN%10 + '0';
		lcd_print(&c);
		lcd_print(":");
	
		c = RTC_SEC/10 + '0';
		lcd_print(&c);	  
		c = RTC_SEC%10 + '0';
		lcd_print(&c);
}

void RTCInit()
{
	RTC_CCR = 0;
	RTC_PREINT = 0x1C8;
	RTC_PREFRAC = 0x61C0;
	RTC_CCR = 1;	
}

// time : hhmmss
void UpdateTimer(int h, int m, int s)
{	
		// set time
		RTC_HOUR = h;  
		RTC_MIN  = m;
		RTC_SEC = s;

 		printTime();
}
			
int main(void) {
	// variables
	char cmd[10];
	int count = 0;
	
	// Initial
	LED_Init();
	lcd_init();	
	lcd_clear();
	init_serial();
	while(1)
	{
		//reset values
		iTimeReset = -1;
		h = 0;
		m = 0;
		s = 0;
		for(i = 0;i<10;i++)
			cmd[i] = NULL;

		iNumber = getkey() - 48; // get number of characters
		lcd_clear();
		// get command name to cmd
		while(1) {

			i = getkey();
			c = i;
			cmd[count] = c;
			count++;

			if (count == 6 && isEqualString(cmd,"reset ")) {
				i = getkey();

				// get time for reset
				iTimeReset = i - 48;

				c = i;
				cmd[count] = c;
				count++;
			}

			if (count == 7 && isEqualString(cmd,"gettime")) {
					// hour
					i = getkey() - 48;
					h += i*10;
					i = getkey() - 48;
					h += i;
					// minute
					i = getkey() - 48;
					m += i*10;
					i = getkey() - 48;
					m += i;
					// second
					i = getkey() - 48;
					s += i*10;
					i = getkey() - 48;
					s += i;
			}

			if (count == iNumber)
			{
				lcd_print(&cmd[0]);
				count = 0;
				break;
				
			}
		}

		if(iTimeReset != -1)
		{
			sendString("\r\nReseting...");
			WDTInit(iTimeReset);
		} else if(isEqualString(cmd,"gettime"))
		{	
			RTCInit();
			UpdateTimer(h,m,s);
		} else if(isEqualString(cmd,"song"))
		{
			InitplaySong();
		} else if(isEqualString(cmd,"0812090"))
		{
			sendString("\r\nChao ban Quang Dung");
		} else if(isEqualString(cmd,"0812076"))
		{
			sendString("\r\nChao ban Ngoc Duy");
		}
	}
	return 0;
}
