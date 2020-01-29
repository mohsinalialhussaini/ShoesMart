using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace JOOTASHOP.Manager
{
    public class loginManager
    {

        public SqlConnection con = new SqlConnection(@"Server=sql.freeasphost.net\MSSQL2016;Database=huxe_ShoeShop;uid=huxe;pwd=huxe 2486;");

        public int CheckLogin(Models.loginModel _loginModel)
        {
            string query = "Select * from loginTable where(userName='" + _loginModel.UserName + "' And password='" + _loginModel.password + "')";
            
           
            con.Open();
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                
                int  a= Convert.ToInt32(reader[0]);
                con.Close();
                return a;
            }

            con.Close();

            return 0;



        }

        public void getUserData(int ID)
        {
            
            string query = "Select * from AdminData where(ID='"+ID+"')";


            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Models.AdminData.ID = Convert.ToInt32(reader[0]);
                Models.AdminData.name = reader[1].ToString();
                Models.AdminData.contact = reader[2].ToString();
                Models.AdminData.cnic = reader[3].ToString();
                
                
            }

            con.Close();

            return;


        }
    }
}