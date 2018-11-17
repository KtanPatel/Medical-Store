using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace Medical_Store.Shared
{
    class controller
    {
        static connection cn = new connection();
        Response res = new Response();
        public int Login(Users user)
        {
            return cn.Login(user);
        }

        public Response AddCategory(Category category)
        {
            string data = "'" + category.catName + "','" + category.catDesc + "'";
            return cn.setData("catName,catDesc", data, "Category");
        }

        public Response GetCategory()
        {
            return cn.getData("Category");
        }

        public Response DeleteCategory(string ID)
        {
            return cn.deleteData("Category", "ID = " + ID);
        }

        public Response UpdateCategory(Category category)
        {
            return cn.updateData("catName='" + category.catName + "',catDesc='" + category.catDesc + "'", "Category", "ID=" + category.ID);
        }

        public Response AddCompany(Company company)
        {
            string data = "'" + company.companyName + "','" + company.address + "','" + company.contact + "'";
            return cn.setData("companyName,address,contact", data, "Company");
        }

        public Response GetCompany()
        {
            return cn.getData("Company");
        }

        public Response DeleteCompany(string ID)
        {
            return cn.deleteData("Company", "ID = " + ID);
        }

        public Response UpdateCompany(Company company)
        {
            return cn.updateData("companyName='" + company.companyName + "',address='" + company.address + "',contact='" + company.contact + "'", "Company", "ID=" + company.ID);
        }

        public Response AddProduct(Product product)
        {
            string data = "'" + product.productName + "','" + product.productDescription + "'," + product.catID + "," + product.companyID + ",'" + product.unit + "'";
            return cn.setData("productName,productDescription,catID,companyID,unit", data, "Product");
        }

        public Response GetProduct()
        {
            // return cn.getData("Product", "");
            return cn.getData("product p, company c, category cc",
                "where p.companyID =c.ID and p.catID = cc.ID",
                "p.ID, p.productName as Medicine, p.productDescription as Description,p.unit as Unit, c.companyName as Company, cc.catName as Category"
                );
        }

        public Response DeleteProduct(string ID)
        {
            return cn.deleteData("Product", "ID = " + ID);
        }

        public Response UpdateProduct(Product product)
        {
            return cn.updateData("productName='" + product.productName + "',productDescription='" + product.productDescription + "',unit='" + product.unit + "'", "Product", "ID=" + product.ID);
        }

    }


}
