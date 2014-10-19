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
    public partial class UploadImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filename = FileUpload1.PostedFile.FileName;
            int fileLength = FileUpload1.PostedFile.ContentLength;
            byte[] imageBytes = new byte[fileLength];
            FileUpload1.PostedFile.InputStream.Read(imageBytes, 0, fileLength);

            using (SqlConnection con = new SqlConnection("data source=0C6TRJSHJS7AV3Z; database=webform_s3301108;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spUploadImage", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pID", int.Parse(TextBox1.Text));
                    cmd.Parameters.AddWithValue("@fileName", filename);
                    cmd.Parameters.AddWithValue("@fileContent", imageBytes);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            uploadLabel.Text = filename + " uploaded sucessfully!";
        }
    }
}