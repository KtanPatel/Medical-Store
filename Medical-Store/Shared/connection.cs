using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography;
using System.IO;


namespace Medical_Store.Shared
{
    class connection
    {
        string con_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Medical-Store\db\db.mdb;Jet OLEDB:Database Password=*********;";
        OleDbConnection cnn;
        Response res = new Response();
        public void connectDB()
        {
            OleDbConnection con = new OleDbConnection(con_str);
            cnn = con;
            //return con;
        }

        public connection()
        {
            connectDB();
        }

        public int Login(Users user)
        {
            try
            {
                // connectDB();
                string qry = "select count(*) from Users where userName = '" + user.userName + "' and password = '" + user.password + "'";
                OleDbCommand cmd = new OleDbCommand(qry, cnn);
                cnn.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();
                return i;
            }
            catch (Exception ex)
            {
                return 2;
            }
        }

        public Response setData(string columns, string data, string table)
        {
            try
            {
                // connectDB();
                string qry = "insert into " + table + " (" + columns + ") values (" + data + ")";
                OleDbCommand cmd = new OleDbCommand(qry, cnn);
                cnn.Open();
                int i = cmd.ExecuteNonQuery();
                cnn.Close();
                res.success = true;
                res.data = i;
                res.message = "Added Successfully";
            }
            catch (Exception ex)
            {
                res.success = false;
                res.data = null;
                res.message = ex.Message;
            }
            return res;
        }

        public Response getData(string table, string additional, string columns)
        {
            DataSet ds = new DataSet();
            try
            {
                // connectDB();
                string qry = "select " + columns + " from " + table + " " + additional;
                OleDbDataAdapter da = new OleDbDataAdapter(qry, cnn);
                da.Fill(ds);
                res.success = true;
                res.message = "";
                res.data = ds;
            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = ds;
            }
            return res;
        }

        public Response getData(string table, string additional)
        {
            DataSet ds = new DataSet();
            try
            {
                // connectDB();
                string qry = "select * from " + table + " " + additional;
                OleDbDataAdapter da = new OleDbDataAdapter(qry, cnn);
                da.Fill(ds);
                res.success = true;
                res.message = "";
                res.data = ds;
            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = ds;
            }
            return res;
        }

        public Response getData(string table)
        {
            DataSet ds = new DataSet();
            try
            {
                // connectDB();
                string qry = "select * from " + table;
                OleDbDataAdapter da = new OleDbDataAdapter(qry, cnn);
                da.Fill(ds);
                res.success = true;
                res.message = "";
                res.data = ds;
            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = ds;
            }
            return res;
        }

        public Response getScalerValue(string table, string columns, string additional)
        {
            try
            {
                string qry = "select " + columns + " from " + table + " " + additional;
                OleDbCommand cmd = new OleDbCommand(qry, cnn);
                cnn.Open();
                object val = cmd.ExecuteScalar();
                cnn.Close();
                res.success = true;
                res.message = "";
                res.data = val;
            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = "";
            }
            return res;
        }

        public Response getScalerValue(string table, string columns)
        {
            try
            {
                string qry = "select " + columns + " from " + table;
                OleDbCommand cmd = new OleDbCommand(qry, cnn);
                cnn.Open();
                object val = cmd.ExecuteScalar();
                cnn.Close();
                res.success = true;
                res.message = "";
                res.data = val;
            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = "";
            }
            return res;
        }

        public Response deleteData(string table, string condition)
        {
            try
            {
                string qry = "delete from " + table + " where " + condition;
                OleDbCommand cmd = new OleDbCommand(qry, cnn);
                cnn.Open();
                int o = cmd.ExecuteNonQuery();
                cnn.Close();
                res.success = true;
                res.data = o;
                res.message = "Deleted Successfully";
            }
            catch (Exception ex)
            {
                res.success = false;
                res.data = 0;
                res.message = ex.Message;
            }

            return res;
        }

        public Response updateData(string data, string table, string condition)
        {
            try
            {
                string qry = "update " + table + " set " + data + " where " + condition;
                OleDbCommand cmd = new OleDbCommand(qry, cnn);
                cnn.Open();
                int i = cmd.ExecuteNonQuery();
                cnn.Close();
                res.success = true;
                res.data = i;
                res.message = "Updated Successfully";
            }
            catch (Exception ex)
            {
                res.success = false;
                res.data = 0;
                res.message = ex.Message;
            }

            return res;
        }

        public Response isExistData(string table, string condition)
        {
            try
            {
                string qry = "select count(*) from " + table + " where " + condition;
                OleDbCommand cmd = new OleDbCommand(qry, cnn);
                cnn.Open();
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                cnn.Close();

                if (i == 1)
                {
                    res.success = true;
                    res.message = "Already Exist";
                    res.data = true;
                }
                else
                {
                    res.success = true;
                    res.message = "No Match Found";
                    res.data = false;
                }
            }
            catch (Exception ex)
            {
                res.message = ex.Message;
                res.success = false;
                res.data = false;
            }
            return res;
        }


        public string Encrypt(string clearText)
        {
            string EncryptionKey = "KetanPateloo7";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "KetanPateloo7";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
    }
}
