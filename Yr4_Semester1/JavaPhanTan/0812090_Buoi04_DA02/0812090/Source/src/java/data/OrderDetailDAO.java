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
import model.OrderDetailDTO;

/**
 * 
 * @author Administrator
 */
public class OrderDetailDAO {

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
    public OrderDetailDTO insert(OrderDetailDTO dto) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
	    Connection conn = dataProvider.getConnection();
	    OrderDetailDAO.stm = conn.prepareStatement("INSERT INTO `orderdetail`(`refridgerator_id`, `count`) VALUES (?, ?)");
	    stm.setInt(1, dto.getRefridgeratorId());
	    stm.setInt(2, dto.getCount());
	    stm.executeUpdate();
	    return dto;
    }
}
