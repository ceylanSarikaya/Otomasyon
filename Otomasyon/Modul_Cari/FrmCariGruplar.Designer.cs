
namespace Otomasyon.Modul_Cari
{
    partial class FrmCariGruplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariGruplar));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrupKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblGrupAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblGrupKodu = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.btnKapat);
            this.groupControl3.Controls.Add(this.btnSil);
            this.groupControl3.Controls.Add(this.btnKaydet);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 477);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(587, 80);
            this.groupControl3.TabIndex = 5;
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(446, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 49);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(353, 26);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 49);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(260, 26);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(87, 49);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 94);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(587, 463);
            this.groupControl2.TabIndex = 4;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 23);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(583, 438);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.GrupKodu,
            this.GrupAdi});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            // 
            // GrupKodu
            // 
            this.GrupKodu.Caption = "Grup Kodu";
            this.GrupKodu.FieldName = "GrupKodu";
            this.GrupKodu.Name = "GrupKodu";
            this.GrupKodu.OptionsColumn.AllowEdit = false;
            this.GrupKodu.OptionsColumn.AllowFocus = false;
            this.GrupKodu.OptionsColumn.FixedWidth = true;
            this.GrupKodu.Visible = true;
            this.GrupKodu.VisibleIndex = 0;
            // 
            // GrupAdi
            // 
            this.GrupAdi.Caption = "Grup Adi";
            this.GrupAdi.FieldName = "GrupAdi";
            this.GrupAdi.Name = "GrupAdi";
            this.GrupAdi.OptionsColumn.AllowEdit = false;
            this.GrupAdi.OptionsColumn.AllowFocus = false;
            this.GrupAdi.OptionsColumn.FixedWidth = true;
            this.GrupAdi.Visible = true;
            this.GrupAdi.VisibleIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblGrupAdi);
            this.groupControl1.Controls.Add(this.txtGrupAdi);
            this.groupControl1.Controls.Add(this.lblGrupKodu);
            this.groupControl1.Controls.Add(this.txtGrupKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(587, 94);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Grup Bilgisi";
            // 
            // lblGrupAdi
            // 
            this.lblGrupAdi.Location = new System.Drawing.Point(32, 63);
            this.lblGrupAdi.Name = "lblGrupAdi";
            this.lblGrupAdi.Size = new System.Drawing.Size(41, 13);
            this.lblGrupAdi.TabIndex = 1;
            this.lblGrupAdi.Text = "Grup Adi";
            // 
            // txtGrupAdi
            // 
            this.txtGrupAdi.Location = new System.Drawing.Point(106, 60);
            this.txtGrupAdi.Name = "txtGrupAdi";
            this.txtGrupAdi.Size = new System.Drawing.Size(135, 20);
            this.txtGrupAdi.TabIndex = 0;
            // 
            // lblGrupKodu
            // 
            this.lblGrupKodu.Location = new System.Drawing.Point(23, 28);
            this.lblGrupKodu.Name = "lblGrupKodu";
            this.lblGrupKodu.Size = new System.Drawing.Size(50, 13);
            this.lblGrupKodu.TabIndex = 1;
            this.lblGrupKodu.Text = "Grup Kodu";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(106, 26);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Size = new System.Drawing.Size(135, 20);
            this.txtGrupKodu.TabIndex = 0;
            // 
            // FrmCariGruplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 557);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCariGruplar";
            this.Text = "FrmCariGruplar";
            this.Load += new System.EventHandler(this.FrmCariGruplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn GrupKodu;
        private DevExpress.XtraGrid.Columns.GridColumn GrupAdi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblGrupAdi;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraEditors.LabelControl lblGrupKodu;
        private DevExpress.XtraEditors.TextEdit txtGrupKodu;
    }
}