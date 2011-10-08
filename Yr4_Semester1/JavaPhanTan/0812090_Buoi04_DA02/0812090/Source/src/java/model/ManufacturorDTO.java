/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.io.Serializable;

/**
 *
 * @author Administrator
 */
public class ManufacturorDTO implements Serializable {

	int _id;
	String _name;

	public ManufacturorDTO(int _id, String _name) {
		this._id = _id;
		this._name = _name;
	}

	public ManufacturorDTO() {
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
	public String getName() {
		return _name;
	}

	/**
	 * 
	 * @param _name
	 */
	public void setName(String _name) {
		this._name = _name;
	}

}
