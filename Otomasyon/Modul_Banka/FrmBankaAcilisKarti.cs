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

namespace Otomasyon.Modul_Stok
{
    public partial class FrmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        bool Edit = false;
        int SecimId = -1;

        public FrmBankaAcilisKarti()
        {
            InitializeComponent();
        }

        private void FrmBankaAcilisKarti_Load(object sender, EventArgs e)
        {

        }
    }
}