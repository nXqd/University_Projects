/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author Administrator
 */
public class OrderDetailDTO {
	int id;
	int refridgeratorId;
	int count;

	public OrderDetailDTO(int id, int refridgeratorId, int count) {
		this.id = id;
		this.refridgeratorId = refridgeratorId;
		this.count = count;
	}

	public OrderDetailDTO() {
	}

	

	/**
	 * 
	 * @return
	 */
	public int getCount() {
		return count;
	}

	/**
	 * 
	 * @param count
	 */
	public void setCount(int count) {
		this.count = count;
	}

	/**
	 * 
	 * @return
	 */
	public int getId() {
		return id;
	}

	/**
	 * 
	 * @param id
	 */
	public void setId(int id) {
		this.id = id;
	}

	/**
	 * 
	 * @return
	 */
	public int getRefridgeratorId() {
		return refridgeratorId;
	}

	/**
	 * 
	 * @param refridgeratorId
	 */
	public void setRefridgeratorId(int refridgeratorId) {
		this.refridgeratorId = refridgeratorId;
	}
}
