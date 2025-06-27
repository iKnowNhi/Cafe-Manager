using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class ChiTietHangHoa_BLL
    {
        ChiTietHangHoa_DAL DAL = new ChiTietHangHoa_DAL();
        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public List<ChiTietHangHoa_DTO> display()
        {
            return DAL.display();
        }
        public string them(ChiTietHangHoa_DTO cthh)
        {
            try
            {
                string kq = DAL.them(cthh);
                if (kq == "true")
                {
                    return "true";
                }
                else return kq;
            }
            catch (Exception ex)
            {
                return "false";
            }

        }
        public bool xoa(ChiTietHangHoa_DTO cthh)
        {
            try
            {
                bool kq = DAL.xoa(cthh);
                if (kq == true)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public string sua(ChiTietHangHoa_DTO cthh)
        {
            try
            {
                string kq = DAL.sua(cthh);
                if (kq == "true")
                {
                    return "true";
                }
                else return kq;
            }
            catch (Exception ex)
            {
                return "false";
            }

        }
        public List<HangHoa_DTO> getall_mahang()
        {
            return DAL.getall_mahang();
        }
        public List<NguyenLieu_DTO> getall_manguyenlieu()
        {
            return DAL.getall_manguyenlieu();
        }
    }
}
