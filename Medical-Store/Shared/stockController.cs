using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Store.Shared
{

    class stockController
    {
        static connection cn = new connection();
        Response res = new Response();

        public Response getExpireStock(int days)
        {
            return cn.getData(
                "Product p,Stock s",
                "where p.ID = s.productID and s.qty > 0 and s.expiry < now() +" + days,
                "s.ID, p.productName as Medicine,s.qty as Quantity,s.price as Rate,s.added as Added, s.sold as Sold,s.return as Return, s.expiry as ExpiryDate"
                );
        }

        public Response getShortageStock(int count)
        {
            return cn.getData(
                "Product p,Stock s",
                "where p.ID = s.productID and s.qty > 0 and s.qty <" + count,
                "s.ID, p.productName as Medicine,s.qty as Quantity,s.price as Rate,s.added as Added, s.sold as Sold,s.return as Return, s.expiry as ExpiryDate"
                );
        }

        public Response returnStock(string ID)
        {
            return cn.updateData("return = qty, qty = 0",
                "Stock",
                "ID ="+ID);
        }
    }
}
