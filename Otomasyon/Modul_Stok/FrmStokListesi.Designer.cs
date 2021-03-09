
namespace Otomasyon.Modul_Stok
{
    partial class FrmStokListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokListesi));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.lblBarkod = new DevExpress.XtraEditors.LabelControl();
            this.lblStokAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblStokKodu = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.xtraTabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(861, 380);
            this.splitContainer1.SplitterDistance = 287;
            this.splitContainer1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(287, 380);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnsil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtBarkod);
            this.xtraTabPage1.Controls.Add(this.txtStokAdi);
            this.xtraTabPage1.Controls.Add(this.txtStokKodu);
            this.xtraTabPage1.Controls.Add(this.lblBarkod);
            this.xtraTabPage1.Controls.Add(this.lblStokAdi);
            this.xtraTabPage1.Controls.Add(this.lblStokKodu);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(285, 355);
            this.xtraTabPage1.Text = "Arama";
            // 
            // btnsil
            // 
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(112, 214);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 39);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(11, 214);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 39);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(11, 174);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(176, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.Location = new System.Drawing.Point(11, 107);
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Size = new System.Drawing.Size(176, 20);
            this.txtStokAdi.TabIndex = 1;
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(11, 51);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Size = new System.Drawing.Size(176, 20);
            this.txtStokKodu.TabIndex = 1;
            // 
            // lblBarkod
            // 
            this.lblBarkod.Location = new System.Drawing.Point(11, 155);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(33, 13);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "Barkod";
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.Location = new System.Drawing.Point(11, 88);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(39, 13);
            this.lblStokAdi.TabIndex = 0;
            this.lblStokAdi.Text = "Stok Adi";
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.Location = new System.Drawing.Point(11, 32);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(48, 13);
            this.lblStokKodu.TabIndex = 0;
            this.lblStokKodu.Text = "Stok Kodu";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(570, 380);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.StokKodu,
            this.StokAdi,
            this.StokBarkod});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // StokKodu
            // 
            this.StokKodu.Caption = "StokKodu";
            this.StokKodu.FieldName = "StokKodu";
            this.StokKodu.Name = "StokKodu";
            this.StokKodu.OptionsColumn.AllowEdit = false;
            this.StokKodu.OptionsColumn.AllowFocus = false;
            this.StokKodu.OptionsColumn.FixedWidth = true;
            this.StokKodu.Visible = true;
            this.StokKodu.VisibleIndex = 0;
            // 
            // StokAdi
            // 
            this.StokAdi.Caption = "StokAdi";
            this.StokAdi.FieldName = "StokAdi";
            this.StokAdi.Name = "StokAdi";
            this.StokAdi.OptionsColumn.AllowEdit = false;
            this.StokAdi.OptionsColumn.AllowFocus = false;
            this.StokAdi.OptionsColumn.FixedWidth = true;
            this.StokAdi.Visible = true;
            this.StokAdi.VisibleIndex = 1;
            // 
            // StokBarkod
            // 
            this.StokBarkod.Caption = "StokBarkod";
            this.StokBarkod.FieldName = "StokBarkod";
            this.StokBarkod.Name = "StokBarkod";
            this.StokBarkod.OptionsColumn.AllowEdit = false;
            this.StokBarkod.OptionsColumn.AllowFocus = false;
            this.StokBarkod.OptionsColumn.FixedWidth = true;
            this.StokBarkod.Visible = true;
            this.StokBarkod.VisibleIndex = 2;
            // 
            // FrmStokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 380);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmStokListesi";
            this.Text = "Stok Listesi";
            this.Load += new System.EventHandler(this.FrmStokListesi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.TextEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl lblBarkod;
        private DevExpress.XtraEditors.LabelControl lblStokAdi;
        private DevExpress.XtraEditors.LabelControl lblStokKodu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn StokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn StokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn StokBarkod;
    }
}