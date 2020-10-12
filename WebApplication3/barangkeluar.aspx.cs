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
    public partial class barangkeluar : System.Web.UI.Page
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
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM stokbrg WHERE kode=" + kode_klr.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT nama, kategori, stok, harga FROM stokbrg WHERE kode=" + kode_klr.Text + "";
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) {
                    Label1.Visible = true;
                    Label2.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    jml_klr.Visible = true;
                    Button3.Visible = true;
                    jml_lbl.Visible = true;
                    nama_lbl.Text = (reader["nama"].ToString());
                    kategori_lbl.Text = (reader["kategori"].ToString());
                    stok_lbl.Text = (reader["stok"].ToString());
                    harga_lbl.Text = (reader["harga"].ToString());
                }
                
            }
            else
            {
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Button3.Visible = false;
                jml_klr.Visible = false;
                jml_lbl.Visible = false;
                nama_lbl.Text = "";
                kategori_lbl.Text = "";
                stok_lbl.Text = "";
                harga_lbl.Text = "";
                Response.Write("<script>alert('item tidak ditemukan')</script>");
                kode_klr.Text = "";
            }

            con.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(jml_klr.Text) <= int.Parse(stok_lbl.Text))
            {
                int a;
                a = int.Parse(stok_lbl.Text) - int.Parse(jml_klr.Text);
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE stokbrg SET stok="+a+" WHERE kode="+int.Parse(kode_klr.Text)+"";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO laporan VALUES(NOW(), 'Keluar', " + kode_klr.Text + ", '" + nama_lbl.Text + "','" + kategori_lbl.Text + "'," + jml_klr.Text + "," + harga_lbl.Text + "," + a + ")";
                cmd.ExecuteNonQuery();
                Label1.Visible = false;
                Label2.Visible = false;
                Label3.Visible = false;
                Label4.Visible = false;
                Button3.Visible = false;
                jml_klr.Visible = false;
                jml_lbl.Visible = false;
                nama_lbl.Text = "";
                kategori_lbl.Text = "";
                stok_lbl.Text = "";
                harga_lbl.Text = "";
                kode_klr.Text = "";
                Response.Write("<script>alert('Stok Telah Dikurangi')</script>");

                con.Close();
            }
            else
            {
                Response.Write("<script>alert('Stok Tidak Tersedia')</script>");
                jml_klr.Text = "";
            }
        }
    }
}