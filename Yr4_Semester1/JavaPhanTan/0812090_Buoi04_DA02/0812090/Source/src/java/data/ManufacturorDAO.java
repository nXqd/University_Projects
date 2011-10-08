/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package data;

import java.sql.*;
import java.util.AbstractList;
import java.util.ArrayList;
import java.util.List;
import model.ManufacturorDTO;

/**
 *
 * @author Administrator
 */
public class ManufacturorDAO {
static DataProvider dataProvider = new DataProvider();
    static PreparedStatement stm = null;

    /**
     * 
     * @param manu
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public ManufacturorDTO getNameById(ManufacturorDTO manu) throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
        Connection conn = dataProvider.getConnection();
		stm = conn.prepareStatement("SELECT * FROM `manufacturor` WHERE id = ?");
		stm.setInt(1, manu.getId());
		ResultSet rs = stm.executeQuery();

		if (rs.next()) {
			manu.setId(rs.getInt("id"));
			manu.setName(rs.getString("name"));
		}
		return manu;
    }

    /**
     * 
     * @return
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws InstantiationException
     * @throws IllegalAccessException
     */
    public List<ManufacturorDTO> get() throws SQLException, ClassNotFoundException, InstantiationException, IllegalAccessException {
	    Connection conn = dataProvider.getConnection();
	    List<ManufacturorDTO> list = new ArrayList<ManufacturorDTO> ();
	    stm = conn.prepareStatement("SELECT * FROM `manufacturor`");
	    ResultSet rs = stm.executeQuery();
	    while (rs.next()) {
		    ManufacturorDTO manu = new ManufacturorDTO();
		    manu.setId(rs.getInt("id"));
		    manu.setName(rs.getString("name"));
		    list.add(manu);
	    }
	    return list;
    }

}
