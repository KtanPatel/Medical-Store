using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Medical_Store.Shared
{
    class purchaseController
    {
        static connection cn = new connection();
        Response res = new Response();
        int steps = 0;
        public Response getMedicine()
        {
            return cn.getData("Product");
        }

        public Response addStock(Purchase stock)
        {
            try
            {
                //DateTime date = new DateTime();
                res = cn.setData("productID,qty,price,salesPrice,expiry,inDate",
                    stock.productID + "," + stock.qty + ",'" + stock.price + "','" + stock.salesPrice + "','" + stock.expiry + "','" + DateTime.Now + "'",
                    "StockIN");
                steps++;
                res = cn.isExistData("Stock", "productID=" + stock.productID + " and expiry = '" + stock.expiry + "'");
                steps++;
                if (res.success)
                {
                    if (res.data)
                    {
                        res = cn.updateData("qty+=" + stock.qty + ", price = '" + stock.price + "', salesPrice = '"+ stock.salesPrice +"',added+=" + stock.qty,
                            "Stock",
                            "productID = " + stock.productID + " and expiry ='" + stock.expiry + "'");
                    }
                    else
                    {
                        res = cn.setData("productID,qty,price,salesPrice,added,sold,return,expiry",
                    stock.productID + "," + stock.qty + ",'" + stock.price + "','" + stock.salesPrice + "'," + stock.qty + ",0,0,'" + stock.expiry + "'",
                    "Stock");
                    }
                }
                steps++;

                res.message = "Stock Added Successfully";
                res.success = true;
                res.data = steps;

            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = steps;
            }
            return res;
        }

        public Response getStock()
        {
            return cn.getData(
                "Product p,Stock s", "where p.ID = s.productID",
                "s.ID, p.productName as Medicine,s.qty as Quantity,s.price as Rate,s.added as Added, s.sold as Sold,s.return as Return, s.expiry as ExpiryDate"
                );
        }
    }
}
