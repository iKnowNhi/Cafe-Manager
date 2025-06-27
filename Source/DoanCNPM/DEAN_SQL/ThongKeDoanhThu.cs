using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DEAN_SQL
{
    public partial class ThongKeDoanhThu : Form
    {
        ThongKe_BLL TK_BLL=new ThongKe_BLL();
        public string user, pass, server, data, connectionString;
        public ThongKeDoanhThu(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            TK_BLL.login(login);

        }
        private void thongkechiphi()
        {
            // Lấy dữ liệu từ phương thức thongkechiphi() chỉ một lần
            DataTable data = TK_BLL.thongkechiphi();

            // Thêm cột "DoanhThuThuc" vào DataTable
            if (!data.Columns.Contains("DoanhThuThuc"))
            {
                data.Columns.Add("DoanhThuThuc", typeof(decimal));
            }

            // Gắn dữ liệu vào Chart
            chart1.DataSource = data;

            // Xóa tất cả các Series cũ để tránh xung đột
            chart1.Series.Clear();

            // Tạo và cấu hình các Series
            Series doanhThuSeries = new Series("Tổng bán")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueMember = "Thang",
                YValueMembers = "DoanhThu",
                Color = System.Drawing.Color.Blue,
                IsValueShownAsLabel = true,
                LabelFormat = "C0"
            };
            chart1.Series.Add(doanhThuSeries);

            Series tongLuongSeries = new Series("Tổng lương")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueMember = "Thang",
                YValueMembers = "TongLuong",
                Color = System.Drawing.Color.Orange,
                IsValueShownAsLabel = true,
                LabelFormat = "C0"
            };
            chart1.Series.Add(tongLuongSeries);

            Series tienNhapSeries = new Series("Tiền nhập")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueMember = "Thang",
                YValueMembers = "TienNhap",
                Color = System.Drawing.Color.Red,
                IsValueShownAsLabel = true,
                LabelFormat = "C0"
            };
            chart1.Series.Add(tienNhapSeries);

            // Tính toán và gán giá trị cho "DoanhThuThuc"
            foreach (DataRow row in data.Rows)
            {
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);
                decimal tongLuong = Convert.ToDecimal(row["TongLuong"]);
                decimal tienNhap = Convert.ToDecimal(row["TienNhap"]);
                row["DoanhThuThuc"] = doanhThu - tongLuong - tienNhap;
            }

            // Tạo và cấu hình Series DoanhThuThuc
            Series doanhThuThucSeries = new Series("Doanh thu thực")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                XValueMember = "Thang",
                YValueMembers = "DoanhThuThuc",
                Color = System.Drawing.Color.LawnGreen,
                IsValueShownAsLabel = true,
                LabelFormat = "C0"
            };
            chart1.Series.Add(doanhThuThucSeries);

            // Làm mới biểu đồ
            chart1.DataBind();

            // Hiển thị giá trị trên đỉnh mỗi cột của Series "DoanhThu"
            chart1.Series["Tổng bán"].IsValueShownAsLabel = true;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1; // Hiển thị tất cả các tháng
            chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            foreach (DataRow row in data.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(
                    thang - 0.5, thang + 0.5, $"Tháng {thang}");
            }

            // Định dạng hiển thị giá trị trên cột cho từng Series
            foreach (var series in chart1.Series)
            {
                foreach (var point in series.Points)
                {
                    // Kiểm tra nếu giá trị là 0, hiển thị "0 VNĐ"
                    point.Label = point.YValues[0] == 0 ? "0" : string.Format("{0:###,###,###}", point.YValues[0]);

                    point.LabelForeColor = System.Drawing.Color.Black;
                    point.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                    point.LabelAngle = 0;
                    point.IsValueShownAsLabel = true;
                }
            }

            // Định dạng trục Y
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:###,###,###} VNĐ"; // Hiển thị VNĐ
            chart1.ChartAreas[0].AxisY.Title = "Đơn vị (VNĐ)";
            chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
        }

        // PL - Presentation Layer
        private void thongkechiphi_theoThang(int month, int year)
        {
            DataTable dataTable = TK_BLL.thongkechiphi_theothang(month, year);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho tháng " + month + " năm " + year, "Thông báo");
                return;
            }

            // Lấy giá trị từ DataTable
            DataRow row = dataTable.Rows[0];
            decimal tongLuong = Convert.ToDecimal(row["TongLuong"]);
            decimal tienNhap = Convert.ToDecimal(row["TienNhap"]);
            decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);

            // Kiểm tra nếu tất cả các giá trị đều bằng 0
            if (tongLuong == 0 && tienNhap == 0 && doanhThu == 0)
            {
                MessageBox.Show("Không có dữ liệu chi phí cho tháng này.", "Thông báo");
                return;
            }

            // Tính tổng chi phí
            decimal tongChiPhi = tongLuong + tienNhap + doanhThu;

            // Cấu hình biểu đồ dạng Pie
            chart4.Series.Clear();
            chart4.DataSource = null;

            Series pieSeries = new Series
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "P1" // Hiển thị dưới dạng phần trăm
            };

            // Thêm dữ liệu vào Series
            pieSeries.Points.AddXY("Tổng lương", tongLuong / tongChiPhi);
            pieSeries.Points.AddXY("Tiền nhập", tienNhap / tongChiPhi);
            pieSeries.Points.AddXY("Tổng bán", doanhThu / tongChiPhi);

            // Gắn nhãn cho từng phần
            foreach (var point in pieSeries.Points)
            {
                point.Label = $"{point.AxisLabel}: {point.YValues[0]:P1}";
                point.LabelForeColor = System.Drawing.Color.Black;
            }

            chart4.Series.Add(pieSeries);

            // Tùy chỉnh tiêu đề và các thuộc tính khác của biểu đồ
            chart4.Titles.Clear();
            chart4.Titles.Add($"Chi phí tháng {month} năm {year}");
            chart4.Titles[0].Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            chart4.Legends.Clear();
            chart4.Legends.Add(new Legend
            {
                Title = "Loại chi phí",
                TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold)
            });
        }

        public void thongkedoanhthu()
        {
            DataTable dataTable = TK_BLL.thongkedoanhthu();
            // Gắn dữ liệu vào Chart
            chart3.DataSource = dataTable;

            // Xóa tất cả các Series cũ để tránh xung đột
            chart3.Series.Clear();

            // Thêm cột "DoanhThuThuc" vào DataTable
            dataTable.Columns.Add("DoanhThuThuc", typeof(decimal));
            foreach (DataRow row in dataTable.Rows)
            {
                decimal doanhThu = Convert.ToDecimal(row["DoanhThu"]);
                decimal tongLuong = Convert.ToDecimal(row["TongLuong"]);
                decimal tienNhap = Convert.ToDecimal(row["TienNhap"]);
                row["DoanhThuThuc"] = doanhThu - tongLuong - tienNhap;
            }

            // Chỉ hiển thị biểu đồ DoanhThuThuc dưới dạng đường
            Series doanhThuThucSeries = new Series("Doanh thu thực")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line, // Biểu đồ đường
                XValueMember = "Thang",
                YValueMembers = "DoanhThuThuc",
                Color = System.Drawing.Color.LawnGreen, // Màu xanh chuối
                BorderWidth = 3, // Độ dày của đường
                IsValueShownAsLabel = true, // Hiển thị giá trị trên điểm
                LabelFormat = "", // Hiển thị dưới dạng tiền tệ
                MarkerStyle = MarkerStyle.Circle, // Kiểu marker trên các điểm
                MarkerSize = 10, // Kích thước marker
                MarkerColor = System.Drawing.Color.DarkGreen // Màu marker
            };
            chart3.Series.Add(doanhThuThucSeries);


            // Ẩn các Series khác
            foreach (var series in chart3.Series)
            {
                if (series.Name != "Doanh thu thực")
                {
                    series.Enabled = false; // Ẩn Series
                }
            }


            // Làm mới biểu đồ
            chart3.DataBind();

            // Định dạng lại trục X
            chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 1; // Hiển thị tất cả các tháng
            chart3.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            chart3.ChartAreas[0].AxisX.CustomLabels.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                int thang = Convert.ToInt32(row["Thang"]);
                chart3.ChartAreas[0].AxisX.CustomLabels.Add(
                    thang - 0.5, thang + 0.5, $"Tháng {thang}");
            }

            // Định dạng trục Y
            chart3.ChartAreas[0].AxisY.LabelStyle.Format = "{0:###,###,###} VNĐ"; // Hiển thị VNĐ
            chart3.ChartAreas[0].AxisY.Title = "Đơn vị (VNĐ)"; // Tiêu đề trục Y
            chart3.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Arial", 12, FontStyle.Bold);

            // Làm mới biểu đồ
            chart3.DataBind();
        }
        // PL - Presentation Layer
        private void thongkesanphambanchay(int thang)
        {
            DataTable dataTable = TK_BLL.thongkesanphambanchay(thang);

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho tháng " + thang, "Thông báo");
                return;
            }

            // Cấu hình chart
            chart2.Series.Clear();
            chart2.Titles.Clear(); // Xóa các tiêu đề cũ
            chart2.ChartAreas.Clear(); // Xóa các vùng biểu đồ cũ
            chart2.Legends.Clear(); // Xóa các chú thích cũ

            ChartArea chartArea = new ChartArea
            {
                Name = "ChartArea",
                AxisX =
                {
                    Title = "Tên sản phẩm",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold),
                    IntervalAutoMode = IntervalAutoMode.VariableCount
                },
                AxisY =
                {
                    Title = "Số lượng sản phẩm",
                    TitleFont = new Font("Arial", 12, FontStyle.Bold),
                    LabelStyle = { Font = new Font("Arial", 10) }
                }
                };
            chart2.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "Doanh số sản phẩm",
                ChartType = SeriesChartType.Bar, // Biểu đồ cột nằm ngang
                ChartArea = "ChartArea",
                IsValueShownAsLabel = true, // Hiển thị giá trị trên cột
                LabelFormat = "#,##0", // Định dạng số lượng
            };
            chart2.Series.Add(series);

            // Thêm dữ liệu vào biểu đồ từ DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                string tenHang = row["TENHANG"].ToString();
                int tongSoLuong = Convert.ToInt32(row["TongSoLuong"]);

                series.Points.AddXY(tenHang, tongSoLuong);
            }

            // Thêm tiêu đề cho biểu đồ
            Title chartTitle = new Title
            {
                Text = $"Sản phẩm bán chạy nhất tháng {thang}",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Black,
                Alignment = ContentAlignment.MiddleCenter
            };
            chart2.Titles.Add(chartTitle);

            // Tùy chỉnh chú thích
            Legend legend = new Legend
            {
                Name = "Legend",
                Docking = Docking.Bottom,
                Font = new Font("Arial", 10),
                IsTextAutoFit = true
            };
            chart2.Legends.Add(legend);
        }


        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            thongkechiphi();
            thongkedoanhthu();
            thongkechiphi_theoThang(DateTime.Now.Month, DateTime.Now.Year);
            thongkesanphambanchay(DateTime.Now.Month);
        }



        private void btnapdungthangnam_Click(object sender, EventArgs e)
        {
            thongkechiphi_theoThang(int.Parse(datechiphi.Value.Month.ToString()), int.Parse(datechiphi.Value.Year.ToString()));
        }

        private void btnapdung_Click(object sender, EventArgs e)
        {
            thongkesanphambanchay(int.Parse(datesp.Value.Month.ToString()));

        }

        private void datesp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
