using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPN_DTO
    {
        private string maPN;
        private string maNL;
        private string sL;
        private string giaBan;

        public string MaPN_P { get => maPN; set => maPN = value; }
        public string SL_P { get => sL; set => sL = value; }
        public string GiaBan_P { get => giaBan; set => giaBan = value; }
        public string MaNL_P { get => maNL; set => maNL = value; }

        public ChiTietPN_DTO(string mapn, string manl, string sl, string giaban)
        {
            MaPN_P = mapn;
            MaNL_P = manl;
            SL_P = sl;
            GiaBan_P = giaban;
        }
        public ChiTietPN_DTO(string mapn, string manl)
        {
            MaPN_P = mapn;
            MaNL_P = manl;
        }
    }
}
