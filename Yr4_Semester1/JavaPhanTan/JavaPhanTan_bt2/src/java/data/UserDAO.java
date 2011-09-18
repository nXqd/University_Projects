/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

/**
 *
 * @author nXqd
 */
import com.mysql.jdbc.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import model.User;

public class UserDAO {

	static DataProvider dataProvider = new DataProvider();
	static CallableStatement stm = null;

	public User insertUser(User user) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		this.stm = (CallableStatement) conn.createStatement();
		stm.executeUpdate("INSERT INTO user(username, password, email, fullname, role_id, phone) VALUES "
			+ "(" + user.getUsername() + ","
			+ user.getPassword() + ","
			+ user.getEmail() + ","
			+ user.getFullname() + ","
			+ user.getRoleId() + ","
			+ user.getPhone() + ")");
		return user;
	}

	public void deleteUser(User user) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		this.stm = (CallableStatement) conn.createStatement();
		stm.executeUpdate("UPDATE user SET status = 0 where id = " + user.getId());
	}

	public boolean loginUser(User user) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		this.stm = (CallableStatement) conn.createStatement();
		ResultSet rs = stm.executeQuery("SELECT id FROM user WHERE"
			+ "username = " + user.getUsername()
			+ " AND password = " + user.getPassword());
		// if username and password are matched
		if (rs.next())
			return true;
		return false;
	} 
}
