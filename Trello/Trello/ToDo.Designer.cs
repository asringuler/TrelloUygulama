
namespace Trello
{
    partial class ToDo
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
            this.lst_yapilacak = new System.Windows.Forms.ListView();
            this.tasks_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.task_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_yapiliyor = new System.Windows.Forms.ListView();
            this.tasks_namec2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tasks_idc2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lst_tamamlandi = new System.Windows.Forms.ListView();
            this.tasks_namec3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tasks_idc3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_yenile = new MetroFramework.Controls.MetroButton();
            this.btn_right = new MetroFramework.Controls.MetroTile();
            this.btn_left2 = new MetroFramework.Controls.MetroTile();
            this.btn_left = new MetroFramework.Controls.MetroTile();
            this.btn_right2 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btn_projeler = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lst_yapilacak
            // 
            this.lst_yapilacak.AllowDrop = true;
            this.lst_yapilacak.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tasks_name,
            this.task_id});
            this.lst_yapilacak.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lst_yapilacak.HideSelection = false;
            this.lst_yapilacak.Location = new System.Drawing.Point(117, 134);
            this.lst_yapilacak.Name = "lst_yapilacak";
            this.lst_yapilacak.Size = new System.Drawing.Size(187, 512);
            this.lst_yapilacak.TabIndex = 0;
            this.lst_yapilacak.UseCompatibleStateImageBehavior = false;
            this.lst_yapilacak.View = System.Windows.Forms.View.Details;
            this.lst_yapilacak.DoubleClick += new System.EventHandler(this.lst_yapilacak_DoubleClick);
            // 
            // tasks_name
            // 
            this.tasks_name.Text = "Görev Adı";
            this.tasks_name.Width = 123;
            // 
            // task_id
            // 
            this.task_id.Text = "Görev No";
            // 
            // lst_yapiliyor
            // 
            this.lst_yapiliyor.AllowDrop = true;
            this.lst_yapiliyor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tasks_namec2,
            this.tasks_idc2});
            this.lst_yapiliyor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lst_yapiliyor.HideSelection = false;
            this.lst_yapiliyor.Location = new System.Drawing.Point(372, 134);
            this.lst_yapiliyor.Name = "lst_yapiliyor";
            this.lst_yapiliyor.Size = new System.Drawing.Size(187, 512);
            this.lst_yapiliyor.TabIndex = 1;
            this.lst_yapiliyor.UseCompatibleStateImageBehavior = false;
            this.lst_yapiliyor.View = System.Windows.Forms.View.Details;
            this.lst_yapiliyor.DoubleClick += new System.EventHandler(this.lst_yapiliyor_DoubleClick);
            // 
            // tasks_namec2
            // 
            this.tasks_namec2.Text = "Görev Adı";
            this.tasks_namec2.Width = 123;
            // 
            // tasks_idc2
            // 
            this.tasks_idc2.Text = "Görev No";
            // 
            // lst_tamamlandi
            // 
            this.lst_tamamlandi.AllowDrop = true;
            this.lst_tamamlandi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tasks_namec3,
            this.tasks_idc3});
            this.lst_tamamlandi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lst_tamamlandi.HideSelection = false;
            this.lst_tamamlandi.Location = new System.Drawing.Point(620, 134);
            this.lst_tamamlandi.Name = "lst_tamamlandi";
            this.lst_tamamlandi.Size = new System.Drawing.Size(187, 512);
            this.lst_tamamlandi.TabIndex = 2;
            this.lst_tamamlandi.UseCompatibleStateImageBehavior = false;
            this.lst_tamamlandi.View = System.Windows.Forms.View.Details;
            this.lst_tamamlandi.DoubleClick += new System.EventHandler(this.lst_tamamlandi_DoubleClick);
            // 
            // tasks_namec3
            // 
            this.tasks_namec3.Text = "Görev Adı";
            this.tasks_namec3.Width = 123;
            // 
            // tasks_idc3
            // 
            this.tasks_idc3.Text = "Görev No";
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(801, 678);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(66, 41);
            this.btn_yenile.TabIndex = 3;
            this.btn_yenile.Text = "Yenile";
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_right.CustomBackground = true;
            this.btn_right.Location = new System.Drawing.Point(291, 652);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(74, 67);
            this.btn_right.TabIndex = 6;
            this.btn_right.TileImage = global::Trello.Properties.Resources.fast_forward_double_right_arrows_symbol;
            this.btn_right.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_right.UseTileImage = true;
            this.btn_right.Visible = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left2
            // 
            this.btn_left2.BackColor = System.Drawing.Color.Lime;
            this.btn_left2.CustomBackground = true;
            this.btn_left2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_left2.Location = new System.Drawing.Point(310, 63);
            this.btn_left2.Name = "btn_left2";
            this.btn_left2.Size = new System.Drawing.Size(74, 67);
            this.btn_left2.TabIndex = 5;
            this.btn_left2.TileImage = global::Trello.Properties.Resources.double_left_arrows_symbol;
            this.btn_left2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_left2.UseTileImage = true;
            this.btn_left2.Visible = false;
            this.btn_left2.Click += new System.EventHandler(this.btn_left2_Click);
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.Yellow;
            this.btn_left.CustomBackground = true;
            this.btn_left.Location = new System.Drawing.Point(551, 61);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(74, 67);
            this.btn_left.TabIndex = 4;
            this.btn_left.TileImage = global::Trello.Properties.Resources.double_left_arrows_symbol;
            this.btn_left.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_left.UseTileImage = true;
            this.btn_left.Visible = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_right2
            // 
            this.btn_right2.BackColor = System.Drawing.Color.Red;
            this.btn_right2.CustomBackground = true;
            this.btn_right2.CustomForeColor = true;
            this.btn_right2.Location = new System.Drawing.Point(531, 652);
            this.btn_right2.Name = "btn_right2";
            this.btn_right2.Size = new System.Drawing.Size(74, 67);
            this.btn_right2.TabIndex = 7;
            this.btn_right2.TileImage = global::Trello.Properties.Resources.fast_forward_double_right_arrows_symbol;
            this.btn_right2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_right2.UseTileImage = true;
            this.btn_right2.Visible = false;
            this.btn_right2.Click += new System.EventHandler(this.btn_right2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(154, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Yapılacak İşler";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(390, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Yapılmakta Olan İşler";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(648, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Tamamlanan İşler";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_projeler
            // 
            this.btn_projeler.Location = new System.Drawing.Point(22, 589);
            this.btn_projeler.Name = "btn_projeler";
            this.btn_projeler.Size = new System.Drawing.Size(89, 57);
            this.btn_projeler.TabIndex = 11;
            this.btn_projeler.Text = "Geri Dön";
            this.btn_projeler.Click += new System.EventHandler(this.btn_projeler_Click);
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 742);
            this.Controls.Add(this.btn_projeler);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_right2);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left2);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.lst_tamamlandi);
            this.Controls.Add(this.lst_yapiliyor);
            this.Controls.Add(this.lst_yapilacak);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_yapilacak;
        private System.Windows.Forms.ListView lst_yapiliyor;
        private System.Windows.Forms.ListView lst_tamamlandi;
        private System.Windows.Forms.ColumnHeader task_id;
        private System.Windows.Forms.ColumnHeader tasks_idc2;
        private System.Windows.Forms.ColumnHeader tasks_idc3;
        private MetroFramework.Controls.MetroButton btn_yenile;
        private MetroFramework.Controls.MetroTile btn_left;
        private MetroFramework.Controls.MetroTile btn_left2;
        private MetroFramework.Controls.MetroTile btn_right;
        private MetroFramework.Controls.MetroTile btn_right2;
        private System.Windows.Forms.ColumnHeader tasks_name;
        private System.Windows.Forms.ColumnHeader tasks_namec2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.ColumnHeader tasks_namec3;
        private MetroFramework.Controls.MetroButton btn_projeler;
    }
}