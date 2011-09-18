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
import java.sql.SQLException;
import java.sql.ResultSet;
import model.Refridgerator;

public class RefridgeratorDAO {

	static DataProvider dataProvider = new DataProvider();
	static CallableStatement stm = null;

	public Refridgerator insertRefridgerator(Refridgerator refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		this.stm = (CallableStatement) conn.createStatement();
		stm.executeUpdate("INSERT INTO refridgerator(name, manufacturor, capacity, door_style, door_count, feature, composition, power, size, price, warranty, quantity, status, images) VALUES"
			+ "(" + refridgerator.getName() + ","
			+ refridgerator.getManufacturor() + ","
			+ refridgerator.getCapacity() + ","
			+ refridgerator.getDoorStyle() + ","
			+ refridgerator.getDoorCount() + ","
			+ refridgerator.getFeature() + ","
			+ refridgerator.getComposition() + ","
			+ refridgerator.getPower() + ","
			+ refridgerator.getSize() + ","
			+ refridgerator.getPrice() + ","
			+ refridgerator.getWarranty() + ","
			+ refridgerator.getQuantity() + ","
			+ refridgerator.isStatus() + ","
			+ refridgerator.getImages() + ")");
		return refridgerator;
	}

	public void deleteRefridgerator(Refridgerator refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		this.stm = (CallableStatement) conn.createStatement();
		stm.executeUpdate("UPDATE Refridgerator SET status = 0 WHERE id =" + refridgerator.getId());
	}

	public void updateRefridgerator(Refridgerator refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		this.stm = (CallableStatement) conn.createStatement();
		stm.executeUpdate("UPDATE refridgerator "
			+ "SET name=" + refridgerator.getName()
			+ ",manufacturor=" + refridgerator.getManufacturor()
			+ ",capacity=" + refridgerator.getCapacity()
			+ ",door_style=" + refridgerator.getDoorStyle()
			+ ",door_count=" + refridgerator.getDoorCount()
			+ ",feature=" + refridgerator.getFeature()
			+ ",composition=" + refridgerator.getComposition()
			+ ",power=" + refridgerator.getPower()
			+ ",size=" + refridgerator.getSize()
			+ ",price=" + refridgerator.getPrice()
			+ ",warranty=" + refridgerator.getWarranty()
			+ ",quantity=" + refridgerator.getQuantity()
			+ ",status=" + refridgerator.isStatus()
			+ ",images=" + refridgerator.getImages()
			+ "WHERE id = " + refridgerator.getId());
	}

	public Refridgerator selectRefridgerator(Refridgerator refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
		Connection conn = dataProvider.getConnection();
		this.stm = (CallableStatement) conn.createStatement();
		java.sql.ResultSet rs = stm.executeQuery("SELECT * FROM refridgerator WHERE id =" + refridgerator.getId());
		if (rs.next()) {
			refridgerator.setId(rs.getInt("id"));
			refridgerator.setName(rs.getString("name"));
			refridgerator.setManufacturor(rs.getString("manufacturor"));
			refridgerator.setCapacity(rs.getString("capacity"));
			refridgerator.setDoorStyle(rs.getString("door_style"));
			refridgerator.setDoorCount(rs.getInt("door_count"));
			refridgerator.setFeature(rs.getString("feature"));
			refridgerator.setComposition(rs.getString("composition"));
			refridgerator.setPower(rs.getString("power"));
			refridgerator.setSize(rs.getString("size"));
			refridgerator.setPrice(rs.getFloat("price"));
			refridgerator.setWarranty(rs.getString("warranty"));
			refridgerator.setQuantity(rs.getInt("quantity"));
			refridgerator.setStatus(rs.getBoolean("status"));
			refridgerator.setImages(rs.getString("images"));
		}
		return refridgerator;
	}
}
