
namespace Otomasyon
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStokKarti = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnStokListesi = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokGruplari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokHareketleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnCariAcilisKarti = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariGruplar = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariListeler = new DevExpress.XtraBars.BarButtonItem();
            this.btnCariHareketler = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barBtnStokKarti,
            this.barbtnStokListesi,
            this.barBtnStokGruplari,
            this.barBtnStokHareketleri,
            this.btnCariAcilisKarti,
            this.btnCariGruplar,
            this.btnCariListeler,
            this.btnCariHareketler});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(442, 177);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barBtnStokKarti
            // 
            this.barBtnStokKarti.Caption = "Stok Karti";
            this.barBtnStokKarti.Id = 1;
            this.barBtnStokKarti.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.indir__1_;
            this.barBtnStokKarti.Name = "barBtnStokKarti";
            this.barBtnStokKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokKarti_ItemClick);
            // 
            // barbtnStokListesi
            // 
            this.barbtnStokListesi.Caption = "Stok Listesi";
            this.barbtnStokListesi.Id = 2;
            this.barbtnStokListesi.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.images;
            this.barbtnStokListesi.Name = "barbtnStokListesi";
            this.barbtnStokListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnStokListesi_ItemClick);
            // 
            // barBtnStokGruplari
            // 
            this.barBtnStokGruplari.Caption = "Stok Gruplari";
            this.barBtnStokGruplari.Id = 3;
            this.barBtnStokGruplari.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.images__1_;
            this.barBtnStokGruplari.Name = "barBtnStokGruplari";
            this.barBtnStokGruplari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokGruplari_ItemClick);
            // 
            // barBtnStokHareketleri
            // 
            this.barBtnStokHareketleri.Caption = "Stok Hareketleri";
            this.barBtnStokHareketleri.Id = 4;
            this.barBtnStokHareketleri.ImageOptions.LargeImage = global::Otomasyon.Properties.Resources.stok;
            this.barBtnStokHareketleri.Name = "barBtnStokHareketleri";
            this.barBtnStokHareketleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokHareketleri_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stok";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokKarti);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnStokListesi);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokGruplari);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnStokHareketleri);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cari";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCariAcilisKarti);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCariGruplar);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCariListeler);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCariHareketler);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // btnCariAcilisKarti
            // 
            this.btnCariAcilisKarti.Caption = "Cari Acılış Kartı";
            this.btnCariAcilisKarti.Id = 5;
            this.btnCariAcilisKarti.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariAcilisKarti.ImageOptions.Image")));
            this.btnCariAcilisKarti.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCariAcilisKarti.ImageOptions.LargeImage")));
            this.btnCariAcilisKarti.Name = "btnCariAcilisKarti";
            this.btnCariAcilisKarti.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariAcilisKarti_ItemClick);
            // 
            // btnCariGruplar
            // 
            this.btnCariGruplar.Caption = "Cari Gruplar";
            this.btnCariGruplar.Id = 6;
            this.btnCariGruplar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariGruplar.ImageOptions.Image")));
            this.btnCariGruplar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCariGruplar.ImageOptions.LargeImage")));
            this.btnCariGruplar.Name = "btnCariGruplar";
            this.btnCariGruplar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariGruplar_ItemClick);
            // 
            // btnCariListeler
            // 
            this.btnCariListeler.Caption = "Cari Listeler";
            this.btnCariListeler.Id = 7;
            this.btnCariListeler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariListeler.ImageOptions.Image")));
            this.btnCariListeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCariListeler.ImageOptions.LargeImage")));
            this.btnCariListeler.Name = "btnCariListeler";
            this.btnCariListeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariListeler_ItemClick);
            // 
            // btnCariHareketler
            // 
            this.btnCariHareketler.Caption = "Cari Hareketler";
            this.btnCariHareketler.Id = 8;
            this.btnCariHareketler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCariHareketler.ImageOptions.Image")));
            this.btnCariHareketler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCariHareketler.ImageOptions.LargeImage")));
            this.btnCariHareketler.Name = "btnCariHareketler";
            this.btnCariHareketler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCariHareketler_ItemClick);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnStokKarti;
        private DevExpress.XtraBars.BarButtonItem barbtnStokListesi;
        private DevExpress.XtraBars.BarButtonItem barBtnStokGruplari;
        private DevExpress.XtraBars.BarButtonItem barBtnStokHareketleri;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCariAcilisKarti;
        private DevExpress.XtraBars.BarButtonItem btnCariGruplar;
        private DevExpress.XtraBars.BarButtonItem btnCariListeler;
        private DevExpress.XtraBars.BarButtonItem btnCariHareketler;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}