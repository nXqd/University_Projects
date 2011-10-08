/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author nXqd
 */
public class UserDTO {

	int _id;
	String _username;
	String _password;
	String _email;
	String _fullname;
	int _roleId;
	String _phone;

	public UserDTO() {
	}

	public UserDTO(int _id, String _username, String _password, String _email, String _fullname, int _roleId, String _phone) {
		this._id = _id;
		this._username = _username;
		this._password = _password;
		this._email = _email;
		this._fullname = _fullname;
		this._roleId = _roleId;
		this._phone = _phone;
	}

	/**
	 * 
	 * @return
	 */
	public String getEmail() {
		return _email;
	}

	/**
	 * 
	 * @param _email
	 */
	public void setEmail(String _email) {
		this._email = _email;
	}

	/**
	 * 
	 * @return
	 */
	public String getFullname() {
		return _fullname;
	}

	/**
	 * 
	 * @param _fullname
	 */
	public void setFullname(String _fullname) {
		this._fullname = _fullname;
	}

	/**
	 * 
	 * @return
	 */
	public int getId() {
		return _id;
	}

	/**
	 * 
	 * @param _id
	 */
	public void setId(int _id) {
		this._id = _id;
	}

	/**
	 * 
	 * @return
	 */
	public String getPassword() {
		return _password;
	}

	/**
	 * 
	 * @param _password
	 */
	public void setPassword(String _password) {
		this._password = _password;
	}

	/**
	 * 
	 * @return
	 */
	public String getPhone() {
		return _phone;
	}

	/**
	 * 
	 * @param _phone
	 */
	public void setPhone(String _phone) {
		this._phone = _phone;
	}

	/**
	 * 
	 * @return
	 */
	public int getRoleId() {
		return _roleId;
	}

	/**
	 * 
	 * @param _roleId
	 */
	public void setRoleId(int _roleId) {
		this._roleId = _roleId;
	}

	/**
	 * 
	 * @return
	 */
	public String getUsername() {
		return _username;
	}

	/**
	 * 
	 * @param _username
	 */
	public void setUsername(String _username) {
		this._username = _username;
	}
}
