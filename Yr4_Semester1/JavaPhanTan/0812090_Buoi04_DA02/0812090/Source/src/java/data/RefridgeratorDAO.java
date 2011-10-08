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
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import model.ManufacturorDTO;
import model.RefridgeratorDTO;

/**
 * 
 * @author Administrator
 */
public class RefridgeratorDAO {

    static DataProvider dataProvider = new DataProvider();
    static PreparedStatement stm = null;

    /**
     * 
     * @param refridgerator
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public RefridgeratorDTO insert(RefridgeratorDTO refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        RefridgeratorDAO.stm = conn.prepareStatement("INSERT INTO `refridgerator`(`name`, `manufacturor_id`, `capacity`, `door_style`, `door_count`, `feature`, `composition`, `power`, `size`, `price`, `warranty`, `quantity`, `images`, `featured`) VALUES"
                + " (?,?,?,?,?,?,?,?,?,?,?,?,?,?)");
        stm.setString(1, refridgerator.getName());
        stm.setInt(2, refridgerator.getManufacturorId());
        stm.setString(3, refridgerator.getCapacity());
        stm.setString(4, refridgerator.getDoorStyle());
        stm.setInt(5, refridgerator.getDoorCount());
        stm.setString(6, refridgerator.getFeature());
        stm.setString(7, refridgerator.getComposition());
        stm.setString(8, refridgerator.getPower());
        stm.setString(9, refridgerator.getSize());
        stm.setFloat(10, refridgerator.getPrice());
        stm.setString(11, refridgerator.getWarranty());
        stm.setInt(12, refridgerator.getQuantity());
        stm.setString(13, refridgerator.getImages());
        stm.setBoolean(14, refridgerator.isFeatured());

        stm.executeUpdate();

        return refridgerator;
    }

    /**
     * 
     * @param refridgerator
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public void delete(RefridgeratorDTO refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        int id = getIdbyName(refridgerator);
        RefridgeratorDAO.stm = conn.prepareStatement("UPDATE Refridgerator SET status = 0 WHERE id = ?");
        stm.setInt(1, id);
        stm.executeUpdate();
    }

    private int getIdbyName(RefridgeratorDTO ref) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        RefridgeratorDAO.stm = conn.prepareStatement("SELECT id FROM refridgerator WHERE name = ?");
        stm.setString(1, ref.getName());
        ResultSet rs = stm.executeQuery();
        if (rs.next()) { return rs.getInt("id"); }
        return -1;
    }

    /**
     * 
     * @param refridgerator
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public void update(RefridgeratorDTO refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        RefridgeratorDAO.stm = conn.prepareStatement("UPDATE `refridgerator` SET `name`=?,`manufacturor_id`=?,`capacity`=?,`door_style`=?,`door_count`=?,`feature`=?,`composition`=?,`power`=?,`size`=?,`price`=?,`warranty`=?,`quantity`=?,`status`=?,`images`=?, `featured`=? WHERE id = ?");
        stm.setString(1, refridgerator.getName());
        stm.setInt(2, refridgerator.getManufacturorId());
        stm.setString(3, refridgerator.getCapacity());
        stm.setString(4, refridgerator.getDoorStyle());
        stm.setInt(5, refridgerator.getDoorCount());
        stm.setString(6, refridgerator.getFeature());
        stm.setString(7, refridgerator.getComposition());
        stm.setString(8, refridgerator.getPower());
        stm.setString(9, refridgerator.getSize());
        stm.setFloat(10, refridgerator.getPrice());
        stm.setString(11, refridgerator.getWarranty());
        stm.setInt(12, refridgerator.getQuantity());
        stm.setBoolean(13, refridgerator.isStatus());
        stm.setString(14, refridgerator.getImages());
        stm.setInt(15, refridgerator.getId());
        stm.setBoolean(16, refridgerator.isFeatured());
        stm.executeUpdate();
    }

    /**
     * 
     * @param refridgerator
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public RefridgeratorDTO get(RefridgeratorDTO refridgerator) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        stm = conn.prepareStatement("SELECT * FROM `refridgerator` WHERE id = ?");
        stm.setInt(1, refridgerator.getId());
        ResultSet rs = stm.executeQuery();

        if (rs.next()) {
            refridgerator.setId(rs.getInt("id"));
            refridgerator.setName(rs.getString("name"));
            refridgerator.setManufacturorId(rs.getInt("manufacturor_id"));
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
            refridgerator.setFeatured(rs.getBoolean("featured"));
        }
        return refridgerator;
    }

    /**
     * 
     * @param number
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public List<RefridgeratorDTO> getByNumber(int number) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        stm = conn.prepareStatement("SELECT * FROM `refridgerator` LIMIT ?");
        stm.setInt(1, number);
        ResultSet rs = stm.executeQuery();
        return getListProduct(rs);
    }

    /**
     * 
     * @param str
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public List<RefridgeratorDTO> search(String str) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        stm = conn.prepareStatement("SELECT * FROM `refridgerator` WHERE name LIKE ?");
        stm.setString(1, "%" + str + "%");
        ResultSet rs = stm.executeQuery();
        return getListProduct(rs);
    }

    /**
     * 
     * @param manu
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public List<RefridgeratorDTO> getByManufacturor(ManufacturorDTO manu) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        stm = conn.prepareStatement("SELECT * FROM `refridgerator` WHERE manufacturor_id = ?");
        stm.setInt(1, manu.getId());
        ResultSet rs = stm.executeQuery();
        return getListProduct(rs);
    }

    /**
     * 
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public List<RefridgeratorDTO> getAll() throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        stm = conn.prepareStatement("SELECT * FROM `refridgerator`");
        ResultSet rs = stm.executeQuery();
        return getListProduct(rs);
    }

    /**
     * 
     * @param manuId
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public List<RefridgeratorDTO> searchByManufacturor(int manuId) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        stm = conn.prepareStatement("SELECT * FROM `refridgerator` where manufacturor_id = ?");
        stm.setInt(1, manuId);
        ResultSet rs = stm.executeQuery();
        return getListProduct(rs);
    }
    // Get featured products

    /**
     * 
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public List<RefridgeratorDTO> getFeatureds() throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
        stm = conn.prepareStatement("SELECT * FROM `refridgerator` where featured = 1");
        ResultSet rs = stm.executeQuery();
        return getListProduct(rs);
    }

    private List<RefridgeratorDTO> getListProduct(ResultSet rs) throws SQLException {
        List<RefridgeratorDTO> list = new ArrayList<RefridgeratorDTO>();
        while (rs.next()) {
            RefridgeratorDTO refridgerator = new RefridgeratorDTO();
            refridgerator.setId(rs.getInt("id"));
            refridgerator.setName(rs.getString("name"));
            refridgerator.setManufacturorId(rs.getInt("manufacturor_id"));
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
            refridgerator.setFeatured(rs.getBoolean("featured"));

            list.add(refridgerator);
        }
        return list;
    }
}
