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

public class DataProvider {

	static final String JDBC_DRIVER = "com.mysql.jdbc.Driver";
	static final String DB_URL = "jdbc:mysql://localhost/java_bt2";
	static final String USER = "root";
	static final String PASS = "root";
	static Connection conn = null;

	public Connection getConnection() throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Class.forName("com.mysql.jdbc.Driver").newInstance();
		if (conn == null) {
			conn = DriverManager.getConnection(DB_URL, USER, PASS);
		}
		return conn;
	}

	public void closeConnection() throws SQLException {
		if (conn != null) {
			conn.close();
		}
	}
}
