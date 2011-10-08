/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author nXqd
 */
public class RefridgeratorDTO {

    int _id;
    String _name;
    int _manufacturorId;
    String _capacity;
    String _doorStyle;
    int _doorCount;
    String _feature;
    String _composition;
    String _power;
    String _size;
    float _price;
    String _warranty;
    int _quantity;
    boolean _status;
    String _images;
    boolean _featured;

	public RefridgeratorDTO(int _id, String _name, int _manufacturorId, String _capacity, String _doorStyle, int _doorCount, String _feature, String _composition, String _power, String _size, float _price, String _warranty, int _quantity, boolean _status, String _images, boolean _featured) {
		this._id = _id;
		this._name = _name;
		this._manufacturorId = _manufacturorId;
		this._capacity = _capacity;
		this._doorStyle = _doorStyle;
		this._doorCount = _doorCount;
		this._feature = _feature;
		this._composition = _composition;
		this._power = _power;
		this._size = _size;
		this._price = _price;
		this._warranty = _warranty;
		this._quantity = _quantity;
		this._status = _status;
		this._images = _images;
		this._featured = _featured;
	}

	public RefridgeratorDTO() {
	}


    /**
     * 
     * @return
     */
    public boolean isFeatured(){
        return _featured;
    }

    /**
     * 
     * @param featured
     */
    public void setFeatured(boolean featured){
        _featured = featured;
    }

    /**
     * 
     * @return
     */
    public String getCapacity() {
        return _capacity;
    }

    /**
     * 
     * @param _capacity
     */
    public void setCapacity(String _capacity) {
        this._capacity = _capacity;
    }

    /**
     * 
     * @return
     */
    public String getComposition() {
        return _composition;
    }

    /**
     * 
     * @param _composition
     */
    public void setComposition(String _composition) {
        this._composition = _composition;
    }

    /**
     * 
     * @return
     */
    public int getDoorCount() {
        return _doorCount;
    }

    /**
     * 
     * @param _doorCount
     */
    public void setDoorCount(int _doorCount) {
        this._doorCount = _doorCount;
    }

    /**
     * 
     * @return
     */
    public String getDoorStyle() {
        return _doorStyle;
    }

    /**
     * 
     * @param _doorStyle
     */
    public void setDoorStyle(String _doorStyle) {
        this._doorStyle = _doorStyle;
    }

    /**
     * 
     * @return
     */
    public String getFeature() {
        return _feature;
    }

    /**
     * 
     * @param _feature
     */
    public void setFeature(String _feature) {
        this._feature = _feature;
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
    public int getManufacturorId() {
        return _manufacturorId;
    }

    /**
     * 
     * @param _manufacturorId
     */
    public void setManufacturorId(int _manufacturorId) {
        this._manufacturorId = _manufacturorId;
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

    /**
     * 
     * @return
     */
    public String getPower() {
        return _power;
    }

    /**
     * 
     * @param _power
     */
    public void setPower(String _power) {
        this._power = _power;
    }

    /**
     * 
     * @return
     */
    public float getPrice() {
        return _price;
    }

    /**
     * 
     * @param _price
     */
    public void setPrice(float _price) {
        this._price = _price;
    }

    /**
     * 
     * @return
     */
    public int getQuantity() {
        return _quantity;
    }

    /**
     * 
     * @param _quantity
     */
    public void setQuantity(int _quantity) {
        this._quantity = _quantity;
    }

    /**
     * 
     * @return
     */
    public String getSize() {
        return _size;
    }

    /**
     * 
     * @param _size
     */
    public void setSize(String _size) {
        this._size = _size;
    }

    /**
     * 
     * @return
     */
    public boolean isStatus() {
        return _status;
    }

    /**
     * 
     * @param _status
     */
    public void setStatus(boolean _status) {
        this._status = _status;
    }

    /**
     * 
     * @return
     */
    public String getWarranty() {
        return _warranty;
    }

    /**
     * 
     * @param _warranty
     */
    public void setWarranty(String _warranty) {
        this._warranty = _warranty;
    }

    /**
     * 
     * @return
     */
    public String getImages() {
        return _images;
    }

    /**
     * 
     * @param _images
     */
    public void setImages(String _images) {
        this._images = _images;
    }
}
