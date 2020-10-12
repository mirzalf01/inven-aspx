using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace WebApplication3
{
    public partial class Registration : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=kuliah;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            {
                Response.Write("<script>alert('username harus diisi')</script>");
            }
            else if (TextBox2.Text == "")
            {
                Response.Write("<script>alert('password harus diisi')</script>");
            }
            else
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM login WHERE username='" + TextBox1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Response.Write("<script>alert('Username telah digunakan')</script>");
                }
                else
                {
                    cmd.CommandText = "INSERT INTO login VALUES('" + TextBox1.Text + "', '" + TextBox2.Text + "')";
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('Pendaftaran telah berhasil')</script>");
                    Response.Redirect("login.aspx");
                }
            }
        }
    }
}