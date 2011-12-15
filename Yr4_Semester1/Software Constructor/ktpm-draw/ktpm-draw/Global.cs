using System.ComponentModel;
using System.Drawing;

namespace ktpm_draw
{
    public static class Global {
        public static Graphics graphic;
        public static Pen pen;
        public static TypeConverter converter;

        static Global() {
            pen = new Pen(Color.Black, 5);
            converter = TypeDescriptor.GetConverter(typeof(Point));
        }
    }
}
