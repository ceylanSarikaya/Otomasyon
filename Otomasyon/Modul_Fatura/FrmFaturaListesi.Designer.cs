﻿
namespace Otomasyon.Modul_Fatura
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.txtFaturaNo = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lblBarkod = new DevExpress.XtraEditors.LabelControl();
            this.lblStokAdi = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.lblStokKodu = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFaturaTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(11, 107);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(176, 20);
            this.txtFaturaNo.TabIndex = 1;
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
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(382, 320);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lblBarkod
            // 
            this.lblBarkod.Location = new System.Drawing.Point(11, 155);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(24, 13);
            this.lblBarkod.TabIndex = 0;
            this.lblBarkod.Text = "Tarih";
            // 
            // lblStokAdi
            // 
            this.lblStokAdi.Location = new System.Drawing.Point(11, 88);
            this.lblStokAdi.Name = "lblStokAdi";
            this.lblStokAdi.Size = new System.Drawing.Size(48, 13);
            this.lblStokAdi.TabIndex = 0;
            this.lblStokAdi.Text = "Fatura No";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.btnsil);
            this.xtraTabPage1.Controls.Add(this.btnAra);
            this.xtraTabPage1.Controls.Add(this.txtFaturaNo);
            this.xtraTabPage1.Controls.Add(this.lblBarkod);
            this.xtraTabPage1.Controls.Add(this.lblStokAdi);
            this.xtraTabPage1.Controls.Add(this.lblStokKodu);
            this.xtraTabPage1.Controls.Add(this.txtFaturaTuru);
            this.xtraTabPage1.Controls.Add(this.txtTarih);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(190, 295);
            this.xtraTabPage1.Text = "Arama";
            // 
            // lblStokKodu
            // 
            this.lblStokKodu.Location = new System.Drawing.Point(11, 32);
            this.lblStokKodu.Name = "lblStokKodu";
            this.lblStokKodu.Size = new System.Drawing.Size(57, 13);
            this.lblStokKodu.TabIndex = 0;
            this.lblStokKodu.Text = "Fatura Turu";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(192, 320);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
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
            this.splitContainer1.Size = new System.Drawing.Size(578, 320);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 1;
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
            // txtFaturaTuru
            // 
            this.txtFaturaTuru.EditValue = "Satis Faturasi";
            this.txtFaturaTuru.Location = new System.Drawing.Point(11, 51);
            this.txtFaturaTuru.Name = "txtFaturaTuru";
            this.txtFaturaTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFaturaTuru.Properties.Items.AddRange(new object[] {
            "Satis Faturasi",
            "Satis Iade Faturasi",
            "Alis Faturasi",
            "Alis  Iade Faturasi"});
            this.txtFaturaTuru.Size = new System.Drawing.Size(176, 20);
            this.txtFaturaTuru.TabIndex = 1;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(11, 174);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(176, 20);
            this.txtTarih.TabIndex = 1;
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 320);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmFaturaListesi";
            this.Text = "FrmFaturaListesi";
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFaturaTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn StokBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn StokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtFaturaNo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn StokAdi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl lblBarkod;
        private DevExpress.XtraEditors.LabelControl lblStokAdi;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl lblStokKodu;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.ComboBoxEdit txtFaturaTuru;
        private DevExpress.XtraEditors.DateEdit txtTarih;
    }
}