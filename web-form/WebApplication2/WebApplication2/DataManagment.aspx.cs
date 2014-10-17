using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class DataManagment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Connect to DB
                SqlConnection con = new SqlConnection("data source=0C6TRJSHJS7AV3Z; database=webform_s3301108;Integrated Security=True");

                //Display Category
                SqlCommand cmd = new SqlCommand("getCategory", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DropDownList1.DataSource = dr;
                DropDownList1.DataBind();

                con.Close();
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(DropDownList1.SelectedValue);
            //Connect to DB
            SqlConnection con = new SqlConnection("data source=0C6TRJSHJS7AV3Z; database=webform_s3301108;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand("getSpProduct",con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@cID", DropDownList1.SelectedValue);

            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                GridView1.DataSource = ds.Tables[0];
                GridView1.AllowPaging = true;
                GridView1.DataBind();
            }

            //con.Open();

            //SqlDataReader dr2 = cmd2.ExecuteReader();
            //GridView1.DataSource = dr2;
            //GridView1.DataBind();

            //con.Close();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }
}