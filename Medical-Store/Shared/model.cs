using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store.Shared
{
    class model
    {
    }

    class Response
    {
        public dynamic data { get; set; }
        public bool success { get; set; }
        public string message { get; set; }
    }

    class Users
    {
        public string userName { get; set; }
        public string password { get; set; }
    }

    class Category
    {
        public int ID { get; set; }
        public string catName { get; set; }
        public string catDesc { get; set; }
    }

    class Company
    {
        public int ID { get; set; }
        public string companyName { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
    }

    class Product
    {
        public int ID { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public int catID { get; set; }
        public int companyID { get; set; }
        public string unit { get; set; }
    }

    class Purchase
    {
        public int ID { get; set; }
        //  public DateTime inDate { get; set; }
        public int productID { get; set; }
        public int qty { get; set; }
        public decimal price { get; set; }
        public decimal salesPrice { get; set; }
        public DateTime expiry { get; set; }
    }

    class Invoice {
        // public int? ID { get; set; }
        public int customerID { get; set; }
        public string customerName { get; set; }
        // public DateTime? outDate { get; set; }
        public int qtyCount { get; set; }
        public decimal amount { get; set; }
        public List<InvoiceItems> items { get; set; }
    }

    class InvoiceItems {
        // public int? ID { get; set; }
        // public int? invoiceID { get; set; }
        public int productID { get; set; }
        public int qty { get; set; }
        public decimal price { get; set; }
        public DateTime expiry { get; set; }
    }
}
