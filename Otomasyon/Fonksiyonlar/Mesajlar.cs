using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Fonksiyonlar
{
    class Mesajlar
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, "Yeni Kayit Girişi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Secili Kalıcı olarak Guncellenecektir.\n Guncelleme İslemi Onaylıyor musunuzz?", "Guncelleme  İslemi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Secili Kalıcı olarak Silinecektir.\n Silme İslemi Onaylıyor musunuzz?", "Silme  İslemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayit Guncellemiştir","Kayıt Guncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
