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
import java.sql.PreparedStatement;
import java.sql.SQLException;
import model.OrderDTO;

/**
 * 
 * @author Administrator
 */
public class OrderDAO {

    static DataProvider dataProvider = new DataProvider();
    static PreparedStatement stm = null;

    /**
     * 
     * @param dto
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public OrderDTO insert(OrderDTO dto) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
	    Connection conn = dataProvider.getConnection();
	    OrderDAO.stm = conn.prepareStatement("INSERT INTO `order`(`order_status_id`, `user_id`, `orderdetail_ids`) VALUES (?,?,?)");
	    stm.setInt(1, dto.getOrderStatusId());
	    stm.setInt(2, dto.getUserId());
	    stm.setString(3, dto.getOrderDetailIds());
	    stm.executeUpdate();
	    return dto;
    }
}
