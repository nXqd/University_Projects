/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

import model.UserDTO;
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
public class UserDAOTest {
	
	public UserDAOTest() {
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
	 * Test of insert method, of class UserDAO.
	 */
	@Test
	public void testInsert() throws Exception {
		System.out.println("insert");
		UserDTO user = new UserDTO();
		user.setId(1);
		UserDAO instance = new UserDAO();
		UserDTO expResult = null;
		UserDTO result = instance.insert(user);
		assertEquals(expResult, result);
	}

	/**
	 * Test of delete method, of class UserDAO.
	 */
	@Test
	public void testDelete() throws Exception {
		System.out.println("delete");
		UserDTO user = null;
		UserDAO instance = new UserDAO();
		instance.delete(user);
	}

	/**
	 * Test of login method, of class UserDAO.
	 */
	@Test
	public void testLogin() throws Exception {
		System.out.println("login");
		UserDTO user = new UserDTO();
		user.setUsername("asdf");
		user.setPassword("asdf");
		UserDAO instance = new UserDAO();
		UserDTO expResult = null;
		UserDTO result = instance.login(user);
		assertThat(result, not(expResult));
	}
}
