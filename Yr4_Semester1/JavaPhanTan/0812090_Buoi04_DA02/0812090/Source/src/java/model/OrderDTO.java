/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

import java.util.Date;

/**
 *
 * @author Administrator
 */
public class OrderDTO {
	int id;
	Date time;
	int orderStatusId;
	int userId;
	String orderDetailIds;

	public OrderDTO() {
	}

	public OrderDTO(int id, Date time, int orderStatusId, int userId, String orderDetailIds) {
		this.id = id;
		this.time = time;
		this.orderStatusId = orderStatusId;
		this.userId = userId;
		this.orderDetailIds = orderDetailIds;
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
	public String getOrderDetailIds() {
		return orderDetailIds;
	}

	/**
	 * 
	 * @param orderDetailIds
	 */
	public void setOrderDetailIds(String orderDetailIds) {
		this.orderDetailIds = orderDetailIds;
	}

	/**
	 * 
	 * @return
	 */
	public int getOrderStatusId() {
		return orderStatusId;
	}

	/**
	 * 
	 * @param orderStatusId
	 */
	public void setOrderStatusId(int orderStatusId) {
		this.orderStatusId = orderStatusId;
	}

	/**
	 * 
	 * @return
	 */
	public Date getTime() {
		return time;
	}

	/**
	 * 
	 * @param time
	 */
	public void setTime(Date time) {
		this.time = time;
	}

	/**
	 * 
	 * @return
	 */
	public int getUserId() {
		return userId;
	}

	/**
	 * 
	 * @param userId
	 */
	public void setUserId(int userId) {
		this.userId = userId;
	}
}
