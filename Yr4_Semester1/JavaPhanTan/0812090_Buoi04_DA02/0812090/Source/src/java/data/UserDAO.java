/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

/**
 *
 * @author nXqd
 */
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import model.UserDTO;

/**
 * 
 * @author Administrator
 */
public class UserDAO {

	static DataProvider dataProvider = new DataProvider();
	static Statement stm = null;

	/**
	 * 
	 * @param user
	 * @return
	 * @throws SQLException
	 * @throws ClassNotFoundException
	 * @throws InstantiationException
	 * @throws IllegalAccessException
	 */
	public UserDTO insert(UserDTO user) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		UserDAO.stm = conn.createStatement();
		/* stm.executeUpdate("INSERT INTO user(username, password, email, fullname, role_id, phone) VALUES "
		+ "('" + user.getUsername() + "',"
		+ "'" + user.getPassword() + "',"
		+ "'" + user.getEmail() + "',"
		+ "'" + user.getFullname() + "',"
		+ "'" + user.getRoleId() + "',"
		+ "'"+ user.getPhone() + "')");*/
		stm.executeUpdate("INSERT INTO user(username, password, email, fullname, role_id, phone)"
			+ " VALUES ('" + user.getUsername() + "','" + user.getPassword() + "','" + user.getEmail() + "','" + user.getFullname() + "',1,'" + user.getPhone() + "')");
		return user;
	}

	/**
	 * 
	 * @param user
	 * @throws SQLException
	 * @throws ClassNotFoundException
	 * @throws InstantiationException
	 * @throws IllegalAccessException
	 */
	public void delete(UserDTO user) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		UserDAO.stm = conn.createStatement();
		stm.executeUpdate("UPDATE user SET status = 0 where id = " + user.getId());
	}

	/**
	 * 
	 * @param user
	 * @return
	 * @throws SQLException
	 * @throws ClassNotFoundException
	 * @throws InstantiationException
	 * @throws IllegalAccessException
	 */
	public UserDTO login(UserDTO user) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		UserDAO.stm = conn.createStatement();
		ResultSet rs = stm.executeQuery("SELECT * from user where "
			+ "username ='" + user.getUsername()
			+ "' and password = '" + user.getPassword() + "'");
		// if username and password are matched
		if (rs.next()) {
			user.setPassword(rs.getString("password"));
			user.setUsername(rs.getString("username"));
			user.setRoleId(rs.getInt("role_id"));
			user.setPhone(rs.getString("phone"));
			user.setEmail(rs.getString("email"));
			user.setFullname(rs.getString("fullname"));
			user.setId(rs.getInt("id"));
			return user;
		}
		return null;
	}
}
