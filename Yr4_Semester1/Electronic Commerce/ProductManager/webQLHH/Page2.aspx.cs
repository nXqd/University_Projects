using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using App_Code.Controller;

public partial class About : System.Web.UI.Page {
    List<ProductModel> _products;
    
    protected void Page_Load(object sender, EventArgs e) {
        _products = ProductController.GetAll();
        var options = new ListItemCollection();

        foreach (var productModel in _products) {
            options.Add(new ListItem { Text = productModel.Name, Value = productModel.Name });
        }

        // Bind to Dropdown box
        ProductDropdown.DataValueField = "Value";
        ProductDropdown.DataTextField = "Text";
        if (!IsPostBack) {
            ProductDropdown.DataSource = options;
            ProductDropdown.DataBind();
        }

        // Set init image url and Price
        image.ImageUrl = _products[0].ImageName;
        tbPrice.Text = _products[0].Price.ToString();

    }
/*    protected void ProductDropdownSelectedIndexChanged(object sender, EventArgs e) {
    }*/
    protected void ProductDropdown_SelectedIndexChanged(object sender, EventArgs e)
    {
        var dropdown = (DropDownList) sender;

        // set new variables
        var index = dropdown.SelectedIndex;
        image.ImageUrl = _products[index].ImageName;
        tbPrice.Text = _products[index].Price.ToString();
    }
}
