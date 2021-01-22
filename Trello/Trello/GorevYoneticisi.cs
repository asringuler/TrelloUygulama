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
    public partial class GorevYoneticisi : MetroFramework.Forms.MetroForm
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Trello;Integrated Security=True");
        DataSet ds = new DataSet();
        public GorevYoneticisi()
        {
            InitializeComponent();
        }

        private void GorevYoneticisi_Load(object sender, EventArgs e)
        {
            txt_projectid.Text = Projeler.projectid;
            TablodaGoruntule();
        }
        private void TablodaGoruntule() //Tasklerimizi DataGridViewda göstermemizi sağlayan fonksiyon
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Tasks where tasks_projectid='"+Projeler.projectid+"'", baglanti);
            da.Fill(ds, "Tasks");
            grid_tasktablo.DataSource = ds.Tables["Tasks"];
            baglanti.Close();
        }

        private void btn_taskadd_Click(object sender, EventArgs e) //Task ekleme fonksiyonu
        {         
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tasks(tasks_name,tasks_description,tasks_state,tasks_projectid) values(@tasks_name,@tasks_description,@tasks_state,@tasks_projectid)", baglanti);
            komut.Parameters.AddWithValue("@tasks_name", txt_taskname.Text);
            komut.Parameters.AddWithValue("@tasks_description", txt_taskdesc.Text);
            komut.Parameters.AddWithValue("@tasks_state", cmb_taskstates.Text);
            komut.Parameters.AddWithValue("@tasks_projectid", Projeler.projectid);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Yenile();
        }

        private void btn_taskrefresh_Click(object sender, EventArgs e)
        {
            Yenile();
        }

        private void Yenile() //refresh
        {
            string yenile = "select *from Tasks where tasks_projectid='" + Projeler.projectid + "'";
            SqlDataAdapter sda = new SqlDataAdapter(yenile, baglanti);
            ds = new System.Data.DataSet();
            sda.Fill(ds, "Project");
            grid_tasktablo.DataSource = ds.Tables[0];
        }

        private void btn_taskupdate_Click(object sender, EventArgs e) //TextBoxlara girilen verilerle task'i databasede düzenleme fonksiyonu
        {        
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tasks set tasks_name=@tasks_name,tasks_description=@tasks_description,tasks_state=@tasks_state where tasks_id=@tasks_id", baglanti);
            komut.Parameters.AddWithValue("@tasks_name", txt_taskname.Text);
            komut.Parameters.AddWithValue("@tasks_description", txt_taskdesc.Text);
            komut.Parameters.AddWithValue("@tasks_state", cmb_taskstates.Text);           
            komut.Parameters.AddWithValue("@tasks_id", txt_taskid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Yenile();
            TablodaGoruntule();
        }

        private void btn_taskdelete_Click(object sender, EventArgs e) //Seçilen hücredeki verileri databaseden silmemize yarayan fonksiyon
        {
            Yenile();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tasks where tasks_id='" + grid_tasktablo.CurrentRow.Cells["tasks_id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi.");           
            TablodaGoruntule();
        }

        private void grid_tasktablo_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //DataGridView'ın çift tıklama eventi
        {
            txt_taskname.Text = grid_tasktablo.CurrentRow.Cells["tasks_name"].Value.ToString();
            txt_taskdesc.Text = grid_tasktablo.CurrentRow.Cells["tasks_description"].Value.ToString();
            cmb_taskstates.Text = grid_tasktablo.CurrentRow.Cells["tasks_state"].Value.ToString();
            txt_taskid.Text = grid_tasktablo.CurrentRow.Cells["tasks_id"].Value.ToString();
            txt_projectid.Text = Projeler.projectid;
        }

        private void btn_backtop_Click(object sender, EventArgs e)
        {
            Projeler gir = new Projeler();
            gir.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_todolist_Click(object sender, EventArgs e)
        {
            ToDo open = new ToDo();
            open.Show();
            this.Hide();
        }
    }
}
