/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author nXqd
 */
public class User {
	int _id;
	String _username;
	String _password;
	String _email;
	String _fullname;
	int _roleId;
	String _phone;

	public String getEmail() {
		return _email;
	}

	public void setEmail(String _email) {
		this._email = _email;
	}

	public String getFullname() {
		return _fullname;
	}

	public void setFullname(String _fullname) {
		this._fullname = _fullname;
	}

	public int getId() {
		return _id;
	}

	public void setId(int _id) {
		this._id = _id;
	}

	public String getPassword() {
		return _password;
	}

	public void setPassword(String _password) {
		this._password = _password;
	}

	public String getPhone() {
		return _phone;
	}

	public void setPhone(String _phone) {
		this._phone = _phone;
	}

	public int getRoleId() {
		return _roleId;
	}

	public void setRoleId(int _roleId) {
		this._roleId = _roleId;
	}

	public String getUsername() {
		return _username;
	}

	public void setUsername(String _username) {
		this._username = _username;
	}

}
