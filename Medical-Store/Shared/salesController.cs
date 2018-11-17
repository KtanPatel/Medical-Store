using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store.Shared
{
    class salesController
    {
        static connection cn = new connection();
        Response res = new Response();
        int steps = 0;
        public Response getMedicine()
        {
            return cn.getData("Stock s, Product p", "where s.qty > 0 and p.ID = s.productID",
                "s.productID as productID,p.productName as productName, s.qty as qty, s.price as price, s.salesPrice as salesPrice, s.expiry as expiry");
        }

        public Response addInvoice(Invoice invoice)
        {
            try
            {
                res = cn.setData("customerID,customerName,outDate,qtyCount,amount",
                    "" + invoice.customerID + ",'" + invoice.customerName + "',#" + DateTime.Now + "#," + invoice.qtyCount + ",'" + invoice.amount + "'",
                    "Invoice");
                steps++;
                res = cn.getScalerValue("Invoice", "max(ID) as ID");
                int invoiceID = 0;
                if (res.success)
                {
                    invoiceID = Convert.ToInt32(res.data);
                }
                steps++;
                for(int i=0; i < invoice.items.Count; i++)
                {
                    res = cn.setData("invoiceID,productID,qty,price",
                   "" + invoiceID + "," + invoice.items[i].productID + "," + invoice.items[i].qty + ",'" + invoice.items[i].price + "'",
                   "InvoiceItems");

                    res = cn.updateData("qty= qty - " + invoice.items[i].qty + ",sold = sold + " + invoice.items[i].qty,
                            "Stock",
                            "productID = " + invoice.items[i].productID + " and expiry =#" + invoice.items[i].expiry + "#");

                }
                
                steps++;
                if (res.success)
                {
                    res.message = "Invoice Added Successfully";
                    res.success = true;
                    res.data = steps;
                }
            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = steps;
            }
            return res;
        }
    }
}
