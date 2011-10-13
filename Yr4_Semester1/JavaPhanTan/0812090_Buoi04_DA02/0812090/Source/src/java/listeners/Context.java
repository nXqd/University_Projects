package listeners;

import data.DataProvider;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.servlet.*;

public class Context implements ServletContextListener {

	@Override
	public void contextInitialized(ServletContextEvent sce) {
		ServletContext sc = sce.getServletContext();
		String url = sc.getInitParameter("DatabaseURL");
		String user = sc.getInitParameter("DatabaseUser");
		String pass = sc.getInitParameter("DatabasePass");
		try {
			
			DataProvider dp = new DataProvider(url, user, pass);
			sc.setAttribute("dataProvider", dp);
			
		} catch (ClassNotFoundException ex) {
			Logger.getLogger(Context.class.getName()).log(Level.SEVERE, null, ex);
		} catch (SQLException ex) {
			Logger.getLogger(Context.class.getName()).log(Level.SEVERE, null, ex);
		} catch (InstantiationException ex) {
			Logger.getLogger(Context.class.getName()).log(Level.SEVERE, null, ex);
		} catch (IllegalAccessException ex) {
			Logger.getLogger(Context.class.getName()).log(Level.SEVERE, null, ex);
		}

	}

	@Override
	public void contextDestroyed(ServletContextEvent sce) {
	}

		
}
