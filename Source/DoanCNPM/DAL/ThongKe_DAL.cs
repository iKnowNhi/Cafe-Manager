using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ThongKe_DAL
    {
        string constr;
        public void Login(Login_DTO login)
        {
            constr = "Server=" + login.Servername + ";Database=" + login.Database + ";User Id=" + login.UserName + ";Password=" + login.Password + ";";
        }
        public DataTable thongkechiphi()
        {
            string query = @"
            SELECT 
                ISNULL(DoanhThu.Nam, ISNULL(Luong.Nam, TienNhap.Nam)) AS Nam,
                ISNULL(DoanhThu.Thang, ISNULL(Luong.Thang, TienNhap.Thang)) AS Thang,
                ISNULL(DoanhThu.DoanhThu, 0) AS DoanhThu,
                ISNULL(Luong.TongLuong, 0) AS TongLuong,
                ISNULL(TienNhap.TienNhap, 0) AS TienNhap
            FROM 
                (
                    SELECT 
                        YEAR(HOADON.NGAYLAP) AS Nam, 
                        MONTH(HOADON.NGAYLAP) AS Thang, 
                        SUM(CHITIETHOADON.GIABAN * CHITIETHOADON.SOLUONG) AS DoanhThu
                    FROM 
                        HOADON
                    LEFT JOIN 
                        CHITIETHOADON ON HOADON.MAHD = CHITIETHOADON.MAHD
                    GROUP BY 
                        YEAR(HOADON.NGAYLAP), 
                        MONTH(HOADON.NGAYLAP)
                ) AS DoanhThu
            FULL OUTER JOIN 
                (
                    SELECT 
                        YEAR(CHAMCONG.NGAYLAM) AS Nam,
                        MONTH(CHAMCONG.NGAYLAM) AS Thang,
                        SUM(DATEDIFF(HOUR, CHAMCONG.THOIGIANVAO, CHAMCONG.THOIGIANRA) * 20000) AS TongLuong
                    FROM 
                        CHAMCONG
                    GROUP BY 
                        YEAR(CHAMCONG.NGAYLAM),
                        MONTH(CHAMCONG.NGAYLAM)
                ) AS Luong
            ON 
                DoanhThu.Nam = Luong.Nam AND DoanhThu.Thang = Luong.Thang
            FULL OUTER JOIN 
                (
                    SELECT 
                        YEAR(PHIEUNHAP.NGAYNHAP) AS Nam, 
                        MONTH(PHIEUNHAP.NGAYNHAP) AS Thang, 
                        SUM(CHITIETPN.GIABAN * CHITIETPN.SOLUONG) AS TienNhap
                    FROM 
                        PHIEUNHAP
                    JOIN 
                        CHITIETPN ON PHIEUNHAP.MAPN = CHITIETPN.MAPN
                    GROUP BY 
                        YEAR(PHIEUNHAP.NGAYNHAP), 
                        MONTH(PHIEUNHAP.NGAYNHAP)
                ) AS TienNhap
            ON 
                ISNULL(DoanhThu.Nam, Luong.Nam) = TienNhap.Nam AND ISNULL(DoanhThu.Thang, Luong.Thang) = TienNhap.Thang
            ORDER BY 
                Nam, Thang;
        ";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable thongkechiphi_theothang(int month, int year)
        {
            string query = @"
                            SELECT 
                                ISNULL(Luong.TongLuong, 0) AS TongLuong,
                                ISNULL(TienNhap.TienNhap, 0) AS TienNhap,
                                ISNULL(DoanhThu.DoanhThu, 0) AS DoanhThu
                            FROM 
                                (
                                    SELECT 
                                        SUM(DATEDIFF(HOUR, CHAMCONG.THOIGIANVAO, CHAMCONG.THOIGIANRA) * 20000) AS TongLuong
                                    FROM 
                                        CHAMCONG
                                    WHERE 
                                        MONTH(CHAMCONG.NGAYLAM) = @Month AND YEAR(CHAMCONG.NGAYLAM) = @Year
                                ) AS Luong,
                                (
                                    SELECT 
                                        SUM(CHITIETPN.GIABAN * CHITIETPN.SOLUONG) AS TienNhap
                                    FROM 
                                        PHIEUNHAP
                                    JOIN 
                                        CHITIETPN ON PHIEUNHAP.MAPN = CHITIETPN.MAPN
                                    WHERE 
                                        MONTH(PHIEUNHAP.NGAYNHAP) = @Month AND YEAR(PHIEUNHAP.NGAYNHAP) = @Year
                                ) AS TienNhap,
                                (
                                    SELECT 
                                        SUM(CHITIETHOADON.GIABAN * CHITIETHOADON.SOLUONG) AS DoanhThu
                                    FROM 
                                        HOADON
                                    JOIN 
                                        CHITIETHOADON ON HOADON.MAHD = CHITIETHOADON.MAHD
                                    WHERE 
                                        MONTH(HOADON.NGAYLAP) = @Month AND YEAR(HOADON.NGAYLAP) = @Year
                                ) AS DoanhThu
                            ";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Month", month);
                    command.Parameters.AddWithValue("@Year", year);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public DataTable thongkedoanhthu()
        {
            string query = @"
                            SELECT 
                                ISNULL(DoanhThu.Nam, ISNULL(Luong.Nam, TienNhap.Nam)) AS Nam,
                                ISNULL(DoanhThu.Thang, ISNULL(Luong.Thang, TienNhap.Thang)) AS Thang,
                                ISNULL(DoanhThu.DoanhThu, 0) AS DoanhThu,
                                ISNULL(Luong.TongLuong, 0) AS TongLuong,
                                ISNULL(TienNhap.TienNhap, 0) AS TienNhap
                            FROM 
                                (
                                    SELECT 
                                        YEAR(HOADON.NGAYLAP) AS Nam, 
                                        MONTH(HOADON.NGAYLAP) AS Thang, 
                                        SUM(CHITIETHOADON.GIABAN * CHITIETHOADON.SOLUONG) AS DoanhThu
                                    FROM 
                                        HOADON
                                    LEFT JOIN 
                                        CHITIETHOADON ON HOADON.MAHD = CHITIETHOADON.MAHD
                                    GROUP BY 
                                        YEAR(HOADON.NGAYLAP), 
                                        MONTH(HOADON.NGAYLAP)
                                ) AS DoanhThu
                            FULL OUTER JOIN 
                                (
                                    SELECT 
                                        YEAR(CHAMCONG.NGAYLAM) AS Nam,
                                        MONTH(CHAMCONG.NGAYLAM) AS Thang,
                                        SUM(DATEDIFF(HOUR, CHAMCONG.THOIGIANVAO, CHAMCONG.THOIGIANRA) * 20000) AS TongLuong
                                    FROM 
                                        CHAMCONG
                                    GROUP BY 
                                        YEAR(CHAMCONG.NGAYLAM),
                                        MONTH(CHAMCONG.NGAYLAM)
                                ) AS Luong
                            ON 
                                DoanhThu.Nam = Luong.Nam AND DoanhThu.Thang = Luong.Thang
                            FULL OUTER JOIN 
                                (
                                    SELECT 
                                        YEAR(PHIEUNHAP.NGAYNHAP) AS Nam, 
                                        MONTH(PHIEUNHAP.NGAYNHAP) AS Thang, 
                                        SUM(CHITIETPN.GIABAN * CHITIETPN.SOLUONG) AS TienNhap
                                    FROM 
                                        PHIEUNHAP
                                    JOIN 
                                        CHITIETPN ON PHIEUNHAP.MAPN = CHITIETPN.MAPN
                                    GROUP BY 
                                        YEAR(PHIEUNHAP.NGAYNHAP), 
                                        MONTH(PHIEUNHAP.NGAYNHAP)
                                ) AS TienNhap
                            ON 
                                ISNULL(DoanhThu.Nam, Luong.Nam) = TienNhap.Nam AND ISNULL(DoanhThu.Thang, Luong.Thang) = TienNhap.Thang
                            ORDER BY 
                                Nam, Thang;

                            ";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public DataTable thongkesanphambanchay(int thang)
        {
            string query = "SELECT HH.TENHANG, SUM(CTHD.SOLUONG) AS TongSoLuong " +
                       "FROM HOADON HD " +
                       "JOIN CHITIETHOADON CTHD ON HD.MAHD = CTHD.MAHD " +
                       "JOIN HANGHOA HH ON CTHD.MAHG = HH.MAHG " +
                       "WHERE MONTH(HD.NGAYLAP) = @Thang " +
                       "GROUP BY HH.TENHANG " +
                       "ORDER BY TongSoLuong DESC";

            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Thang", thang);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
