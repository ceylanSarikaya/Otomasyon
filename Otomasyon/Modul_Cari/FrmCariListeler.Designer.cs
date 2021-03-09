
namespace Otomasyon.Modul_Cari
{
    partial class FrmCariListeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariListeler));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariGrup = new DevExpress.XtraEditors.TextEdit();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.lblCariGrup = new DevExpress.XtraEditors.LabelControl();
            this.lblCariAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblCariKodu = new DevExpress.XtraEditors.LabelControl();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(876, 399);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(292, 399);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnsil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtCariGrup);
            this.xtraTabPage1.Controls.Add(this.txtCariAdi);
            this.xtraTabPage1.Controls.Add(this.txtCariKodu);
            this.xtraTabPage1.Controls.Add(this.lblCariGrup);
            this.xtraTabPage1.Controls.Add(this.lblCariAdi);
            this.xtraTabPage1.Controls.Add(this.lblCariKodu);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(290, 374);
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
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.ImageOptions.Image")));
            this.btnAra.Location = new System.Drawing.Point(11, 214);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 39);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            // 
            // txtCariGrup
            // 
            this.txtCariGrup.Location = new System.Drawing.Point(11, 174);
            this.txtCariGrup.Name = "txtCariGrup";
            this.txtCariGrup.Size = new System.Drawing.Size(176, 20);
            this.txtCariGrup.TabIndex = 1;
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(11, 107);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(176, 20);
            this.txtCariAdi.TabIndex = 1;
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Location = new System.Drawing.Point(11, 51);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(176, 20);
            this.txtCariKodu.TabIndex = 1;
            // 
            // lblCariGrup
            // 
            this.lblCariGrup.Location = new System.Drawing.Point(11, 155);
            this.lblCariGrup.Name = "lblCariGrup";
            this.lblCariGrup.Size = new System.Drawing.Size(45, 13);
            this.lblCariGrup.TabIndex = 0;
            this.lblCariGrup.Text = "Cari Grup";
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.Location = new System.Drawing.Point(11, 88);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Size = new System.Drawing.Size(37, 13);
            this.lblCariAdi.TabIndex = 0;
            this.lblCariAdi.Text = "Cari Adi";
            // 
            // lblCariKodu
            // 
            this.lblCariKodu.Location = new System.Drawing.Point(11, 32);
            this.lblCariKodu.Name = "lblCariKodu";
            this.lblCariKodu.Size = new System.Drawing.Size(46, 13);
            this.lblCariKodu.TabIndex = 0;
            this.lblCariKodu.Text = "Cari Kodu";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(580, 399);
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
            // FrmCariListeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 399);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCariListeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCariListeler";
            this.Load += new System.EventHandler(this.FrmCariListeler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtCariGrup;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl lblCariGrup;
        private DevExpress.XtraEditors.LabelControl lblCariAdi;
        private DevExpress.XtraEditors.LabelControl lblCariKodu;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn StokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn StokAdi;
        private DevExpress.XtraGrid.Columns.GridColumn StokBarkod;
    }
}