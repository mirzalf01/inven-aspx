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
    public partial class stokbarang : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=kuliah;User Id=root;password=''");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String x = "";
            if (DropDownList1.SelectedIndex == 0)
            {
                x = "nama ASC";
            }
            else if (DropDownList1.SelectedIndex == 1)
            {
                x = "nama DESC";
            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                x = "stok ASC";
            }
            else if (DropDownList1.SelectedIndex == 3)
            {
                x = "stok DESC";
            }
            else if (DropDownList1.SelectedIndex == 4)
            {
                x = "harga ASC";
            }
            else if (DropDownList1.SelectedIndex == 5)
            {
                x = "harga DESC";
            }
            else if (DropDownList1.SelectedIndex == 6)
            {
                x = "kode ASC";
            }
            else if (DropDownList1.SelectedIndex == 7)
            {
                x = "kode DESC";
            }

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT kode, nama, kategori, stok, harga FROM stokbrg ORDER BY "+x;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();



            con.Close();
        }

        
    }
}