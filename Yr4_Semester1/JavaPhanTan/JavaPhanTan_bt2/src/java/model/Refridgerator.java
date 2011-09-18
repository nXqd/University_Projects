/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package model;

/**
 *
 * @author nXqd
 */
public class Refridgerator {
    int _id;
    String _name;
    String _manufacturor;
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

    public String getCapacity() {
        return _capacity;
    }

    public void setCapacity(String _capacity) {
        this._capacity = _capacity;
    }

    public String getComposition() {
        return _composition;
    }

    public void setComposition(String _composition) {
        this._composition = _composition;
    }

    public int getDoorCount() {
        return _doorCount;
    }

    public void setDoorCount(int _doorCount) {
        this._doorCount = _doorCount;
    }

    public String getDoorStyle() {
        return _doorStyle;
    }

    public void setDoorStyle(String _doorStyle) {
        this._doorStyle = _doorStyle;
    }

    public String getFeature() {
        return _feature;
    }

    public void setFeature(String _feature) {
        this._feature = _feature;
    }

    public int getId() {
        return _id;
    }

    public void setId(int _id) {
        this._id = _id;
    }

    public String getManufacturor() {
        return _manufacturor;
    }

    public void setManufacturor(String _manufacturor) {
        this._manufacturor = _manufacturor;
    }

    public String getName() {
        return _name;
    }

    public void setName(String _name) {
        this._name = _name;
    }

    public String getPower() {
        return _power;
    }

    public void setPower(String _power) {
        this._power = _power;
    }

    public float getPrice() {
        return _price;
    }

    public void setPrice(float _price) {
        this._price = _price;
    }

    public int getQuantity() {
        return _quantity;
    }

    public void setQuantity(int _quantity) {
        this._quantity = _quantity;
    }

    public String getSize() {
        return _size;
    }

    public void setSize(String _size) {
        this._size = _size;
    }

    public boolean isStatus() {
        return _status;
    }

    public void setStatus(boolean _status) {
        this._status = _status;
    }

    public String getWarranty() {
        return _warranty;
    }

    public void setWarranty(String _warranty) {
        this._warranty = _warranty;
    }
            
}
