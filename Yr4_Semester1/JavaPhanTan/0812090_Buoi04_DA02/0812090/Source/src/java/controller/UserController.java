package controller;

import data.UserDAO;
import java.io.IOException;
import java.io.PrintWriter;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import model.UserDTO;
import net.tanesha.recaptcha.*;

public class UserController extends HttpServlet {
	
	private static UserDAO userDAO = new UserDAO();
	
	/**
	 * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
	 * @param request servlet request
	 * @param response servlet response
	 * @throws ServletException if a servlet-specific error occurs
	 * @throws IOException if an I/O error occurs
	 */
	protected void processRequest(HttpServletRequest request, HttpServletResponse response)
			throws ServletException, IOException {
		response.setContentType("text/html;charset=UTF-8");
		PrintWriter out = response.getWriter();
		try {
			/* TODO output your page here
			 * out.println("<html>");
			 * out.println("<head>");
			 * out.println("<title>Servlet UserController</title>");
			 * out.println("</head>");
			 * out.println("<body>");
			 * out.println("<h1>Servlet UserController at " + request.getContextPath () + "</h1>");
			 * out.println("</body>");
			 * out.println("</html>");
			 */
		} finally {
			out.close();
		}
	}
	
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
		// recaptCha HTML
		ReCaptcha c = ReCaptchaFactory.newReCaptcha("6LcPesgSAAAAAIjbb3M3M-h8HRk5i2skREBLbxTG ", "6LcPesgSAAAAAEVDo4xq4RiQQY__dVfCCiHPRiKT", false);
		request.setAttribute("recaptchaHTML", c.createRecaptchaHtml(null, null));
		RequestDispatcher req = request.getRequestDispatcher("new-login.jsp");
		req.forward(request, response);
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
			throws ServletException, IOException{
		
		// Register user
		if (request.getParameter("type") != null) {
			String remoteAddr = request.getRemoteAddr();
			ReCaptchaImpl reCaptcha = new ReCaptchaImpl();
			reCaptcha.setPrivateKey("6LcPesgSAAAAAEVDo4xq4RiQQY__dVfCCiHPRiKT");
			
			String challenge = request.getParameter("recaptcha_challenge_field");
			String uresponse = request.getParameter("recaptcha_response_field");
			ReCaptchaResponse reCaptchaResponse = reCaptcha.checkAnswer(remoteAddr, challenge, uresponse);
			
			// end captcha
			if (reCaptchaResponse.isValid()) {
				String type = request.getParameter("type");
				UserDTO userDTO = null;
				// Login
				if ("login".equals(type)) {
					try {

						userDTO.setUsername(request.getParameter("user"));
						userDTO.setPassword(request.getParameter("pass"));
						userDTO = userDAO.login(userDTO);

					} catch (SQLException ex) {
						Logger.getLogger(UserController.class.getName()).log(Level.SEVERE, null, ex);
					} catch (ClassNotFoundException ex) {
						Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
					} catch (InstantiationException ex) {
						Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
					} catch (IllegalAccessException ex) {
						Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
					}
					// Register
				} else if ("register".equals(type)) {

					userDTO = new UserDTO();
					userDTO.setUsername(request.getParameter("user"));
					userDTO.setPassword(request.getParameter("pass"));
					userDTO.setFullname(request.getParameter("fullname"));
					userDTO.setEmail(request.getParameter("email"));
					userDTO.setPhone(request.getParameter("phone"));

					try {
						userDTO = userDAO.insert(userDTO);
					} catch (SQLException ex) {
						Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
					} catch (ClassNotFoundException ex) {
						Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
					} catch (InstantiationException ex) {
						Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
					} catch (IllegalAccessException ex) {
						Logger.getLogger(UserDTO.class.getName()).log(Level.SEVERE, null, ex);
					}
				}
				if (userDTO != null) {
					HttpSession session = request.getSession(true);
					session.setAttribute("user", userDTO);
					// create recaptcha HTML
					// forward the attributes
					RequestDispatcher req = request.getRequestDispatcher("DisplayQuestions.jsp");
					req.forward(request, response);
				}
			}
		}
		
		
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
