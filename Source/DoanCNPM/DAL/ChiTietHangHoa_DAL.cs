using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ChiTietHangHoa_DAL
    {
        SqlCommand cmd;
        SqlDataReader read;
        string constr;
        string sql;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public List<ChiTietHangHoa_DTO> display()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            List<ChiTietHangHoa_DTO> lst = new List<ChiTietHangHoa_DTO>();
            sql = @"EXEC P_HIENTHI_CHITIETHANGHOA";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string mahg = read[0].ToString();
                string manl = read[1].ToString();
                string soluong = read[2].ToString();
                string dvt = read[3].ToString();
                ChiTietHangHoa_DTO cthh = new ChiTietHangHoa_DTO(mahg, manl, soluong, dvt);
                lst.Add(cthh);
            }
            conn.Close();
            return lst;
        }
        public string them(ChiTietHangHoa_DTO cthh)
        {
            try
            {
                int kq;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                sql = @"EXEC P_THEM_CHITIETHANGHOA '"+cthh.MaHG_P + "', '"+cthh.MaNL_P+"', '"+cthh.SL_P+"', N'"+cthh.DVT_P+"'";
                cmd = new SqlCommand(sql, conn);
                kq = cmd.ExecuteNonQuery();
                conn.Close();
                if (kq > 0)
                {
                    return "true";
                }
                return "false";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public bool xoa(ChiTietHangHoa_DTO cthh)
        {
            int kq;
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            //sql = @"EXEC DELETE_KHACHHANG '" + kh.MaKH_P + "'";
            sql = @"EXEC P_XOA_CHITIETHANGHOA '"+cthh.MaHG_P+"', '"+cthh.MaNL_P+"'";
            cmd = new SqlCommand(sql, conn);
            kq = cmd.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
            {
                return true;
            }
            return false;
        }
        public string sua(ChiTietHangHoa_DTO cthh)
        {
            try
            {
                int kq;
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                string sql = @"EXEC P_SUA_CHITIETHANGHOA '"+cthh.MaHG_P+"', '"+cthh.MaNL_P+"', '"+cthh.SL_P+"', N'"+cthh.DVT_P+"', '"+cthh.MaHG_OLD_P+"', '"+cthh.MaNL_OLD_P+"'";
                cmd = new SqlCommand(sql, conn);
                kq = cmd.ExecuteNonQuery();
                conn.Close();
                if (kq > 0)
                {
                    return "true";
                }
                return "false";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }



        }
        public List<HangHoa_DTO> getall_mahang()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<HangHoa_DTO> lst = new List<HangHoa_DTO>();
            sql = @"EXEC DISPLAY_HANGHOA ";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string mahg = read[0].ToString();
                string tenhg = read[1].ToString();
                string dvt = read[2].ToString();
                string maloai = read[3].ToString();
                float dongia = float.Parse(read[4].ToString());
                string hinh = read[5].ToString();
                HangHoa_DTO hh = new HangHoa_DTO(mahg, tenhg, dvt, maloai, dongia, hinh);
                lst.Add(hh);
            }
            conn.Close();
            return lst;
        }
        public List<NguyenLieu_DTO> getall_manguyenlieu()
        {
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();

            List<NguyenLieu_DTO> lst = new List<NguyenLieu_DTO>();
            sql = @"EXEC P_HIENTHI_NGUYENLIEU";
            cmd = new SqlCommand(sql, conn);
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                string manl = read[0].ToString();
                string tennl = read[1].ToString();
                string sl_ton = read[2].ToString();
                string dvt = read[3].ToString();
                string dongia = read[4].ToString();
                string hinh = read[5].ToString();
                NguyenLieu_DTO nl = new NguyenLieu_DTO(manl, tennl, sl_ton, dvt, dongia, hinh);
                lst.Add(nl);
            }
            conn.Close();
            return lst;
        }
    }
}
