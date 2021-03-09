using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon.Modul_Cari
{
    public partial class FrmCariListeler : DevExpress.XtraEditors.XtraForm
    {
        public bool Secim = false;
        int SecimId = -1;
        public FrmCariListeler()
        {
            InitializeComponent();
        }

        private void FrmCariListeler_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {

        }
    }
}