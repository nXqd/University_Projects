/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

import java.sql.Connection;
import org.junit.After;
import org.junit.AfterClass;
import org.junit.Before;
import org.junit.BeforeClass;
import org.junit.Test;
import static org.junit.Assert.*;
import static org.hamcrest.CoreMatchers.*;

/**
 *
 * @author Administrator
 */
public class DataProviderTest {
	
	public DataProviderTest() {
	}

	@BeforeClass
	public static void setUpClass() throws Exception {
	}

	@AfterClass
	public static void tearDownClass() throws Exception {
	}
	
	@Before
	public void setUp() {
	}
	
	@After
	public void tearDown() {
	}

	/**
	 * Test of getConnection method, of class DataProvider.
	 */
	@Test
	public void testGetConnection() throws Exception {
		System.out.println("getConnection");
		DataProvider instance = new DataProvider();
		Connection expResult = null;
		Connection result = instance.getConnection();
		assertThat(result, not(expResult));
	}

	/**
	 * Test of closeConnection method, of class DataProvider.
	 */
	@Test
	public void testCloseConnection() throws Exception {
		System.out.println("closeConnection");
		DataProvider instance = new DataProvider();
		instance.closeConnection();
	}
}
