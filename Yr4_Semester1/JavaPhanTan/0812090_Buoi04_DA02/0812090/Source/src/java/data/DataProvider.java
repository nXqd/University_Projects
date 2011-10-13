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
import java.sql.DriverManager;
import java.sql.SQLException;

/**
 * 
 * @author Administrator
 */
public class DataProvider {

	static final String DB_URL = "jdbc:mysql://localhost/java_buoi04";
	static final String USER = "root";
	static final String PASS = "root";
	static Connection _conn = null;

	public DataProvider(String url, String user, String pass) throws ClassNotFoundException, SQLException, InstantiationException, IllegalAccessException {
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		if (_conn == null) {
			_conn = DriverManager.getConnection(DB_URL, USER, PASS);
		}
	}

	DataProvider() {
	}

	/**
	 * 
	 * @return
	 * @throws SQLException
	 * @throws ClassNotFoundException
	 * @throws InstantiationException
	 * @throws IllegalAccessException
	 */
	public Connection getConnection() throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		if (_conn == null) {
			_conn = DriverManager.getConnection(DB_URL, USER, PASS);
		}
		return _conn;
	}

	/**
	 * 
	 * @throws SQLException
	 */
	public void closeConnection() throws SQLException {
		if (_conn != null) {
			_conn.close();
		}
	}
}
