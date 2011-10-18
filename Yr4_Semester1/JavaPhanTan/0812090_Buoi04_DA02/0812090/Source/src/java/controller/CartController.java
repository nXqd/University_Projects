package controller;

import data.OrderDAO;
import data.OrderDetailDAO;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.*;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;
import model.RefridgeratorDTO;

/**
 *
 * @author nXqd - nxqd.inbox@gmail.com
 */
public class CartController extends HttpServlet {


	/*
	 * OrderDTO orderDTO = new OrderDTO() {{
	 * setUserId(1); // just for testing
	 * setTime(new Date());
	 * setOrderStatusId(1);
	 * }};
	 *
	 * // set OrderDetailids
	 * String orderDetailIds = new String();
	 *
	 * for ( Item itemTmp : items) {
	 * OrderDetailDTO dto = new OrderDetailDTO();
	 * dto.setCount(itemTmp.getQuantity());
	 * dto.setRefridgeratorId(itemTmp.getId());
	 * // insert order detail to database
	 * orderDetailDAO.insert(dto);
	 * orderDetailIds += dto.getId() + ",";
	 * }
	 *
	 * orderDTO.setOrderDetailIds(orderDetailIds);
	 * // insert orderDTO to database
	 * orderDAO.insert(orderDTO); */


	public class Item {
		private int _id;
		private int _quantity;
		private float _price;
		private String _name;

		public String getName() {
			return _name;
		}

		public void setName(String _name) {
			this._name = _name;
		}

		public float getPrice() {
			return _price;
		}

		public void setPrice(float _price) {
			this._price = _price;
		}

		public int getId() {
			return _id;
		}

		public void setId(int id) {
			this._id = id;
		}

		public int getQuantity() {
			return _quantity;
		}

		public void setQuantity(int quantity) {
			this._quantity = quantity;
		}
	}

	private static List<Item> items;

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

		HttpSession session = request.getSession();
		// get items which are already in cart
		items = (List<Item>)session.getAttribute("cartItems");
		if (items == null)
			items = new ArrayList<Item>();

		// @todo: TEST
		items.add(new Item() {{ setId(1); setPrice((float)10.0); setName("sddsf");}});
		items.add(new Item() {{ setId(1); setPrice((float)10.0); setName("sddsf");}});
		items.add(new Item() {{ setId(1); setPrice((float)10.0); setName("sddsf");}});
		items.add(new Item() {{ setId(1); setPrice((float)10.0); setName("sddsf");}});
		session.setAttribute("cartItems", items);
		session.setAttribute("totalPrice", (float)20.50);

		if ("checkout".equals(request.getParameter("action")) && items.size() > 0) {
			try {
				OrderDAO orderDAO = new OrderDAO();
				OrderDetailDAO orderDetailDAO = new OrderDetailDAO();

				List<RefridgeratorDTO> list = new ArrayList<RefridgeratorDTO>();

				session.setAttribute("cartItems", items);
			} catch ( Exception ex ) { }
		}

		// forward to cart page
		RequestDispatcher view = request.getRequestDispatcher("new-cart.jsp");
		view.forward(request, response);
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

		HttpSession session = request.getSession(true);

		if (request.getParameter("quantity") != null && request.getParameter("id") != null) {
			AddItem(request, session);
			// get total price
			/* for(Item itemTmp : items) {
			 * RefridgeratorDTO dto = new RefridgeratorDTO();
			 * dto.setId(itemTmp.id);
			 * dto = dao.get(dto);
			 * totalPrice += dto.getPrice() * itemTmp.quantity;
			 * } */

			session.setAttribute("cartItems", items);
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

	private void AddItem(HttpServletRequest request, HttpSession session) throws NumberFormatException {
		Item item = new Item();
		item.setId(Integer.parseInt(request.getParameter("id")));
		item.setQuantity(Integer.parseInt(request.getParameter("quantity")));

		RefridgeratorDTO refridDTO = new RefridgeratorDTO();
		refridDTO.setId(item.getId());
		item.setPrice(refridDTO.getPrice());

		if (session.getAttribute("cartItems") == null) {
			session.setAttribute("cartItems", items);
		} else {
			items = (List<Item>)session.getAttribute("cartItems");
		}

		// check if this product id is already in cart list, increase the quantity
		boolean hasItem = false;
		for(Item itemTmp : items) {
			if ( itemTmp.getId() == item.getId() ) {
				itemTmp.setQuantity(itemTmp.getQuantity()+item.getQuantity());
				hasItem = true;
				break;
			}
		}
		// if there is not this product in cart then just add it
		if (!hasItem) items.add(item);
	}
}