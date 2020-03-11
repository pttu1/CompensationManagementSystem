using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CompManagement
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uploadButton_Click(object sender, EventArgs e)
        {
            //Step 2: upload file control
            string filepath = Server.MapPath("~/Files/") + Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(filepath);

            //Step 3: Create a data table
            DataTable employeeInfo = new DataTable();
            employeeInfo.Columns.AddRange(new DataColumn[] {
                new DataColumn("stag"),
                new DataColumn("event"),
                new DataColumn("gender"),
                new DataColumn("age"),
                new DataColumn("industry"),
                new DataColumn("profession"), 
                new DataColumn("traffic"),
                new DataColumn("coach"),
                new DataColumn("head_gender"),
                new DataColumn("greywage"),
                new DataColumn("way"),
                new DataColumn("extraversion"),
                new DataColumn("independ"),
                new DataColumn("selfcontrol"),
                new DataColumn("anxiety"), 
                new DataColumn("novator"),});

         //step 4: read all text - filepath

            string data = File.ReadAllText(filepath);
            foreach (string row in data.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    employeeInfo.Rows.Add();
                    int i = 0;
                    foreach (string cell in row.Split(','))
                    {
                        employeeInfo.Rows[employeeInfo.Rows.Count - 1][i] = cell;
                        i++;
                    }
}
            }

            //step one: create connection and config manager
            //string mainconn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Register.mdf;Integrated Security=True")) 
            //using (SqlConnection sqlconn = new SqlConnection(mainconn))
            {
                using (SqlBulkCopy sqlbkcpy = new SqlBulkCopy(con))

                {
                    sqlbkcpy.DestinationTableName = "dbo.Emp";
                    con.Open();
                    sqlbkcpy.WriteToServer(employeeInfo); //step 5 = copy employeeInfo. by passing it as arugment (employeeInfo)
                    con.Close();
                }
            }
        }
    }
}



