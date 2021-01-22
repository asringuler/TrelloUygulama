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
    public partial class Projeler : MetroFramework.Forms.MetroForm
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Trello;Integrated Security=True");
        DataSet daset = new DataSet();
        static public string projectid;
        public Projeler()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Random rand = new Random();
            int sure = rand.Next(180);
            DateTime tahmin = myDateTime.AddDays(sure);
            picker_predate.Value = tahmin;
            con.Open();
            SqlCommand komut = new SqlCommand("insert into Project(project_name,project_desc,project_note,project_realdate,project_predate,project_finishdate,project_userid) values(@project_name,@project_desc,@project_note,@project_realdate,@project_predate,@project_finishdate,@project_userid)", con);
            komut.Parameters.Add("@project_realdate", SqlDbType.Date).Value = datetime_tarih.Value.Date;
            komut.Parameters.AddWithValue("@project_name", txt_projectname.Text);
            komut.Parameters.AddWithValue("@project_desc", txt_desc.Text);
            komut.Parameters.AddWithValue("@project_note", txt_note.Text);
            komut.Parameters.AddWithValue("@project_predate", picker_predate.Text);
            komut.Parameters.AddWithValue("@project_finishdate", txt_finishdate.Text);
            komut.Parameters.AddWithValue("@project_userid", Login.id);
            komut.ExecuteNonQuery(); //TextBoxlara girilen bilgileri algılayıp database'e aktarıyoruz
            con.Close();
        }

        private void grid_tablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //DataGridView hücresine çift tıkladığımızda TextBoxları otomatik dolduran fonksiyon
        {
            txt_kartno.Text = grid_tablo.CurrentRow.Cells["project_id"].Value.ToString();
            txt_projectname.Text = grid_tablo.CurrentRow.Cells["project_name"].Value.ToString();
            txt_desc.Text = grid_tablo.CurrentRow.Cells["project_desc"].Value.ToString();
            txt_note.Text = grid_tablo.CurrentRow.Cells["project_note"].Value.ToString();
            datetime_tarih.Text = grid_tablo.CurrentRow.Cells["project_realdate"].Value.ToString();
            picker_predate.Text = grid_tablo.CurrentRow.Cells["project_predate"].Value.ToString();
            txt_finishdate.Text = grid_tablo.CurrentRow.Cells["project_finishdate"].Value.ToString();
            txt_user.Text = Login.username;
            projectid = grid_tablo.CurrentRow.Cells["project_id"].Value.ToString();
            btn_tasks.Enabled = true;
        }

        private void ProjeleriGoruntule() //DataGridViewda projelerimizi görüntüleyen fonksiyon
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Project where project_userid='"+Login.id+"'", con);
            da.Fill(daset, "Project");
            grid_tablo.DataSource = daset.Tables["Project"];
            con.Close();
        }


        private void Projeler_Load(object sender, EventArgs e)
        {
            ProjeleriGoruntule();          
            txt_user.Text = Login.username;
        }


        private void btn_update_Click(object sender, EventArgs e) //Seçilen gridview hücresinin databaseini güncelleyen fonksiyon
        {
            con.Open();
            SqlCommand komut = new SqlCommand("update Project set project_name=@project_name,project_desc=@project_desc,project_note=@project_note,project_predate=@project_predate,project_finishdate=@project_finishdate,project_userid=@project_userid where project_id=@project_id", con);
            komut.Parameters.AddWithValue("@project_id", txt_kartno.Text);
            komut.Parameters.AddWithValue("@project_name", txt_projectname.Text);
            komut.Parameters.AddWithValue("@project_desc", txt_desc.Text);
            komut.Parameters.AddWithValue("@project_note", txt_note.Text);
            komut.Parameters.AddWithValue("@project_predate", picker_predate.Text);
            komut.Parameters.AddWithValue("@project_finishdate", txt_finishdate.Text);
            komut.Parameters.AddWithValue("@project_userid", Login.id);
            komut.ExecuteNonQuery();
            con.Close();
            daset.Tables["Project"].Clear();
            ProjeleriGoruntule();
            
        }

        private void btn_delete_Click(object sender, EventArgs e) //Databaseden veri silen fonksiyon
        {
            con.Open();
            SqlCommand komut = new SqlCommand("delete from Project where project_id='" + grid_tablo.CurrentRow.Cells["project_id"].Value.ToString() + "'", con);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt silindi.");
            daset.Tables["Project"].Clear();
            ProjeleriGoruntule();           
        }

        private void btn_refresh_Click(object sender, EventArgs e) //DataGridView'ı yenileyen fonksiyon
        {
            string refresh = "select *from Project where project_userid='" + Login.id + "'";
            SqlDataAdapter rf = new SqlDataAdapter(refresh,con);
            daset = new System.Data.DataSet();
            rf.Fill(daset, "Project");
            grid_tablo.DataSource = daset.Tables[0];
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login giris = new Login();
            giris.Show();
            this.Hide();
        }

        private void btn_tasks_Click(object sender, EventArgs e) //Seçtiğimiz projenin tasklerine bizi yönlendiren fonksiyon
        {
            GorevYoneticisi giris = new GorevYoneticisi();
            giris.Show();
            this.Hide();
        }
    }
}

