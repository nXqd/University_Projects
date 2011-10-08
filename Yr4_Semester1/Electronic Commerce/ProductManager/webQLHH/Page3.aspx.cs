using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using App_Code.Controller;

public partial class About : Page {
    private static List<ProductModel> _products;

    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void ProductDropdown_SelectedIndexChanged(object sender, EventArgs e) {
        if (_products.Count <= 0) return;
        var dropdown = (DropDownList) sender;

        if (dropdown.Items.Count <= 0) return;

        // set new variables
        var index = dropdown.SelectedIndex;
        image.ImageUrl = _products[index].ImageName;
        tbPrice.Text = _products[index].Price.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e) {
        var from = Convert.ToSingle(tbPriceFrom.Text);
        var to = Convert.ToSingle(tbPriceTo.Text);
        _products = ProductController.GetByPrice(from, to);
        
        var options = new ListItemCollection();
        foreach (var productModel in _products)
            options.Add(new ListItem {Text = productModel.Name, Value = productModel.Name});

        ProductDropdown.DataValueField = "Value";
        ProductDropdown.DataTextField = "Text";

        ProductDropdown.DataSource = options;
        ProductDropdown.DataBind();

        // set new variables
        if (_products.Count <= 0) {
            image.ImageUrl = tbPrice.Text = "";
        } else {
            image.ImageUrl = _products[0].ImageName;
            tbPrice.Text = _products[0].Price.ToString();
        }
    }
}