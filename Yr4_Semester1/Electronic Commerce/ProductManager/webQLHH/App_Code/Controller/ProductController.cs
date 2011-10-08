using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace App_Code.Controller {
    /// <summary>
    /// Summary description for ProductController
    /// </summary>
    public class ProductController {
        const String ServiceURL = "http://thuongmaidientu2011.apphb.com/ProductService/";
        static readonly XNamespace Namespace = "http://schemas.datacontract.org/2004/07/WCF_Products.model";


        private static String GetXmlGetAll() {
            var webClient = new System.Net.WebClient();
            return webClient.DownloadString(ServiceURL + "GetAll");
        }

        private static String GetXmlGetByPrice(float from, float to) {
            var webClient = new System.Net.WebClient();
            return webClient.DownloadString(string.Format("{0}Product/Price/{1}/{2}", ServiceURL, from, to));
        }

        public static List<ProductModel> GetAll() {
            var xml = GetXmlGetAll();
            var xdoc = XDocument.Parse(xml);
            var products = from product in xdoc.Descendants(Namespace + "Product")
                           select new ProductModel() {
                                                         Id = Convert.ToInt32(product.Element(Namespace + "Id").Value),
                                                         ImageName = product.Element(Namespace + "ImageName").Value,
                                                         Name = product.Element(Namespace + "Name").Value,
                                                         Price = Convert.ToSingle(product.Element(Namespace + "Price").Value)
                                                     };
            return  new List<ProductModel>(products);
        }

        public static List<ProductModel> GetByPrice(float from, float to) {
            var xml = GetXmlGetByPrice(from, to);
            var xdoc = XDocument.Parse(xml);

            var products = from product in xdoc.Descendants(Namespace + "Product")
                           select new ProductModel() {
                                                         Id = Convert.ToInt32(product.Element(Namespace + "Id").Value),
                                                         ImageName = product.Element(Namespace + "ImageName").Value,
                                                         Name = product.Element(Namespace + "Name").Value,
                                                         Price = Convert.ToSingle(product.Element(Namespace + "Price").Value)
                                                     };
            return  new List<ProductModel>(products);
        }

    }
}