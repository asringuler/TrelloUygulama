
namespace Trello
{
    partial class Projeler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_tablo = new System.Windows.Forms.DataGridView();
            this.btn_tasks = new MetroFramework.Controls.MetroButton();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.lbl_projectname = new MetroFramework.Controls.MetroLabel();
            this.txt_projectname = new MetroFramework.Controls.MetroTextBox();
            this.lbl_uzmankisi = new MetroFramework.Controls.MetroLabel();
            this.txt_user = new MetroFramework.Controls.MetroTextBox();
            this.lbl_tahmin = new MetroFramework.Controls.MetroLabel();
            this.lbl_date = new MetroFramework.Controls.MetroLabel();
            this.lbl_realdate = new MetroFramework.Controls.MetroLabel();
            this.txt_finishdate = new MetroFramework.Controls.MetroTextBox();
            this.lbl_desc = new MetroFramework.Controls.MetroLabel();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.lbl_note = new MetroFramework.Controls.MetroLabel();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.lbl_id = new MetroFramework.Controls.MetroLabel();
            this.txt_kartno = new MetroFramework.Controls.MetroTextBox();
            this.datetime_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_refresh = new MetroFramework.Controls.MetroButton();
            this.grp_dates = new System.Windows.Forms.GroupBox();
            this.grp_name_user = new System.Windows.Forms.GroupBox();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.picker_predate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tablo)).BeginInit();
            this.grp_dates.SuspendLayout();
            this.grp_name_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_tablo
            // 
            this.grid_tablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tablo.Location = new System.Drawing.Point(133, 309);
            this.grid_tablo.Name = "grid_tablo";
            this.grid_tablo.Size = new System.Drawing.Size(703, 412);
            this.grid_tablo.TabIndex = 0;
            this.grid_tablo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tablo_CellDoubleClick);
            // 
            // btn_tasks
            // 
            this.btn_tasks.Enabled = false;
            this.btn_tasks.Location = new System.Drawing.Point(842, 666);
            this.btn_tasks.Name = "btn_tasks";
            this.btn_tasks.Size = new System.Drawing.Size(106, 52);
            this.btn_tasks.TabIndex = 1;
            this.btn_tasks.Text = "Görevlere git";
            this.btn_tasks.Click += new System.EventHandler(this.btn_tasks_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(9, 424);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 51);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Projeyi sil";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(9, 309);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(118, 51);
            this.btn_update.TabIndex = 3;
            this.btn_update.Text = "Projeyi düzenle";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_projectname
            // 
            this.lbl_projectname.AutoSize = true;
            this.lbl_projectname.Location = new System.Drawing.Point(16, 16);
            this.lbl_projectname.Name = "lbl_projectname";
            this.lbl_projectname.Size = new System.Drawing.Size(65, 19);
            this.lbl_projectname.TabIndex = 4;
            this.lbl_projectname.Text = "Proje adı:";
            // 
            // txt_projectname
            // 
            this.txt_projectname.Location = new System.Drawing.Point(87, 16);
            this.txt_projectname.Name = "txt_projectname";
            this.txt_projectname.Size = new System.Drawing.Size(117, 23);
            this.txt_projectname.TabIndex = 5;
            // 
            // lbl_uzmankisi
            // 
            this.lbl_uzmankisi.AutoSize = true;
            this.lbl_uzmankisi.Location = new System.Drawing.Point(3, 45);
            this.lbl_uzmankisi.Name = "lbl_uzmankisi";
            this.lbl_uzmankisi.Size = new System.Drawing.Size(78, 19);
            this.lbl_uzmankisi.TabIndex = 6;
            this.lbl_uzmankisi.Text = "Uzman kişi :";
            // 
            // txt_user
            // 
            this.txt_user.Enabled = false;
            this.txt_user.Location = new System.Drawing.Point(87, 45);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(117, 23);
            this.txt_user.TabIndex = 7;
            // 
            // lbl_tahmin
            // 
            this.lbl_tahmin.AutoSize = true;
            this.lbl_tahmin.Location = new System.Drawing.Point(6, 16);
            this.lbl_tahmin.Name = "lbl_tahmin";
            this.lbl_tahmin.Size = new System.Drawing.Size(88, 19);
            this.lbl_tahmin.TabIndex = 8;
            this.lbl_tahmin.Text = "Tahmini süre :";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(744, 23);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(43, 19);
            this.lbl_date.TabIndex = 11;
            this.lbl_date.Text = "Tarih :";
            // 
            // lbl_realdate
            // 
            this.lbl_realdate.AutoSize = true;
            this.lbl_realdate.Location = new System.Drawing.Point(19, 45);
            this.lbl_realdate.Name = "lbl_realdate";
            this.lbl_realdate.Size = new System.Drawing.Size(75, 19);
            this.lbl_realdate.TabIndex = 12;
            this.lbl_realdate.Text = "Bitiş süresi :";
            // 
            // txt_finishdate
            // 
            this.txt_finishdate.Location = new System.Drawing.Point(111, 45);
            this.txt_finishdate.Name = "txt_finishdate";
            this.txt_finishdate.Size = new System.Drawing.Size(107, 23);
            this.txt_finishdate.TabIndex = 13;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(64, 154);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(112, 19);
            this.lbl_desc.TabIndex = 14;
            this.lbl_desc.Text = "Proje Açıklaması :";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(175, 154);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(633, 66);
            this.txt_desc.TabIndex = 15;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(175, 226);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(633, 49);
            this.txt_note.TabIndex = 16;
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(116, 226);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(53, 19);
            this.lbl_note.TabIndex = 17;
            this.lbl_note.Text = "Notlar :";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(822, 226);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 49);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Proje ekle";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(725, 51);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(62, 19);
            this.lbl_id.TabIndex = 19;
            this.lbl_id.Text = "Kart No :";
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(793, 51);
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(109, 23);
            this.txt_kartno.TabIndex = 20;
            // 
            // datetime_tarih
            // 
            this.datetime_tarih.CustomFormat = "dd-MM-yyyy";
            this.datetime_tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_tarih.Location = new System.Drawing.Point(793, 25);
            this.datetime_tarih.Name = "datetime_tarih";
            this.datetime_tarih.Size = new System.Drawing.Size(109, 20);
            this.datetime_tarih.TabIndex = 21;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(9, 366);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(118, 52);
            this.btn_refresh.TabIndex = 22;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // grp_dates
            // 
            this.grp_dates.Controls.Add(this.picker_predate);
            this.grp_dates.Controls.Add(this.lbl_tahmin);
            this.grp_dates.Controls.Add(this.lbl_realdate);
            this.grp_dates.Controls.Add(this.txt_finishdate);
            this.grp_dates.Location = new System.Drawing.Point(440, 51);
            this.grp_dates.Name = "grp_dates";
            this.grp_dates.Size = new System.Drawing.Size(229, 77);
            this.grp_dates.TabIndex = 23;
            this.grp_dates.TabStop = false;
            // 
            // grp_name_user
            // 
            this.grp_name_user.Controls.Add(this.txt_projectname);
            this.grp_name_user.Controls.Add(this.lbl_projectname);
            this.grp_name_user.Controls.Add(this.lbl_uzmankisi);
            this.grp_name_user.Controls.Add(this.txt_user);
            this.grp_name_user.Location = new System.Drawing.Point(150, 51);
            this.grp_name_user.Name = "grp_name_user";
            this.grp_name_user.Size = new System.Drawing.Size(212, 77);
            this.grp_name_user.TabIndex = 24;
            this.grp_name_user.TabStop = false;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(9, 666);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(118, 52);
            this.btn_exit.TabIndex = 25;
            this.btn_exit.Text = "Çıkış yap";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // picker_predate
            // 
            this.picker_predate.CustomFormat = "dd-MM-yyyy";
            this.picker_predate.Enabled = false;
            this.picker_predate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker_predate.Location = new System.Drawing.Point(111, 20);
            this.picker_predate.Name = "picker_predate";
            this.picker_predate.Size = new System.Drawing.Size(107, 20);
            this.picker_predate.TabIndex = 14;
            // 
            // Projeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 741);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.grp_name_user);
            this.Controls.Add(this.grp_dates);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.datetime_tarih);
            this.Controls.Add(this.txt_kartno);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_tasks);
            this.Controls.Add(this.grid_tablo);
            this.Name = "Projeler";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.Projeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tablo)).EndInit();
            this.grp_dates.ResumeLayout(false);
            this.grp_dates.PerformLayout();
            this.grp_name_user.ResumeLayout(false);
            this.grp_name_user.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_tablo;
        private MetroFramework.Controls.MetroButton btn_tasks;
        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroLabel lbl_projectname;
        private MetroFramework.Controls.MetroTextBox txt_projectname;
        private MetroFramework.Controls.MetroLabel lbl_uzmankisi;
        private MetroFramework.Controls.MetroTextBox txt_user;
        private MetroFramework.Controls.MetroLabel lbl_tahmin;
        private MetroFramework.Controls.MetroLabel lbl_date;
        private MetroFramework.Controls.MetroLabel lbl_realdate;
        private MetroFramework.Controls.MetroTextBox txt_finishdate;
        private MetroFramework.Controls.MetroLabel lbl_desc;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_note;
        private MetroFramework.Controls.MetroLabel lbl_note;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroLabel lbl_id;
        private MetroFramework.Controls.MetroTextBox txt_kartno;
        private System.Windows.Forms.DateTimePicker datetime_tarih;
        private MetroFramework.Controls.MetroButton btn_refresh;
        private System.Windows.Forms.GroupBox grp_dates;
        private System.Windows.Forms.GroupBox grp_name_user;
        private MetroFramework.Controls.MetroButton btn_exit;
        private System.Windows.Forms.DateTimePicker picker_predate;
    }
}