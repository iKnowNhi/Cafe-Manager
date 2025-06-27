using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ThongKe_BLL
    {
        ThongKe_DAL DAL = new ThongKe_DAL();

        public void login(Login_DTO login)
        {
            DAL.Login(login);
        }
        public DataTable thongkechiphi()
        {
            return DAL.thongkechiphi();
        }
        public DataTable thongkechiphi_theothang(int month, int year)
        {
            return DAL.thongkechiphi_theothang( month, year);
        }
        public DataTable thongkedoanhthu()
        {
            return DAL.thongkedoanhthu();
        }
        public DataTable thongkesanphambanchay(int thang)
        {
            return DAL.thongkesanphambanchay(thang);
        }

    }
}
