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
using System.Configuration;


namespace Trello
{
    public partial class ToDo : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Trello;Integrated Security=True");
        
        public ToDo()
        {
            InitializeComponent();
        }
        public static string state;
        public static string taskid;
        private void ToDo_Load(object sender, EventArgs e)
        {
            VerileriCek(); // verileri çekme fonksiyonumuzu çağırıyoruz
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            VerileriCek(); 
        }

        private void VerileriCek()
        {
            lst_yapilacak.Items.Clear();
            lst_yapiliyor.Items.Clear();
            lst_tamamlandi.Items.Clear();
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *from Tasks where tasks_projectid='" + Projeler.projectid + "'", connection);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read()) //SqlDataReader database'i okuduğu süre boyunca elde ettiği verilerin task durumunu kontrol edip uygun ListView tooluna aktardığı kısım
            {
                if (Convert.ToString(r["tasks_state"]) == "Yapılacaklar") //Eğer task durumu Yapılacaklar ise
                {
                    ListViewItem item = new ListViewItem(r["tasks_name"].ToString());
                    item.SubItems.Add(r["tasks_id"].ToString());
                    lst_yapilacak.Items.Add(item); //Taskin adını ve id numarasını ListView'a ekletiyoruz
                }
                else if (Convert.ToString(r["tasks_state"]) == "Yapılıyor")
                {
                    ListViewItem item = new ListViewItem(r["tasks_name"].ToString()); //Eğer task durumu Yapılıyor ise
                    item.SubItems.Add(r["tasks_id"].ToString());
                    lst_yapiliyor.Items.Add(item); //Taskin adını ve id numarasını ListView'a ekletiyoruz
                }
                else if (Convert.ToString(r["tasks_state"]) == "Tamamlandı")
                {
                    ListViewItem item = new ListViewItem(r["tasks_name"].ToString()); //Eğer task durumu Yapılıyor ise
                    item.SubItems.Add(r["tasks_id"].ToString());
                    lst_tamamlandi.Items.Add(item); //Taskin adını ve id numarasını ListView'a ekletiyoruz
                }
            }
            connection.Close();
        }

        private void btn_right_Click(object sender, EventArgs e) //Bu ve altındaki buton tıklama eventleri sayesinde seçilen ListView hücresindeki verinin durumunu değiştiriyoruz
        {
            string x = "Yapılıyor";
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *from Tasks", connection);
            SqlDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                taskid = r["tasks_id"].ToString(); //public static stringimizi okuduğu süre boyunca tasks_id'ye eşitleyip
                if (taskid == lst_yapilacak.SelectedItems[0].SubItems[1].Text) //Seçilen satırın id'sine eşit olduğu durumda task'in durumunu değiştiriyoruz
                {
                    r.Close();
                    SqlCommand kmt = new SqlCommand("update Tasks set tasks_state=@tasks_state where tasks_id='"+taskid+"'",connection);
                    kmt.Parameters.AddWithValue("@tasks_state", x);
                    kmt.ExecuteNonQuery();
                    
                    break;
                }                           
            }
            connection.Close();
            VerileriCek();
        }
       
        private void btn_right2_Click(object sender, EventArgs e)
        {
            string y = "Tamamlandı";
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *from Tasks", connection);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                taskid = r["tasks_id"].ToString();
                if (taskid == lst_yapiliyor.SelectedItems[0].SubItems[1].Text)
                {
                    r.Close();
                    SqlCommand kmt = new SqlCommand("update Tasks set tasks_state=@tasks_state where tasks_id='" + taskid + "'", connection);
                    kmt.Parameters.AddWithValue("@tasks_state", y);
                    kmt.ExecuteNonQuery();
                    
                    break;
                }
            }
            connection.Close();
            VerileriCek();
        }
        private void btn_left_Click(object sender, EventArgs e)
        {
            string z = "Yapılıyor";
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *from Tasks", connection);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                taskid = r["tasks_id"].ToString();
                if (taskid == lst_tamamlandi.SelectedItems[0].SubItems[1].Text)
                {
                    r.Close();
                    SqlCommand kmt = new SqlCommand("update Tasks set tasks_state=@tasks_state where tasks_id='" + taskid + "'", connection);
                    kmt.Parameters.AddWithValue("@tasks_state", z);
                    kmt.ExecuteNonQuery();
                    
                    break;
                }
            }
            connection.Close();
            VerileriCek();
        }
        private void btn_left2_Click(object sender, EventArgs e)
        {
            string c = "Yapılacaklar";
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select *from Tasks", connection);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                taskid = r["tasks_id"].ToString();
                if (taskid == lst_yapiliyor.SelectedItems[0].SubItems[1].Text)
                {
                    r.Close();
                    SqlCommand kmt = new SqlCommand("update Tasks set tasks_state=@tasks_state where tasks_id='" + taskid + "'", connection);
                    kmt.Parameters.AddWithValue("@tasks_state", c);
                    kmt.ExecuteNonQuery();
                    
                    break;
                }
            }
            connection.Close();
            VerileriCek();
        }

        private void btn_projeler_Click(object sender, EventArgs e)
        {
            GorevYoneticisi open = new GorevYoneticisi();
            open.Show();
            this.Hide();
        }


        private void lst_yapilacak_DoubleClick(object sender, EventArgs e)
        {
            btn_right2.Visible = false;
            btn_left.Visible = false;
            btn_left2.Visible = false;
            btn_right.Visible = true;            
        }

        private void lst_yapiliyor_DoubleClick(object sender, EventArgs e)
        {
            btn_right.Visible = false;
            btn_left.Visible = false;
            btn_left2.Visible = true;
            btn_right2.Visible = true;
        }

        private void lst_tamamlandi_DoubleClick(object sender, EventArgs e)
        {
            btn_right.Visible = false;
            btn_left2.Visible = false;
            btn_right2.Visible = false;
            btn_left.Visible = true;
        }
    }
}
