package data;

import com.mysql.jdbc.PreparedStatement;

public interface IDTO {

	static DataProvider dataProvider = new DataProvider();
    static PreparedStatement stm = null;
}
