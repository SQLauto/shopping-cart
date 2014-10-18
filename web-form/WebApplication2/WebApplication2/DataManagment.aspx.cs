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

                //Display Gridview in the first time
                BindGridView();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(DropDownList1.SelectedValue);
            BindGridView();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Insert New Product
        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=0C6TRJSHJS7AV3Z; database=webform_s3301108;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("InsertProduct", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@CategoryID", TextBox2.Text);
            cmd.Parameters.AddWithValue("@Title", TextBox3.Text);
            cmd.Parameters.AddWithValue("@ShortDescription", TextBox4.Text);
            cmd.Parameters.AddWithValue("@LongDescription", TextBox5.Text);
            cmd.Parameters.AddWithValue("@ImageUrl", TextBox6.Text);
            cmd.Parameters.AddWithValue("@Price", TextBox7.Text);

            con.Open();
            int update = cmd.ExecuteNonQuery();
            con.Close();
            System.Diagnostics.Debug.WriteLine("Update results:{0}", update);
        }

        private void BindGridView()
        {
            SqlConnection con = new SqlConnection("data source=0C6TRJSHJS7AV3Z; database=webform_s3301108;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand("getSpProduct", con);
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
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridView();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGridView();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=0C6TRJSHJS7AV3Z; database=webform_s3301108;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand("spUpdateProduct", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            //int a = Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text);

            cmd2.Parameters.AddWithValue("@pID", Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text));
            cmd2.Parameters.AddWithValue("@cID", Convert.ToInt32(((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text));
            cmd2.Parameters.AddWithValue("@title", ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text);
            cmd2.Parameters.AddWithValue("@ShortDescription", ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text);
            cmd2.Parameters.AddWithValue("@LongDescription", ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text);
            cmd2.Parameters.AddWithValue("@ImageUrl", ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text);
            
            cmd2.Parameters.AddWithValue("@Price",string.Format("{0:#.00}",Convert.ToDecimal(((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text)));
            
            con.Open();
            int update = cmd2.ExecuteNonQuery();
            con.Close();
            System.Diagnostics.Debug.WriteLine("Update results for editing:{0}", update);
            GridView1.EditIndex = -1;
            BindGridView();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }







    }
}