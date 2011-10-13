/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import data.DataProvider;
import data.ManufacturorDAO;
import data.RefridgeratorDAO;
import java.io.IOException;
import java.sql.SQLException;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author nXqd - nxqd.inbox@gmail.com
 */
public class IndexController extends HttpServlet {

	private static int _pageCount;
	private static int _ppp = 9;

    /**
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /**
     * Handles the HTTP <code>GET</code> method.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
        protected void doGet(HttpServletRequest request, HttpServletResponse response)
        throws ServletException, IOException {
		// TODO: this should be removed after test
		DataProvider dp = (DataProvider) getServletContext().getAttribute("dataProvider");

		try {
			// get all fridges from database then forward
			if (request.getParameter("currentPage") == null) {
				request.setAttribute("refrids", new RefridgeratorDAO(dp).getProductOfPage(0));
				request.setAttribute("page", 0);
			} else {
				int currentPage = Integer.parseInt(request.getParameter("currentPage"));
				request.setAttribute("refrids", new RefridgeratorDAO(dp).getProductOfPage(currentPage));
				request.setAttribute("page", currentPage);
			}

			// get numberOfPage
			request.setAttribute("pageCount", 3);

			// get all manufacturors for categories
			request.setAttribute("manus", new ManufacturorDAO().get());

			// get all featureds
			request.setAttribute("featureds", new RefridgeratorDAO(dp).getFeatureds());

			// forward to our index page
			RequestDispatcher view = request.getRequestDispatcher("new-index.jsp");
			view.forward(request, response);
		} catch (Exception ex) {}
	}

    /**
     * Handles the HTTP <code>POST</code> method.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
        protected void doPost(HttpServletRequest request, HttpServletResponse response)
        throws ServletException, IOException {

        }

    /**
     * Returns a short description of the servlet.
     * @return a String containing servlet description
     */
    @Override
        public String getServletInfo() {
            return "Short description";
        }// </editor-fold>

}
