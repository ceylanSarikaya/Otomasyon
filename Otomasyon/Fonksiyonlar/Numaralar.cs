using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otomasyon.Fonksiyonlar
{
    class Numaralar
    {
        DataBaseDataContext Db = new DataBaseDataContext();
        Mesajlar mesajlar = new Mesajlar();
        public string KodNumarasi()
        {
            try
            {
                int Numaralar = int.Parse((from s in Db.Tbl_Stoks
                                           orderby s.Id descending
                                           select s).First().StokKodu);
                Numaralar++;
                string Num = Numaralar.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception )
            {
                return "0000001";
            }
        }
        public string CariKodNumarasi()
        {
            try
            {
                int Numaralar = int.Parse((from s in Db.TBL_Carilers
                                           orderby s.Id descending
                                           select s).First().CariKodu);
                Numaralar++;
                string Num = Numaralar.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
