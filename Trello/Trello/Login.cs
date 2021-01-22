using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Trello
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Trello;Integrated Security=True"); //Sql bağlantısı
        static public string id;
        static public string username;
        string user_name;
        public Login()
        {
            InitializeComponent();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            user_name = txt_uname.Text;
            Giris(user_name);
        }

        public int Giris(string kullaniciadi)
        {
            sqlcon.Open();
            string giris = "SELECT * from Users where users_name=@users_name"; 
            SqlCommand komut = new SqlCommand(giris, sqlcon);
            komut.Parameters.AddWithValue("@users_name", kullaniciadi); 
            SqlDataAdapter d = new SqlDataAdapter(komut);
            SqlDataReader r = komut.ExecuteReader();

            if (r.Read()) //Database'deki Users table'ını okutup kullanıcı adını kontrol ediyoruz.
            {

                kullaniciadi = r["users_name"].ToString();
                username = r["users_name"].ToString();
                id = r["users_id"].ToString();
                sqlcon.Close();
                Projeler x = new Projeler();
                x.Show();
                this.Hide();
                return 1; //Unit Test için 1 veya 0 sonucu döndürüyoruz.
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
                return 0;
            }
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Uygulamayı kapatan buton
        }
    }
}

