
namespace Trello
{
    partial class GorevYoneticisi
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
            this.lbl_taskname = new MetroFramework.Controls.MetroLabel();
            this.txt_taskname = new MetroFramework.Controls.MetroTextBox();
            this.lbl_taskdesc = new MetroFramework.Controls.MetroLabel();
            this.txt_taskdesc = new System.Windows.Forms.TextBox();
            this.grid_tasktablo = new System.Windows.Forms.DataGridView();
            this.cmb_taskstates = new MetroFramework.Controls.MetroComboBox();
            this.lbl_taskstate = new MetroFramework.Controls.MetroLabel();
            this.btn_taskadd = new MetroFramework.Controls.MetroButton();
            this.btn_taskupdate = new MetroFramework.Controls.MetroButton();
            this.btn_taskrefresh = new MetroFramework.Controls.MetroButton();
            this.btn_taskdelete = new MetroFramework.Controls.MetroButton();
            this.btn_todolist = new MetroFramework.Controls.MetroButton();
            this.lbl_kartnop = new MetroFramework.Controls.MetroLabel();
            this.txt_projectid = new MetroFramework.Controls.MetroTextBox();
            this.btn_close = new MetroFramework.Controls.MetroButton();
            this.btn_backtop = new MetroFramework.Controls.MetroButton();
            this.lbl_tasksid = new MetroFramework.Controls.MetroLabel();
            this.txt_taskid = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tasktablo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_taskname
            // 
            this.lbl_taskname.AutoSize = true;
            this.lbl_taskname.Location = new System.Drawing.Point(97, 97);
            this.lbl_taskname.Name = "lbl_taskname";
            this.lbl_taskname.Size = new System.Drawing.Size(73, 19);
            this.lbl_taskname.TabIndex = 0;
            this.lbl_taskname.Text = "Görev adı :";
            // 
            // txt_taskname
            // 
            this.txt_taskname.Location = new System.Drawing.Point(174, 97);
            this.txt_taskname.Name = "txt_taskname";
            this.txt_taskname.Size = new System.Drawing.Size(126, 23);
            this.txt_taskname.TabIndex = 1;
            // 
            // lbl_taskdesc
            // 
            this.lbl_taskdesc.AutoSize = true;
            this.lbl_taskdesc.Location = new System.Drawing.Point(54, 144);
            this.lbl_taskdesc.Name = "lbl_taskdesc";
            this.lbl_taskdesc.Size = new System.Drawing.Size(116, 19);
            this.lbl_taskdesc.TabIndex = 2;
            this.lbl_taskdesc.Text = "Görev Açıklaması :";
            // 
            // txt_taskdesc
            // 
            this.txt_taskdesc.Location = new System.Drawing.Point(177, 144);
            this.txt_taskdesc.Multiline = true;
            this.txt_taskdesc.Name = "txt_taskdesc";
            this.txt_taskdesc.Size = new System.Drawing.Size(539, 88);
            this.txt_taskdesc.TabIndex = 3;
            // 
            // grid_tasktablo
            // 
            this.grid_tasktablo.AllowUserToAddRows = false;
            this.grid_tasktablo.AllowUserToDeleteRows = false;
            this.grid_tasktablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tasktablo.Location = new System.Drawing.Point(174, 316);
            this.grid_tasktablo.Name = "grid_tasktablo";
            this.grid_tasktablo.ReadOnly = true;
            this.grid_tasktablo.Size = new System.Drawing.Size(648, 412);
            this.grid_tasktablo.TabIndex = 4;
            this.grid_tasktablo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tasktablo_CellDoubleClick);
            // 
            // cmb_taskstates
            // 
            this.cmb_taskstates.FormattingEnabled = true;
            this.cmb_taskstates.ItemHeight = 23;
            this.cmb_taskstates.Items.AddRange(new object[] {
            "Yapılacaklar",
            "Yapılıyor",
            "Tamamlandı"});
            this.cmb_taskstates.Location = new System.Drawing.Point(174, 245);
            this.cmb_taskstates.Name = "cmb_taskstates";
            this.cmb_taskstates.Size = new System.Drawing.Size(126, 29);
            this.cmb_taskstates.TabIndex = 5;
            // 
            // lbl_taskstate
            // 
            this.lbl_taskstate.AutoSize = true;
            this.lbl_taskstate.Location = new System.Drawing.Point(69, 245);
            this.lbl_taskstate.Name = "lbl_taskstate";
            this.lbl_taskstate.Size = new System.Drawing.Size(101, 19);
            this.lbl_taskstate.TabIndex = 6;
            this.lbl_taskstate.Text = "Görev durumu :";
            // 
            // btn_taskadd
            // 
            this.btn_taskadd.Location = new System.Drawing.Point(365, 245);
            this.btn_taskadd.Name = "btn_taskadd";
            this.btn_taskadd.Size = new System.Drawing.Size(112, 45);
            this.btn_taskadd.TabIndex = 7;
            this.btn_taskadd.Text = "Görev ekle";
            this.btn_taskadd.Click += new System.EventHandler(this.btn_taskadd_Click);
            // 
            // btn_taskupdate
            // 
            this.btn_taskupdate.Location = new System.Drawing.Point(71, 316);
            this.btn_taskupdate.Name = "btn_taskupdate";
            this.btn_taskupdate.Size = new System.Drawing.Size(99, 52);
            this.btn_taskupdate.TabIndex = 8;
            this.btn_taskupdate.Text = "Görev düzenle";
            this.btn_taskupdate.Click += new System.EventHandler(this.btn_taskupdate_Click);
            // 
            // btn_taskrefresh
            // 
            this.btn_taskrefresh.Location = new System.Drawing.Point(71, 374);
            this.btn_taskrefresh.Name = "btn_taskrefresh";
            this.btn_taskrefresh.Size = new System.Drawing.Size(101, 48);
            this.btn_taskrefresh.TabIndex = 9;
            this.btn_taskrefresh.Text = "Yenile";
            this.btn_taskrefresh.Click += new System.EventHandler(this.btn_taskrefresh_Click);
            // 
            // btn_taskdelete
            // 
            this.btn_taskdelete.Location = new System.Drawing.Point(71, 428);
            this.btn_taskdelete.Name = "btn_taskdelete";
            this.btn_taskdelete.Size = new System.Drawing.Size(101, 51);
            this.btn_taskdelete.TabIndex = 10;
            this.btn_taskdelete.Text = "Görev sil";
            this.btn_taskdelete.Click += new System.EventHandler(this.btn_taskdelete_Click);
            // 
            // btn_todolist
            // 
            this.btn_todolist.Location = new System.Drawing.Point(828, 677);
            this.btn_todolist.Name = "btn_todolist";
            this.btn_todolist.Size = new System.Drawing.Size(131, 51);
            this.btn_todolist.TabIndex = 11;
            this.btn_todolist.Text = "To Do listesine git";
            this.btn_todolist.Click += new System.EventHandler(this.btn_todolist_Click);
            // 
            // lbl_kartnop
            // 
            this.lbl_kartnop.AutoSize = true;
            this.lbl_kartnop.Location = new System.Drawing.Point(672, 40);
            this.lbl_kartnop.Name = "lbl_kartnop";
            this.lbl_kartnop.Size = new System.Drawing.Size(131, 19);
            this.lbl_kartnop.TabIndex = 12;
            this.lbl_kartnop.Text = "Proje kart numarası :";
            // 
            // txt_projectid
            // 
            this.txt_projectid.Enabled = false;
            this.txt_projectid.Location = new System.Drawing.Point(809, 40);
            this.txt_projectid.Name = "txt_projectid";
            this.txt_projectid.Size = new System.Drawing.Size(126, 23);
            this.txt_projectid.TabIndex = 13;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(23, 693);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(106, 35);
            this.btn_close.TabIndex = 14;
            this.btn_close.Text = "Uygulamayı Kapat";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_backtop
            // 
            this.btn_backtop.Location = new System.Drawing.Point(23, 653);
            this.btn_backtop.Name = "btn_backtop";
            this.btn_backtop.Size = new System.Drawing.Size(106, 34);
            this.btn_backtop.TabIndex = 15;
            this.btn_backtop.Text = "Projelere Dön";
            this.btn_backtop.Click += new System.EventHandler(this.btn_backtop_Click);
            // 
            // lbl_tasksid
            // 
            this.lbl_tasksid.AutoSize = true;
            this.lbl_tasksid.Location = new System.Drawing.Point(707, 93);
            this.lbl_tasksid.Name = "lbl_tasksid";
            this.lbl_tasksid.Size = new System.Drawing.Size(96, 19);
            this.lbl_tasksid.TabIndex = 16;
            this.lbl_tasksid.Text = "Task numarası :";
            // 
            // txt_taskid
            // 
            this.txt_taskid.Enabled = false;
            this.txt_taskid.Location = new System.Drawing.Point(809, 93);
            this.txt_taskid.Name = "txt_taskid";
            this.txt_taskid.Size = new System.Drawing.Size(126, 23);
            this.txt_taskid.TabIndex = 17;
            // 
            // GorevYoneticisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 751);
            this.Controls.Add(this.txt_taskid);
            this.Controls.Add(this.lbl_tasksid);
            this.Controls.Add(this.btn_backtop);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_projectid);
            this.Controls.Add(this.lbl_kartnop);
            this.Controls.Add(this.btn_todolist);
            this.Controls.Add(this.btn_taskdelete);
            this.Controls.Add(this.btn_taskrefresh);
            this.Controls.Add(this.btn_taskupdate);
            this.Controls.Add(this.btn_taskadd);
            this.Controls.Add(this.lbl_taskstate);
            this.Controls.Add(this.cmb_taskstates);
            this.Controls.Add(this.grid_tasktablo);
            this.Controls.Add(this.txt_taskdesc);
            this.Controls.Add(this.lbl_taskdesc);
            this.Controls.Add(this.txt_taskname);
            this.Controls.Add(this.lbl_taskname);
            this.Name = "GorevYoneticisi";
            this.Text = "GorevYoneticisi";
            this.Load += new System.EventHandler(this.GorevYoneticisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tasktablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbl_taskname;
        private MetroFramework.Controls.MetroTextBox txt_taskname;
        private MetroFramework.Controls.MetroLabel lbl_taskdesc;
        private System.Windows.Forms.TextBox txt_taskdesc;
        private System.Windows.Forms.DataGridView grid_tasktablo;
        private MetroFramework.Controls.MetroComboBox cmb_taskstates;
        private MetroFramework.Controls.MetroLabel lbl_taskstate;
        private MetroFramework.Controls.MetroButton btn_taskadd;
        private MetroFramework.Controls.MetroButton btn_taskupdate;
        private MetroFramework.Controls.MetroButton btn_taskrefresh;
        private MetroFramework.Controls.MetroButton btn_taskdelete;
        private MetroFramework.Controls.MetroButton btn_todolist;
        private MetroFramework.Controls.MetroLabel lbl_kartnop;
        private MetroFramework.Controls.MetroTextBox txt_projectid;
        private MetroFramework.Controls.MetroButton btn_close;
        private MetroFramework.Controls.MetroButton btn_backtop;
        private MetroFramework.Controls.MetroLabel lbl_tasksid;
        private MetroFramework.Controls.MetroTextBox txt_taskid;
    }
}