using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHangHoa_DTO
    {
        private string MaHG;
        private string MaNL;
        private string SL;
        private string DVT;
        private string MaHG_OLD;
        private string MaNL_OLD;
        public string MaHG_P { get => MaHG; set => MaHG = value; }
        public string MaNL_P { get => MaNL; set => MaNL = value; }
        public string SL_P { get => SL; set => SL = value; }
        public string DVT_P { get => DVT; set => DVT = value; }
        public string MaHG_OLD_P { get => MaHG_OLD; set => MaHG_OLD = value; }
        public string MaNL_OLD_P { get => MaNL_OLD; set => MaNL_OLD = value; }

        public ChiTietHangHoa_DTO(string mahg, string manl, string sl, string dvt)
        {
            MaHG_P = mahg;
            MaNL_P = manl;
            SL_P = sl;
            DVT_P = dvt;

        }
        public ChiTietHangHoa_DTO(string mahg, string manl, string sl, string dvt, string mahg_old, string manl_old)
        { 
            MaHG_P = mahg;
            MaNL_P = manl;
            SL_P = sl;
            DVT_P = dvt;
            MaHG_OLD_P= mahg_old;
            MaNL_OLD_P = manl_old;
        }


    }
}
