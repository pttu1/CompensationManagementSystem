using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace CompManagement
{
    public partial class Register : System.Web.UI.Page
    {
   
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Register.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string ins = "insert into [Table](First_Name, Last_Name, Email_Address, Password, Confirm_Password) " +
                         "values('" + fnametxt.Text + "', '" + lnametxt.Text + "', '" + emailtxt.Text + "', '" + passwordtxt.Text + "', '" + confpasswordtxt.Text + "')";
            SqlCommand com = new SqlCommand(ins, con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}