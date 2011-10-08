/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package controller;

import java.io.IOException;
import java.io.PrintWriter;
import java.util.Enumeration;
import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 *
 * @author Administrator
 */
@WebServlet(name = "Register", urlPatterns = {"/User/Register"})
public class Register extends HttpServlet {

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
			out.println("<!DOCTYPE html>");
			out.println("<html>");
			out.println("    <head>");
			out.println("");
			out.println("        <title>");
			out.println("            Retreat Registration");
			out.println("        </title>");
			out.println("");
			out.println("        <!-- Meta Tags -->");
			out.println("        <meta charset='utf-8'>");
			out.println("        <meta name='generator' content='Wufoo.com' />");
			out.println("");
			out.println("        <!-- CSS -->");
			out.println("        <link rel='stylesheet' href='css/structure.css' type='text/css' />");
			out.println("        <link rel='stylesheet' href='css/form.css' type='text/css' />");
			out.println("");
			out.println("        <!-- JavaScript -->");
			out.println("        <script src='scripts/wufoo.js'></script>");
			out.println("");
			out.println("        <!--[if lt IE 10]>");
			out.println("        <script src='http://html5shiv.googlecode.com/svn/trunk/html5.js'></script>");
			out.println("        <![endif]-->");
			out.println("    </head>");
			out.println("");
			out.println("    <body id='public'>");
			out.println("        <div id='container' class='ltr'>");
			out.println("");
			out.println("            <h1 id='logo'>");
			out.println("                <a href='http://wufoo.com' title='Powered by Wufoo'>Wufoo</a>");
			out.println("            </h1>");
			out.println("");
			out.println("            <form id='form69' name='form69' class='wufoo topLabel page' autocomplete='off' enctype='multipart/form-data' method='post' novalidate action='Register'/>");
//			out.println("                action='" + request.getContextPath() + "/Register'/>");
			out.println("");
			out.println("                <header id='header' class='info'>");
			out.println("                <h2>Registration</h2>");
			out.println("                <div>Nov 24 - 25 (Sat, Sun, Mon)</div>");
			out.println("                </header>");
			out.println("");
			out.println("                <ul>");
			out.println("");
			out.println("                    <li id='foli0' class='     '>");
			out.println("                    <label class='desc' id='title0' for='Field0'>");
			out.println("                        Registration");
			out.println("                    </label>");
			out.println("                    <span>");
			out.println("                        <input id='Field0' name='Field0' type='text' class='field text fn' value='' size='14' tabindex='1' />");
			out.println("                        <label for='Field0'>Fullname</label>");
			out.println("                    </span>");
			out.println("                    <span>");
			out.println("                        <input id='Field1' name='Field1' type='text' class='field text ln' value='' size='14' tabindex='2' />");
			out.println("                        <label for='Field1'>Username</label>");
			out.println("                    </span>");
			out.println("                    <span>");
			out.println("                        <input id='Field2' name='Field2' type='text' class='field text ln' value='' size='14' tabindex='2' />");
			out.println("                        <label for='Field2'>Password</label>");
			out.println("                    </span>");
			out.println("                    <span>");
			out.println("                        <input id='Field3' name='Field3' type='text' class='field text ln' value='' size='14' tabindex='2' />");
			out.println("                        <label for='Field3'>Email</label>");
			out.println("                    </span>");
			out.println("                    <span>");
			out.println("                        <input id='Field4' name='Field4' type='text' class='field text ln' value='' size='14' tabindex='2' />");
			out.println("                        <label for='Field4'>Phone</label>");
			out.println("                    </span>");
			out.println("                    </li>");
			out.println("                    <li class='buttons '>");
			out.println("                    <div>");
			out.println("");
			out.println("                        <input id='saveForm' name='saveForm' class='btTxt submit' type='submit' value='Submit'");
			out.println("                        /></div>");
			out.println("                    </li>");
			out.println("");
			out.println("                </ul>");
			out.println("            </form>");
			out.println("");
			out.println("        </div><!--container-->");
			out.println("        <img id='bottom' src='images/bottom.png' alt='' />");
			out.println("");
			out.println("        <a class='powertiny' href='http://wufoo.com/tour/' title='Powered by Wufoo'");
			out.println("            style='display:block !important;visibility:visible !important;text-indent:0 !important;position:relative !important;height:auto !important;width:95px !important;overflow:visible !important;text-decoration:none;cursor:pointer !important;margin:0 auto !important'>");
			out.println("            <span style='background:url(./images/powerlogo.png) no-repeat center 7px; margin:0 auto;display:inline-block !important;visibility:visible !important;text-indent:-9000px !important;position:static !important;overflow: auto !important;width:62px !important;height:30px !important'>Wufoo</span>");
			out.println("            <b style='display:block !important;visibility:visible !important;text-indent:0 !important;position:static !important;height:auto !important;width:auto !important;overflow: auto !important;font-weight:normal;font-size:9px;color:#777;padding:0 0 0 3px;'>Designed</b>");
			out.println("        </a>");
			out.println("    </body>");
			out.println("</html>");


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
		String fullname = request.getParameter("Field0");
		String username = request.getParameter("Field1");
		String password = request.getParameter("Field2");
		String email = request.getParameter("Field3");
		String phone = request.getParameter("Field4");
		Enumeration paramNames = request.getParameterNames();

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
