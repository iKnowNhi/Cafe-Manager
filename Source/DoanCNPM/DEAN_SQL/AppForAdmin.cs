using BLL;
using DocumentFormat.OpenXml.Wordprocessing;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DEAN_SQL
{
    public partial class AppForAdmin : Form
    {
        Logout_BLL BLL = new Logout_BLL();
        HangHoa_BLL BLL_HH=new HangHoa_BLL();
        NhanVien_BLL BLL_NV = new NhanVien_BLL();
        private Timer timer_logout;
        public string user, pass, sever, data;
        Logout_DTO logout;
        public AppForAdmin(string phanQuyen, string cachuc, string name, string password, string servername, string database)
        {
           
            InitializeComponent();
            lblPhanQuyen.Text = phanQuyen;
            if(lblPhanQuyen.Text=="&Admin")
            {
                btnPhanQuyen.Visible = true;
                btnthongke.Visible = true;
            }    
            
            timer_logout = new Timer();
            timer_logout.Interval = 2000; // Kiểm tra mỗi phút
            timer_logout.Tick += timer_logout_Tick;
            timer_logout.Start();
            user = name;
            pass = password;
            sever = servername;
            data = database;
            logout = new Logout_DTO(name, password, servername, database);
            Login_DTO login = new Login_DTO(name, password, servername, database);
            BLL_HH.login(login);
            Login_DTO login_nv = new Login_DTO(name, password, servername, database);
            BLL_NV.login(login_nv);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            lblUserName.Text = name;
            lblcachuc.Text = cachuc;
        }


        private void App_Load(object sender, EventArgs e)
        {
            btnWorkWithData.Visible = false;

            if (lblPhanQuyen.Text.Equals("&Admin"))
            {
                btnWorkWithData.Visible = true;
            }
            lstbanhang.ContextMenuStrip = contextMenuStrip1;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void App_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    

        private void btnWorkWithData_Click(object sender, EventArgs e)
        {
            //WorkWithData workWithData = new WorkWithData(lblPhanQuyen.Text, user, pass, sever, data);
            //workWithData.Show();
            OpenChildForm(new WorkWithData(lblPhanQuyen.Text, user, pass, sever, data));
            //this.Close();
        }

        private void timer_logout_Tick(object sender, EventArgs e)
        {
            try
            {

                bool kq = BLL.timer_logout_Tick(logout);
                if (kq == true)
                {
                    timer_logout.Stop();
                    // Hiển thị form đăng nhập và đóng form chính
                    Form1 login = new Form1();
                    login.Location = this.Location; // Đặt form login ở vị trí của form hiện tại
                    login.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error-------> " + ex.Message);
            }
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {

            //DatabaseConnection.InitializeConnection(connString);
            try
            {
                // Đăng xuất và đóng tất cả các form khác
                timer_logout.Stop();
                // Xóa phiên đăng nhập

                BLL.Xoa_phiendangnhap(logout);



                // Hiển thị form đăng nhập và đóng form hiện tại
                Form1 login = new Form1();
                login.Location = this.Location; // Đặt form login ở vị trí của form hiện tại
                login.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error-------> " + ex.Message);
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //KhachHang kh = new KhachHang(user, pass, sever, data);
            //kh.Show();
            OpenChildForm(new KhachHangView(user, pass, sever, data));
        }
        private void btnhoadon_Click(object sender, EventArgs e)
        {
            //panelcontainer.Controls.Clear();
            //HoaDon hd = new HoaDon(user, pass, sever, data);

            OpenChildForm(new HoaDon(user, pass, sever, data));

            //hd.TopLevel = false; // Đặt formCon là form con không có thanh tiêu đề riêng.
            //hd.FormBorderStyle = FormBorderStyle.None; // Bỏ viền của form con.
            //hd.Dock = DockStyle.Fill; // Form con sẽ chiếm toàn bộ khu vực chứa.
            //// Giả sử bạn có một Panel tên là panelContainer trong FormCha
            //hd.Parent = panelcontainer;
            //hd.Dock = DockStyle.Fill; // Tùy chọn: Hoặc điều chỉnh vị trí theo nhu cầu.

            //hd.Show();
        }
        private void btnchitiethoadon_Click(object sender, EventArgs e)
        {
            //CHITIETHOADON ct = new CHITIETHOADON(user, pass, sever, data);
            //ct.Show();
            OpenChildForm(new CHITIETHOADON(user, pass, sever, data));
        }

        private void btnhanghoa_Click(object sender, EventArgs e)
        {

            OpenChildForm(new HangHoa(user, pass, sever, data));
            //panelcontainer.Controls.Clear(); -- dòng này command lại
            //HangHoa hh = new HangHoa(user, pass, sever, data); -- dòng này command lại

            //hh.TopLevel = false; // Đặt formCon là form con không có thanh tiêu đề riêng.
            //hh.FormBorderStyle = FormBorderStyle.None; // Bỏ viền của form con.
            //hh.Dock = DockStyle.Fill; // Form con sẽ chiếm toàn bộ khu vực chứa.
            //// Giả sử bạn có một Panel tên là panelContainer trong FormCha
            //hh.Parent = panelcontainer;
            //hh.Dock = DockStyle.Fill; // Tùy chọn: Hoặc điều chỉnh vị trí theo nhu cầu.

            //hh.Show();  -- dòng này command lại
        }
        private void btnkhuyenmai_Click(object sender, EventArgs e)
        {
            //KhuyenMai km = new KhuyenMai(user, pass, sever, data);
            //km.Show();
            OpenChildForm(new KhuyenMai(user, pass, sever, data));

        }

        private void btnloaihang_Click(object sender, EventArgs e)
        {
            //LoaiHang lh = new LoaiHang(user, pass, sever, data);
            //lh.Show();
            OpenChildForm(new LoaiHang(user, pass, sever, data));
        }

        private void btnchitietpn_Click(object sender, EventArgs e)
        {
            //CHITIETPN ctpn = new CHITIETPN( user, pass, sever, data);
            //ctpn.Show();
            OpenChildForm(new CHITIETPN(user, pass, sever, data));
        }

        private void btnphieunhap_Click(object sender, EventArgs e)
        {
            //PHIEUNHAP pn = new PHIEUNHAP(user, pass, sever, data);
            //pn.Show();
            OpenChildForm(new PHIEUNHAP(user, pass, sever, data));
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            //NHACC ncc = new NHACC(user, pass, sever, data);
            //ncc.Show();
            OpenChildForm(new NHACC(user, pass, sever, data));
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            //NhanVien nv = new NhanVien(user, pass, sever, data);
            //nv.Show();
            OpenChildForm(new NhanVienView(user, pass, sever, data));
        }
        private void btnnhaphang_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmNhapHang(user, pass, sever, data));

          
        }
        private void btnlichca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichCa(user, pass, sever, data));
        }
        private void btnlichtruc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichTruc(user, pass, sever, data));
        }
        private void btntinhluong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TinhLuong(user, pass, sever, data));
        }
        private void btnnguyenlieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NguyenLieu(user, pass, sever, data));
        }
        private void btnchitiethh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChiTietHangHoa(user, pass, sever, data));
        }
        private void btnthongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeDoanhThu(user, pass, sever, data));
        }


        private void btnbanhang_Click(object sender, EventArgs e)
        {
            //panelkhachhang.Visible = true;
            //panelboloc.Visible = true;
            //panelbanhang.Visible = true;
            //lstbanhang.Visible = true;
            //LoadProducts();

            panelButtonBanHang.BringToFront();
            panelkhachhang.Visible = true;
            panelboloc.Visible = true;
            panelbanhang.Visible = true;
            lstbanhang.Visible = true;
            flowLayoutPanelProducts.Visible = true;
            panel8.Visible = true;
            //panelcontainer.Visible = true;

            panelMainDesktop.BringToFront();

            panelbanhang.BringToFront();
            lstbanhang.BringToFront();
            flowLayoutPanelProducts.BringToFront();
            //panelcontainer.BringToFront();

            LoadProducts();
        }
        private void btnchitietkhuyenmai_Click(object sender, EventArgs e)
        {
            //ChiTietKhuyenMai ctkm = new ChiTietKhuyenMai(user, pass, sever, data);
            //ctkm.Show();
            OpenChildForm(new ChiTietKhuyenMai(user, pass, sever, data));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ThongTinNhanVien ttnv = new ThongTinNhanVien(user, pass, sever, data);
            //ttnv.Show();
            OpenChildForm(new ThongTinNhanVien(user, pass, sever, data));
        }
        private void btnchamcong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChamCong(user, pass, sever, data));
        }
        private void txttienkhachtra_TextChanged(object sender, EventArgs e)
        {
            if (!txttienkhachtra.Text.All(char.IsDigit))
            {
                MessageBox.Show("Bạn chỉ có thể nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttienkhachtra.Text = new string(txttienkhachtra.Text.Where(char.IsDigit).ToArray());
                txttienkhachtra.SelectionStart = txttienkhachtra.TextLength;
            }
            else
            {
                if (txttienkhachtra.Text.Length == 0)
                {
                    txttienthua.Text = "";
                }
                else if (float.Parse(txttienkhachtra.Text) > total)
                {
                    txttienthua.Text = $"{(float.Parse(txttienkhachtra.Text) - total):000}đ";
                }
                else if (float.Parse(txttienkhachtra.Text) < total)
                {
                    txttienthua.Text = "Không đủ";
                }
                else txttienthua.Text = "0";
            }  
        
        }
        //private void LoadProducts()
        //{
        //    flowLayoutPanelProducts.Controls.Clear();
        //    // Giả sử có danh sách các sản phẩm
        //    List<HangHoa_DTO> products = BLL_HH.display(); // Phương thức lấy danh sách sản phẩm.

        //    // Thêm từng sản phẩm vào FlowLayoutPanel
        //    foreach (var product in products)
        //    {
        //        Panel panel = new Panel
        //        {
        //            Size = new Size(150, 210), // Kích thước mỗi sản phẩm
        //            BorderStyle = BorderStyle.FixedSingle
        //        };

        //        // Thêm ảnh sản phẩm
        //        string fileName = product.Hinh_P;
        //        //Lấy đường dẫn tới thư mục hiện tại của ứng dụng (thường là Debug hoặc Release khi chạy từ Visual Studio).
        //        string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
        //        //Lùi về một cấp để thoát khỏi thư mục Debug hoặc Release, lấy thư mục gốc của dự án.
        //        projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;

        //        // Kết hợp đường dẫn với thư mục Images
        //        string imagePath = System.IO.Path.Combine(projectDirectory, "Images", fileName);
        //        if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
        //        {
        //            //pictureBox1.Image = Image.FromFile(imagePath);            
        //        }
        //        PictureBox pictureBox = new PictureBox
        //        {
        //            Size = new Size(150, 150),
        //            Image = Image.FromFile(imagePath), // Đường dẫn ảnh sản phẩm
        //            SizeMode = PictureBoxSizeMode.StretchImage
        //        };
        //        pictureBox.Click += (sender, e) => AddToInvoice(product);
        //        panel.Controls.Add(pictureBox);

        //        // Thêm tên sản phẩm
        //        Label lblName = new Label
        //        {
        //            Text = product.TenHang_P,
        //            AutoSize = true,
        //            Location = new Point(10, 160)
        //        };
        //        lblName.Click += (sender, e) => AddToInvoice(product);
        //        panel.Controls.Add(lblName);

        //        // Thêm giá sản phẩm
        //        Label lblPrice = new Label
        //        {
        //            Text = $"Giá: {product.DonGia_P:N0} đ",
        //            AutoSize = true,
        //            Location = new Point(10, 180)
        //        };
        //        lblPrice.Click += (sender, e) => AddToInvoice(product);
        //        panel.Controls.Add(lblPrice);

        //        // Thêm sự kiện khi click vào panel
        //        panel.Click += (sender, e) => AddToInvoice(product);

        //        // Thêm panel vào FlowLayoutPanel
        //        flowLayoutPanelProducts.Controls.Add(panel);
        //    }
        //}
        private void LoadProducts()
        {
            List<HangHoa_DTO> products;
            flowLayoutPanelProducts.Controls.Clear();
            // Giả sử có danh sách các sản phẩm
            try
            {
                products = BLL_HH.display(); // Phương thức lấy danh sách sản phẩm.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi-->" + ex.Message + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thêm từng sản phẩm vào FlowLayoutPanel
            foreach (var product in products)
            {
                //Panel panel = new Panel
                //{
                //    Size = new Size(150, 230), // Tăng chiều cao để chứa thêm thông tin số lượng
                //    BorderStyle = BorderStyle.FixedSingle
                //};

                // Tạo Guna2Panel  
                Guna.UI2.WinForms.Guna2Panel panel = new Guna.UI2.WinForms.Guna2Panel
                {
                    Size = new Size(150, 220), // Kích thước panel  
                    FillColor = System.Drawing.Color.White, // Màu nền  
                    BorderColor = System.Drawing.Color.FromArgb(204, 204, 204), // Màu viền  
                    BorderRadius = 8,
                    BorderThickness = 1, // Độ dày viền  
                    Padding = new Padding(2), // Khoảng cách giữa nội dung và viền  
                    Margin = new Padding(10), // Khoảng cách giữa các panel
                                              //ShadowDecoration = { Enabled = true, Shadow = new System.Windows.Forms.Padding(5) } // Hiệu ứng bóng  
                };

                // Thêm ảnh sản phẩm
                //string fileName = product.Hinh_P;
                //string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                //projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;
                //string imagePath = System.IO.Path.Combine(projectDirectory, "Images", fileName);

                string fileName = product.Hinh_P;
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;
                string imagePath = System.IO.Path.Combine(projectDirectory, "Images", fileName);


                //PictureBox pictureBox = new PictureBox
                //{
                //    Size = new Size(150, 150),
                //    Image = Image.FromFile(imagePath), // Đường dẫn ảnh sản phẩm
                //    SizeMode = PictureBoxSizeMode.StretchImage
                //};

                Guna.UI2.WinForms.Guna2PictureBox pictureBox = new Guna.UI2.WinForms.Guna2PictureBox
                {
                    Size = new Size(140, 140),
                    Image = Image.FromFile(imagePath), // Đường dẫn ảnh sản phẩm  
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderRadius = 8,
                    Location = new Point(5, 5), // Đặt vị trí của ảnh  
                    BackColor = System.Drawing.Color.Transparent // Đặt nền trong suốt  
                };
                // Kiểm tra nếu sản phẩm có sẵn và không thể thêm vào giỏ
                bool isOutOfStock = BLL_HH.sl_ton(int.Parse(product.MaHang_P)) == 0;

                // Lớp phủ mờ khi hết hàng
                if (isOutOfStock) // Nếu sản phẩm hết hàng
                {
                    pictureBox.Enabled = false; // Tắt khả năng bấm vào ảnh
                    pictureBox.BackColor = System.Drawing.Color.Gray; // Đổi màu mờ cho ảnh

                    // Tạo lớp phủ mờ trên ảnh
                    Panel overlay = new Panel
                    {
                        Size = pictureBox.Size,
                        BackColor = System.Drawing.Color.FromArgb(128, System.Drawing.Color.Gray), // Màu xám với độ trong suốt (128) để tạo hiệu ứng mờ
                        Location = new Point(0, 0)
                    };
                    pictureBox.Controls.Add(overlay); // Thêm lớp phủ vào ảnh
                    pictureBox.Click += (sender, e) => MessageBox.Show("Sản phẩm này đã hết hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // Hiển thị thông báo khi bấm vào
                }
                else
                {
                    pictureBox.Click += (sender, e) => AddToInvoice(product); // Nếu có sẵn, bấm vào ảnh để thêm vào giỏ
                }

                panel.Controls.Add(pictureBox);

                // Thêm tên sản phẩm
                //Label lblName = new Label
                //{
                //    Text = product.TenHang_P,
                //    AutoSize = true,
                //    Location = new Point(10, 160)
                //};

                Guna.UI2.WinForms.Guna2HtmlLabel lblName = new Guna.UI2.WinForms.Guna2HtmlLabel
                {
                    Text = product.TenHang_P,
                    AutoSize = true,
                    Location = new Point(10, 150),
                    Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold) // Đặt font chữ  
                };

                if (isOutOfStock) // Nếu sản phẩm hết hàng
                {
                    lblName.Enabled = false; // Tắt khả năng bấm vào tên sản phẩm
                    lblName.ForeColor = System.Drawing.Color.Gray; // Đổi màu chữ thành màu xám
                }
                else
                {
                    lblName.Click += (sender, e) => AddToInvoice(product); // Nếu có sẵn, bấm vào tên để thêm vào giỏ
                }

                panel.Controls.Add(lblName);

                // Thêm giá sản phẩm
                //Label lblPrice = new Label
                //{
                //    Text = $"Giá: {product.DonGia_P:N0} đ",
                //    AutoSize = true,
                //    Location = new Point(10, 180)
                //};

                Guna.UI2.WinForms.Guna2HtmlLabel lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel
                {
                    Text = $"Giá: {product.DonGia_P:N0} đ",
                    AutoSize = true,
                    Location = new Point(10, 170),
                    Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular) // Đặt kích thước chữ  
                };
                if (isOutOfStock) // Nếu sản phẩm hết hàng
                {
                    lblPrice.Enabled = false; // Tắt khả năng bấm vào giá
                    lblPrice.ForeColor = System.Drawing.Color.Gray; // Đổi màu chữ thành màu xám
                }
                else
                {
                    lblPrice.Click += (sender, e) => AddToInvoice(product); // Nếu có sẵn, bấm vào giá để thêm vào giỏ
                }

                panel.Controls.Add(lblPrice);

                // Thêm số lượng sản phẩm sẵn có
                //Label lblStock = new Label
                //{
                //    Text = $"Sẵn có: {BLL_HH.sl_ton(int.Parse(product.MaHang_P)):N0}",
                //    AutoSize = true,
                //    ForeColor = isOutOfStock ? System.Drawing.Color.Gray : System.Drawing.Color.Green, // Đổi màu chữ thành xám nếu hết hàng
                //    Location = new Point(80, 210),
                //    Font = new System.Drawing.Font("Arial", 8, FontStyle.Regular), // Đặt kích thước chữ nhỏ hơn
                //    Size = new Size(30, 10) // Kích thước nhỏ hơn
                //};

                Guna.UI2.WinForms.Guna2HtmlLabel lblStock = new Guna.UI2.WinForms.Guna2HtmlLabel
                {
                    Text = $"Sẵn có: {BLL_HH.sl_ton(int.Parse(product.MaHang_P)):N0}",
                    AutoSize = true,
                    ForeColor = System.Drawing.Color.Green, // Đổi màu chữ để dễ nhìn  
                    Location = new Point(10, 190),
                    Font = new System.Drawing.Font("Arial", 8, System.Drawing.FontStyle.Bold) // Đặt kích thước chữ nhỏ hơn  
                };

                panel.Controls.Add(lblStock);

                // Thêm sự kiện khi click vào panel (cũng cần phải vô hiệu hóa khi sản phẩm hết hàng)
                panel.Click += (sender, e) =>
                {
                    if (isOutOfStock)
                    {
                        MessageBox.Show("Sản phẩm này đã hết hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        AddToInvoice(product); // Nếu có sẵn, bấm vào panel để thêm vào giỏ
                    }
                };

                // Thêm panel vào FlowLayoutPanel
                flowLayoutPanelProducts.Controls.Add(panel);
            }
        }
        //private void AddToInvoice(HangHoa_DTO product)
        //{
        //    // Kiểm tra xem sản phẩm đã có trong hóa đơn chưa
        //    foreach (ListViewItem item in lstbanhang.Items)
        //    {
        //        if (item.SubItems[1].Text == product.TenHang_P)
        //        {
        //            // Tăng số lượng sản phẩm nếu đã tồn tại trong hóa đơn
        //            item.SubItems[4].Text = (int.Parse(item.SubItems[4].Text) + 1).ToString();
        //            item.SubItems[5].Text = (int.Parse(item.SubItems[4].Text) * product.DonGia_P).ToString();
        //            UpdateTotal();
        //            return;
        //        }
        //    }

        //    // Nếu sản phẩm chưa có trong hóa đơn, thêm mới
        //    ListViewItem newItem = new ListViewItem(product.MaHang_P);  // Cột 0: Mã sản phẩm
        //    newItem.SubItems.Add(product.TenHang_P);         // Cột 1: Tên sản phẩm
        //    newItem.SubItems.Add(product.DonGia_P.ToString());         // Cột 2: Giá sản phẩm
        //    newItem.SubItems.Add("0");         // Cột 3: Khuyến mãi
        //    newItem.SubItems.Add("1");                              // Cột 4: Số lượng (Mặc định 1)
        //    newItem.SubItems.Add(product.DonGia_P.ToString());         // Cột 5: Thành tiền

        //    lstbanhang.Items.Add(newItem);
        //    UpdateTotal();  // Cập nhật tổng hóa đơn
        //}
        private void AddToInvoice(HangHoa_DTO product)
        {
            // Kiểm tra xem sản phẩm đã có trong hóa đơn chưa
            foreach (ListViewItem item in lstbanhang.Items)
            {
                // Nếu sản phẩm đã có trong giỏ hàng (dựa vào tên sản phẩm)
                if (item.SubItems[1].Text == product.TenHang_P)
                {
                    // Lấy số lượng hiện tại trong giỏ
                    int currentQuantity = int.Parse(item.SubItems[4].Text);

                    // Lấy số lượng sản phẩm còn lại trong kho
                    int availableStock = BLL_HH.sl_ton(int.Parse(product.MaHang_P));

                    // Kiểm tra nếu số lượng hiện tại cộng thêm 1 vượt quá số lượng sẵn có
                    if (currentQuantity + 1 > availableStock)
                    {
                        MessageBox.Show("Không đủ sản phẩm để thêm vào giỏ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;  // Không thêm sản phẩm vào giỏ hàng
                    }

                    // Nếu đủ, tăng số lượng sản phẩm lên
                    item.SubItems[4].Text = (currentQuantity + 1).ToString();
                    item.SubItems[5].Text = (int.Parse(item.SubItems[4].Text) * product.DonGia_P).ToString();
                    UpdateTotal();
                    return;
                }
            }

            // Nếu sản phẩm chưa có trong giỏ, thêm mới
            ListViewItem newItem = new ListViewItem(product.MaHang_P);  // Cột 0: Mã sản phẩm
            newItem.SubItems.Add(product.TenHang_P);         // Cột 1: Tên sản phẩm
            newItem.SubItems.Add(product.DonGia_P.ToString());         // Cột 2: Giá sản phẩm
            newItem.SubItems.Add("0");         // Cột 3: Khuyến mãi
            newItem.SubItems.Add("1");                              // Cột 4: Số lượng (Mặc định 1)
            newItem.SubItems.Add(product.DonGia_P.ToString());         // Cột 5: Thành tiền

            // Lấy số lượng sản phẩm trong kho
            int availableStockNew = BLL_HH.sl_ton(int.Parse(product.MaHang_P));

            // Kiểm tra nếu số lượng sản phẩm ban đầu lớn hơn số lượng sẵn có
            if (1 > availableStockNew)
            {
                MessageBox.Show("Sản phẩm này hết hàng, không thể thêm vào giỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstbanhang.Items.Add(newItem);
            UpdateTotal();  // Cập nhật tổng tiền hóa đơn
        }
        // Tính tổng tiền hóa đơn
        float total;
        private void UpdateTotal()
        {
            total = 0;
            //foreach (DataGridViewRow row in dataGridViewInvoice.Rows)
            //{
            //    total += Convert.ToInt32(row.Cells["ThanhTien"].Value);
            //}
            foreach(ListViewItem item in lstbanhang.Items)
            {
                total += float.Parse(item.SubItems[5].Text);
            }    
            lbltongtien.Text = $"{total:N0} đ";
        }
        
        private void ThanhToanHoaDon()
        {
            HoaDon hd_ma = new HoaDon(user, pass, sever, data);
            if (txttienthua.Text == "Không đủ")
            {
                MessageBox.Show("Không đủ để thanh toán hóa đơn");
            }
            else
            {
                try
                {
                    // 1. Tạo mã hóa đơn mới
                    string maHoaDon ="HD"+ DateTime.Today.ToString("ddMMyy") + string.Format("{0:000}", hd_ma.GenerateMaHoaDon());
                    string ngayLap = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    //// 2. Lưu thông tin hóa đơn vào cơ sở dữ liệu
                    BanHang_BLL BLL_BanHang=new BanHang_BLL();
                    HoaDon_DTO hd = new HoaDon_DTO(maHoaDon,ngayLap, user);
                    string kq = BLL_BanHang.luu_hd(hd);
                    if(kq=="true")
                    {
                        //MessageBox.Show("Lưu hóa đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lổi--> "+kq);
                        return;
                    }

                    // Lưu chi tiết hóa đơn vào bảng ChiTietHoaDon
                    try
                    {
                        foreach (ListViewItem item in lstbanhang.Items)
                        {
                            string masp = item.SubItems[0].Text;
                            string donGia = item.SubItems[2].Text;
                            string soLuong = item.SubItems[4].Text;

                            ChiTietHoaDon_DTO cthd = new ChiTietHoaDon_DTO(masp, soLuong, donGia);
                            BLL_BanHang.luu_cthd(cthd); 

                        }
                        //MessageBox.Show("Lưu chi tiết hóa đơn thành công");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lổi--> "+ex.Message);
                        return;
                    }
                    //Trừ nguyên liệu của bảng NguyenLieu
                    try
                    {
                        foreach (ListViewItem item in lstbanhang.Items)
                        {
                            string masp = item.SubItems[0].Text;
                            string soLuong = item.SubItems[4].Text;

                            HangHoa_DTO hh = new HangHoa_DTO(masp, soLuong);
                            BLL_BanHang.tru_nguyenlieu(hh);


                        }
                        //MessageBox.Show("Lưu chi tiết hóa đơn thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lổi--> " + ex.Message);
                        return;
                    }


                    // 3. Thông báo thanh toán thành công
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 4. Gọi chức năng in hóa đơn
                    ShowInvoicePreview(maHoaDon, ngayLap);
                    InHoaDon(maHoaDon, ngayLap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi thanh toán: " + ex.Message);
                }
            }

        }
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txttienkhachtra.Text)||(float.Parse(txttienkhachtra.Text)<total))
            {
                MessageBox.Show("Số tiền không đủ để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
            else
            {
                ThanhToanHoaDon();
                LoadProducts();
                btnhuy_Click(sender, e);
            }    
        }
        //private Bitmap GenerateInvoicePreview(string maHoaDon, string ngayLap)
        //{
        //    NhanVien_DTO nv = new NhanVien_DTO(user);
        //    // Kích thước của Bitmap (tùy chỉnh theo kích thước hóa đơn)
        //    int width = 900;
        //    int height = 1000;

        //    // Tạo Bitmap
        //    Bitmap invoiceBitmap = new Bitmap(width, height);
        //    using (Graphics g = Graphics.FromImage(invoiceBitmap))
        //    {
        //        g.Clear(System.Drawing.Color.White);

        //        // Thiết lập font chữ
        //        System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 26, FontStyle.Bold);
        //        System.Drawing.Font subTitleFont = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
        //        System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 15);

        //        // Thêm tiêu đề hóa đơn
        //        string storeTitle = "QUÁN CAFFEE";
        //        string invoiceTitle = "HÓA ĐƠN THANH TOÁN";
        //        SizeF storeTitleSize = g.MeasureString(storeTitle, subTitleFont);
        //        SizeF invoiceTitleSize = g.MeasureString(invoiceTitle, titleFont);

        //        float centerXStore = (width - storeTitleSize.Width) / 2;
        //        float centerXInvoice = (width - invoiceTitleSize.Width) / 2;

        //        g.DrawString(storeTitle, subTitleFont, Brushes.Black, new PointF(centerXStore, 20));
        //        g.DrawString(invoiceTitle, titleFont, Brushes.Black, new PointF(centerXInvoice, 50));

        //        // Thêm thông tin mã hóa đơn và ngày lập
        //        g.DrawString($"Mã hóa đơn: {maHoaDon}", contentFont, Brushes.Black, new PointF(50, 120));
        //        g.DrawString($"Ngày lập: {ngayLap}", contentFont, Brushes.Black, new PointF(width - 400, 120));
        //        g.DrawString($"Nhân viên lập: {BLL_NV.ten_nv(nv)}", contentFont, Brushes.Black, new PointF(50, 150));
        //        g.DrawString("Khách hàng vãng lai", contentFont, Brushes.Black, new PointF(50, 180));

        //        // Vẽ bảng chi tiết sản phẩm
        //        Pen blackPen = new Pen(System.Drawing.Color.Black, 1);
        //        float startX = 50;
        //        float startY = 240;
        //        float columnWidth1 = 50;  // STT
        //        float columnWidth2 = 220; // Tên Sản Phẩm
        //        float columnWidth3 = 120; // Đơn Giá
        //        float columnWidth4 = 100; // Số Lượng
        //        float columnWidth5 = 120; // Khuyến Mãi
        //        float columnWidth6 = 140; // Thành Tiền

        //        float tableWidth = columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5 + columnWidth6;

        //        // Vẽ đường viền tiêu đề
        //        g.DrawRectangle(blackPen, startX, startY, tableWidth, 30);
        //        g.DrawString("STT", contentFont, Brushes.Black, new PointF(startX + 5, startY + 5));
        //        g.DrawString("Tên Sản Phẩm", contentFont, Brushes.Black, new PointF(startX + columnWidth1 + 5, startY + 5));
        //        g.DrawString("Đơn Giá", contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + 5, startY + 5));
        //        g.DrawString("Số Lượng", contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + 5, startY + 5));
        //        g.DrawString("Khuyến Mãi", contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + 5, startY + 5));
        //        g.DrawString("Thành Tiền", contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5 + 5, startY + 5));

        //        int stt = 1;
        //        float yPos = startY + 30;

        //        // Giả sử bạn có danh sách sản phẩm
        //        foreach (ListViewItem item in lstbanhang.Items)
        //        {
        //            string tenSanPham = item.SubItems[1].Text;
        //            string donGia = item.SubItems[2].Text;
        //            string soLuong = item.SubItems[4].Text;
        //            string khuyenMai = item.SubItems[3].Text;
        //            string thanhTien = item.SubItems[5].Text;

        //            // Vẽ đường viền từng dòng
        //            g.DrawRectangle(blackPen, startX, yPos, tableWidth, 30);
        //            g.DrawString(stt.ToString(), contentFont, Brushes.Black, new PointF(startX + 5, yPos + 5));
        //            g.DrawString(tenSanPham, contentFont, Brushes.Black, new PointF(startX + columnWidth1 + 5, yPos + 5));
        //            g.DrawString(donGia, contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + 5, yPos + 5));
        //            g.DrawString(soLuong, contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + 5, yPos + 5));
        //            g.DrawString(khuyenMai, contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + 5, yPos + 5));
        //            g.DrawString(thanhTien, contentFont, Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5 + 5, yPos + 5));

        //            yPos += 30;
        //            stt++;
        //        }

        //        // Vẽ các đường kẻ dọc
        //        float currentX = startX;
        //        for (int i = 0; i <= 6; i++)
        //        {
        //            g.DrawLine(blackPen, currentX, startY, currentX, yPos); // từ startY đến yPos
        //            if (i == 0) currentX += columnWidth1;
        //            else if (i == 1) currentX += columnWidth2;
        //            else if (i == 2) currentX += columnWidth3;
        //            else if (i == 3) currentX += columnWidth4;
        //            else if (i == 4) currentX += columnWidth5;
        //            else currentX += columnWidth6;
        //        }

        //        // Tổng kết hóa đơn
        //        yPos += 20;
        //        g.DrawString($"Tổng Tiền: {total:000}đ", contentFont, Brushes.Black, new PointF(width - 350, yPos));
        //        g.DrawString($"Tiền Khách Trả: {txttienkhachtra.Text}đ", contentFont, Brushes.Black, new PointF(width - 350, yPos + 30));
        //        g.DrawString($"Tiền Thừa: {txttienthua.Text}đ", contentFont, Brushes.Black, new PointF(width - 350, yPos + 60));

        //        // Lời cảm ơn
        //        string thankYouText = "Cảm ơn quý khách đã đến quán!";
        //        SizeF textSize = g.MeasureString(thankYouText, contentFont);
        //        float centerX = (width - textSize.Width) / 2;
        //        g.DrawString(thankYouText, contentFont, Brushes.Black, new PointF(centerX, yPos + 100));
        //    }

        //    return invoiceBitmap;
        //}
        private Bitmap GenerateInvoicePreview(string maHoaDon, string ngayLap)
        {
            NhanVien_DTO nv = new NhanVien_DTO(user);
            // Kích thước của Bitmap (tùy chỉnh theo kích thước hóa đơn)
            int width = 900;
            int height = 1000;

            // Tạo Bitmap
            Bitmap invoiceBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(invoiceBitmap))
            {
                g.Clear(System.Drawing.Color.White);

                // Vẽ nội dung hóa đơn lên Bitmap
                System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 26, FontStyle.Bold);
                System.Drawing.Font subTitleFont = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
                System.Drawing.Font contentFont = new System.Drawing.Font("Arial", 15);
                System.Drawing.Font headerFont = new System.Drawing.Font("Arial", 15, FontStyle.Bold); // Font in đậm cho tiêu đề

                // Thêm tiêu đề
                string storeTitle = "CAFETERIA WORK";
                string invoiceTitle = "HÓA ĐƠN THANH TOÁN";

                SizeF storeTitleSize = g.MeasureString(storeTitle, subTitleFont);
                SizeF invoiceTitleSize = g.MeasureString(invoiceTitle, titleFont);

                float centerXStore = (width - storeTitleSize.Width) / 2;
                float centerXInvoice = (width - invoiceTitleSize.Width) / 2;

                g.DrawString(storeTitle, subTitleFont, Brushes.Black, new PointF(centerXStore, 20));
                g.DrawString(invoiceTitle, titleFont, Brushes.Black, new PointF(centerXInvoice, 50));

                // Thêm thông tin mã hóa đơn và ngày lập
                g.DrawString($"Mã hóa đơn: {maHoaDon}", contentFont, Brushes.Black, new PointF(50, 150));
                g.DrawString($"Khách hàng: khách hàng vãng lai", contentFont, Brushes.Black, new PointF(50, 200));
                g.DrawString($"Nhân viên lập: {BLL_NV.ten_nv(nv)}", contentFont, Brushes.Black, new PointF(width - 270, 200));
                g.DrawString($"Ngày lập: {ngayLap}", contentFont, Brushes.Black, new PointF(width - 270, 150));

                // Thiết lập bảng chi tiết sản phẩm
                Pen blackPen = new Pen(System.Drawing.Color.Black, 1);
                Brush grayBrush = new SolidBrush(System.Drawing.Color.LightGray); // Màu nền xám nhạt
                float startX = 50;
                float startY = 250;

                // Định nghĩa chiều rộng từng cột
                float[] columnWidths = { 50, 220, 120, 120, 130, 140 }; // STT, Tên SP, Đơn Giá, Số Lượng, Khuyến Mãi, Thành Tiền
                float tableWidth = columnWidths.Sum();

                // Vẽ nền cho hàng tiêu đề
                g.FillRectangle(grayBrush, startX, startY, tableWidth, 30);

                // Vẽ từng cột tiêu đề
                float currentX = startX;
                string[] headers = { "STT", "Tên Sản Phẩm", "Đơn Giá", "Số Lượng", "Khuyến Mãi", "Thành Tiền" };

                for (int i = 0; i < headers.Length; i++)
                {
                    g.DrawLine(blackPen, currentX, startY, currentX, startY + 30); // Đường viền cột
                    g.DrawString(headers[i], headerFont, Brushes.Black, new PointF(currentX + 5, startY + 5));
                    currentX += columnWidths[i];
                }
                g.DrawLine(blackPen, currentX, startY, currentX, startY + 30); // Đường viền cuối cột

                // Vẽ dữ liệu sản phẩm
                int stt = 1;
                float yPos = startY + 30;

                foreach (ListViewItem item in lstbanhang.Items)
                {
                    string[] values = {
                            stt.ToString(),
                            item.SubItems[1].Text,
                            item.SubItems[2].Text,
                            item.SubItems[4].Text,
                            item.SubItems[3].Text,
                            item.SubItems[5].Text
                        };

                    // Vẽ đường viền ngoài cho từng dòng
                    g.DrawRectangle(blackPen, startX, yPos, tableWidth, 30);

                    // Vẽ từng cột dữ liệu
                    currentX = startX;
                    for (int i = 0; i < values.Length; i++)
                    {
                        g.DrawLine(blackPen, currentX, yPos, currentX, yPos + 30); // Đường viền cột
                        g.DrawString(values[i], contentFont, Brushes.Black, new PointF(currentX + 5, yPos + 5));
                        currentX += columnWidths[i];
                    }
                    g.DrawLine(blackPen, currentX, yPos, currentX, yPos + 30); // Đường viền cuối cột

                    yPos += 30;
                    stt++;
                }

                // Tổng kết hóa đơn
                yPos += 20;
                g.DrawString($"Tổng tiền: {total:#,##0}đ", contentFont, Brushes.Black, new PointF(width - 350, yPos));
                g.DrawString($"Tiền khách trả: {float.Parse(txttienkhachtra.Text):#,##0}đ", contentFont, Brushes.Black, new PointF(width - 350, yPos + 30));
                g.DrawString($"Tiền thừa: {float.Parse(txttienkhachtra.Text) - total:N0}đ", contentFont, Brushes.Black, new PointF(width - 350, yPos + 60));


                // Vẽ đường thẳng trên lời cảm ơn
                float lineStartX = 50;
                float lineEndX = width - 50;
                float lineY = yPos + 150; // Vị trí ngay trên lời cảm ơn
                g.DrawLine(blackPen, lineStartX, lineY, lineEndX, lineY);

                // Lời cảm ơn
                string thankYouText = "Cảm ơn quý khách ghé thăm, hẹn gặp lại!";
                SizeF textSize = g.MeasureString(thankYouText, contentFont);
                float centerX = (width - textSize.Width) / 2;
                g.DrawString(thankYouText, contentFont, Brushes.Black, new PointF(centerX, yPos + 160));
            }

            return invoiceBitmap;
        }
        private void ShowInvoicePreview(string maHoaDon, string ngayLap)
        {
            Bitmap invoiceBitmap = GenerateInvoicePreview(maHoaDon, ngayLap);
            frmPrintPreview previewForm = new frmPrintPreview(invoiceBitmap);
            previewForm.ShowDialog();
        }
        //private void InHoaDon(string maHoaDon, string ngayLap)
        //{
        //    PrintDocument printDocument = new PrintDocument();
        //    printDocument.PrintPage += (sender, e) => printDocument_PrintPage(sender, e, maHoaDon, ngayLap);

        //    PrintDialog printDialog = new PrintDialog();
        //    printDialog.Document = printDocument;

        //    if (printDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        printDocument.Print();
        //    }
        //}
        private void InHoaDon(string maHoaDon, string ngayLap)
        {
            // Mở hộp thoại SaveFileDialog để chọn vị trí và tên file
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf"; // Chỉ hiển thị file PDF
                saveFileDialog.DefaultExt = "pdf"; // Định dạng mặc định là PDF
                saveFileDialog.FileName = $"{maHoaDon}.pdf"; // Gợi ý tên file mặc định

                // Kiểm tra nếu người dùng chọn một đường dẫn hợp lệ
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName; // Lấy đường dẫn và tên file người dùng chọn

                    // Tạo đối tượng PrintDocument
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += (sender, e) => printDocument_PrintPage(sender, e, maHoaDon, ngayLap);

                    // Thiết lập máy in "Microsoft Print to PDF"
                    printDocument.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                    printDocument.PrinterSettings.PrintFileName = filePath; // Đường dẫn file lưu
                    printDocument.PrinterSettings.PrintToFile = true;       // Bật chế độ in ra file

                    try
                    {
                        // Tiến hành in
                        printDocument.Print();

                        // Thông báo sau khi lưu
                        MessageBox.Show($"Lưu hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu có
                        MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e, string mapn, string ngayLap)
        {
            // Tạo hóa đơn dưới dạng Bitmap
            Bitmap invoiceBitmap = GenerateInvoicePreview(mapn, ngayLap);

            // Vẽ Bitmap lên giấy in
            e.Graphics.DrawImage(invoiceBitmap, e.MarginBounds);

            // Nếu nội dung vượt quá một trang, bạn có thể thiết lập giá trị e.HasMorePages = true
            // để tiếp tục in trên trang kế tiếp
            // Ví dụ:
            // e.HasMorePages = false; // Đặt false nếu chỉ in một trang
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txttentimkiem.Clear();
            LoadProducts();
        }
        public void timkiemsp_theoten()
        {
            flowLayoutPanelProducts.Controls.Clear();
            // Giả sử có danh sách các sản phẩm
            List<HangHoa_DTO> products = BLL_HH.search(txttentimkiem.Text, cbogiadau.Text, cbogiacuoi.Text); // Phương thức lấy danh sách sản phẩm.

            // Thêm từng sản phẩm vào FlowLayoutPanel
            foreach (var product in products)
            {
                Panel panel = new Panel
                {
                    Size = new Size(150, 200), // Kích thước mỗi sản phẩm
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Thêm ảnh sản phẩm
                string fileName = product.Hinh_P;
                //Lấy đường dẫn tới thư mục hiện tại của ứng dụng (thường là Debug hoặc Release khi chạy từ Visual Studio).
                string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
                //Lùi về một cấp để thoát khỏi thư mục Debug hoặc Release, lấy thư mục gốc của dự án.
                projectDirectory = System.IO.Directory.GetParent(projectDirectory).Parent.Parent.FullName;

                // Kết hợp đường dẫn với thư mục Images
                string imagePath = System.IO.Path.Combine(projectDirectory, "Images", fileName);
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                {
                    //pictureBox1.Image = Image.FromFile(imagePath);
                }
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(150, 150),
                    Image = Image.FromFile(imagePath), // Đường dẫn ảnh sản phẩm
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                pictureBox.Click += (sender, e) => AddToInvoice(product);
                panel.Controls.Add(pictureBox);

                // Thêm tên sản phẩm
                Label lblName = new Label
                {
                    Text = product.TenHang_P,
                    AutoSize = true,
                    Location = new Point(10, 160)
                };
                lblName.Click += (sender, e) => AddToInvoice(product);
                panel.Controls.Add(lblName);

                // Thêm giá sản phẩm
                Label lblPrice = new Label
                {
                    Text = $"Giá: {product.DonGia_P:N0} đ",
                    AutoSize = true,
                    Location = new Point(10, 180)
                };
                lblPrice.Click += (sender, e) => AddToInvoice(product);
                panel.Controls.Add(lblPrice);

                // Thêm sự kiện khi click vào panel
                panel.Click += (sender, e) => AddToInvoice(product);

                // Thêm panel vào FlowLayoutPanel
                flowLayoutPanelProducts.Controls.Add(panel);
            }
        }
        private void btnapdung_Click(object sender, EventArgs e)
        {
            timkiemsp_theoten();

        }

        private void cbogiadau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbogiacuoi.Text!="" && float.Parse(cbogiadau.Text)>float.Parse(cbogiacuoi.Text))
            {
                MessageBox.Show("Giá đầu không được lớn hơn giá cuối");
                cbogiadau.SelectedIndex = 0;
            }
        }

        private void cbogiacuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbogiadau.Text != "" && float.Parse(cbogiadau.Text) > float.Parse(cbogiacuoi.Text))
            {
                MessageBox.Show("Giá cuối không được nhỏ hơn giá giá đầu");
                cbogiacuoi.SelectedIndex = 0;
            }
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private void printDocument_PrintPage(object sender, PrintPageEventArgs e, string maHoaDon, string ngayLap)
        //{
        //    NhanVien_DTO nv = new NhanVien_DTO(user);
        //    // Phông chữ tiêu đề
        //    System.Drawing.Font titleFont = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
        //    System.Drawing.Font subTitleFont = new System.Drawing.Font("Arial", 10, FontStyle.Regular);

        //    // Nội dung tiêu đề
        //    string storeTitle = "QUÁN CAFFEE";
        //    string invoiceTitle = "HÓA ĐƠN THANH TOÁN";

        //    // Tính toán chiều rộng của tiêu đề để căn giữa
        //    SizeF storeTitleSize = e.Graphics.MeasureString(storeTitle, subTitleFont);
        //    SizeF invoiceTitleSize = e.Graphics.MeasureString(invoiceTitle, titleFont);

        //    // Tính tọa độ x để căn giữa tiêu đề
        //    float centerXStore = (e.PageBounds.Width - storeTitleSize.Width) / 2;
        //    float centerXInvoice = (e.PageBounds.Width - invoiceTitleSize.Width) / 2;

        //    // Vẽ tiêu đề
        //    e.Graphics.DrawString(storeTitle, subTitleFont, Brushes.Black, new PointF(centerXStore, 20));
        //    e.Graphics.DrawString(invoiceTitle, titleFont, Brushes.Black, new PointF(centerXInvoice, 50));

        //    // Phần còn lại không thay đổi
        //    e.Graphics.DrawString($"Mã hóa đơn: {maHoaDon}", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(50, 120));
        //    // Nội dung ngày lập
        //    string ngayLapString = $"Ngày lập: {ngayLap}";
        //    SizeF ngayLapSize = e.Graphics.MeasureString(ngayLapString, new System.Drawing.Font("Arial", 12));
        //    float rightXNgayLap = e.PageBounds.Width - ngayLapSize.Width - 50; // 50 là phần đệm bên phải
        //    e.Graphics.DrawString(ngayLapString, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(rightXNgayLap, 120));
        //    e.Graphics.DrawString($"Nhân viên lập: {BLL_NV.ten_nv(nv)}", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(50, 150));
        //    e.Graphics.DrawString("Khách hàng vãng lai", new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(50, 180));

        //    // Vẽ đường viền và tiêu đề bảng chi tiết sản phẩm
        //    Pen blackPen = new Pen(System.Drawing.Color.Black, 1);
        //    float startX = 50;
        //    float startY = 240;
        //    float columnWidth1 = 50;  // Chiều rộng cột STT
        //    float columnWidth2 = 220; // Chiều rộng cột Tên Sản Phẩm
        //    float columnWidth3 = 120; // Chiều rộng cột Đơn Giá
        //    float columnWidth4 = 120; // Chiều rộng cột Số Lượng
        //    float columnWidth5 = 120; // Chiều rộng cột Khuyến Mãi
        //    float columnWidth6 = 120; // Chiều rộng cột Thành Tiền

        //    // Vẽ các đường ngang tiêu đề bảng
        //    e.Graphics.DrawRectangle(blackPen, startX, startY, columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5 + columnWidth6, 30);
        //    e.Graphics.DrawString("STT", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX + 5, startY + 5));
        //    e.Graphics.DrawString("Tên Sản Phẩm", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX + columnWidth1 + 5, startY + 5));
        //    e.Graphics.DrawString("Đơn Giá", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + 5, startY + 5));
        //    e.Graphics.DrawString("Số Lượng", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + 5, startY + 5));
        //    e.Graphics.DrawString("Khuyến Mãi", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + 5, startY + 5));
        //    e.Graphics.DrawString("Thành Tiền", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5 + 5, startY + 5));

        //    int stt = 1;
        //    // Vẽ các đường dọc phân chia cột
        //    float yPos = startY + 30;
        //    foreach (ListViewItem item in lstbanhang.Items)
        //    {
        //        string tenSanPham = item.SubItems[1].Text;
        //        string donGia = string.Format("{0:000}đ", double.Parse(item.SubItems[2].Text));
        //        string soLuong = item.SubItems[4].Text;
        //        string khuyenMai = item.SubItems[3].Text;
        //        string thanhTien = string.Format("{0:000}đ", double.Parse(item.SubItems[5].Text));

        //        // Vẽ đường viền cho từng dòng chi tiết
        //        e.Graphics.DrawRectangle(blackPen, startX, yPos, columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5 + columnWidth6, 30);
        //        e.Graphics.DrawString(stt.ToString(), new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(startX + 5, yPos + 5));
        //        e.Graphics.DrawString(tenSanPham, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(startX + columnWidth1 + 5, yPos + 5));
        //        e.Graphics.DrawString(donGia, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + 5, yPos + 5));
        //        e.Graphics.DrawString(soLuong, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + 5, yPos + 5));
        //        e.Graphics.DrawString(khuyenMai, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + 5, yPos + 5));
        //        e.Graphics.DrawString(thanhTien, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5 + 5, yPos + 5));

        //        // Vẽ các đường dọc
        //        e.Graphics.DrawLine(blackPen, startX + columnWidth1, startY, startX + columnWidth1, yPos + 30);
        //        e.Graphics.DrawLine(blackPen, startX + columnWidth1 + columnWidth2, startY, startX + columnWidth1 + columnWidth2, yPos + 30);
        //        e.Graphics.DrawLine(blackPen, startX + columnWidth1 + columnWidth2 + columnWidth3, startY, startX + columnWidth1 + columnWidth2 + columnWidth3, yPos + 30);
        //        e.Graphics.DrawLine(blackPen, startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4, startY, startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4, yPos + 30);
        //        e.Graphics.DrawLine(blackPen, startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5, startY, startX + columnWidth1 + columnWidth2 + columnWidth3 + columnWidth4 + columnWidth5, yPos + 30);

        //        yPos += 30;
        //        stt++;
        //    }

        //    // Tổng kết hóa đơn
        //    yPos += 20;
        //    // Tính toán vị trí x để căn phải cho Tổng Tiền
        //    string totalString = $"Tổng Tiền: {total:000}đ";
        //    SizeF totalSize = e.Graphics.MeasureString(totalString, new System.Drawing.Font("Arial", 12));
        //    float rightX = e.PageBounds.Width - totalSize.Width - 50; // 50 là phần đệm bên phải
        //    e.Graphics.DrawString(totalString, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(rightX, yPos));

        //    // Tính toán vị trí x để căn phải cho Tiền Khách Trả
        //    string tienKhachTraString = $"Tiền Khách Trả: {float.Parse(txttienkhachtra.Text):N0}đ";
        //    SizeF tienKhachTraSize = e.Graphics.MeasureString(tienKhachTraString, new System.Drawing.Font("Arial", 12));
        //    rightX = e.PageBounds.Width - tienKhachTraSize.Width - 50;
        //    e.Graphics.DrawString(tienKhachTraString, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(rightX, yPos + 30));

        //    // Tính toán vị trí x để căn phải cho Tiền Thừa
        //    string tienThuaString = $"Tiền Thừa: {float.Parse(txttienkhachtra.Text) - total:N0}đ";
        //    SizeF tienThuaSize = e.Graphics.MeasureString(tienThuaString, new System.Drawing.Font("Arial", 12));
        //    rightX = e.PageBounds.Width - tienThuaSize.Width - 50;
        //    e.Graphics.DrawString(tienThuaString, new System.Drawing.Font("Arial", 12), Brushes.Black, new PointF(rightX, yPos + 60));

        //    // Lời cảm ơn căn giữa
        //    string thankYouText = "Cảm ơn quý khách đã đến!";
        //    SizeF textSize = e.Graphics.MeasureString(thankYouText, new System.Drawing.Font("Arial", 11, FontStyle.Italic));
        //    float centerX = (e.PageBounds.Width - textSize.Width) / 2;
        //    e.Graphics.DrawString(thankYouText, new System.Drawing.Font("Arial", 12, FontStyle.Italic), Brushes.Black, new PointF(centerX, yPos + 100));
        //}

 


        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            //frmPhanQuyen frm = new frmPhanQuyen();
            //frm.ShowDialog();
            OpenChildForm(new frmPhanQuyen(user, pass, sever, data));
        }



        private void lstbanhang_Click(object sender, EventArgs e)
        {
            txtmasp.Text = lstbanhang.SelectedItems[0].SubItems[0].Text;
            txttensp.Text = lstbanhang.SelectedItems[0].SubItems[1].Text;
            txtsl.Text = lstbanhang.SelectedItems[0].SubItems[4].Text;
        }

        private void AppForAdmin_Load(object sender, EventArgs e)
        {
            lstbanhang.ContextMenuStrip = contextMenuStrip1;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstbanhang.Items)
            {
                if (item.SubItems[0].Text == txtmasp.Text)
                {
                    lstbanhang.Items.Remove(item);
                }
            }
            UpdateTotal();
        }

        //private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (ListViewItem item in lstbanhang.Items)
        //    {
        //        if (item.SubItems[0].Text == txtmasp.Text)
        //        {
        //            item.SubItems[4].Text = txtsl.Text;
        //            item.SubItems[5].Text = (float.Parse(item.SubItems[2].Text) * int.Parse(txtsl.Text)).ToString();
        //        }
        //    }
        //    UpdateTotal();
        //}
        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstbanhang.Items)
            {
                if (item.SubItems[0].Text == txtmasp.Text)
                {
                    if (int.Parse(txtsl.Text) > BLL_HH.sl_ton(int.Parse(txtmasp.Text)))
                    {
                        MessageBox.Show("Số lượng không đủ để đáp ứng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    item.SubItems[4].Text = txtsl.Text;
                    item.SubItems[5].Text = (float.Parse(item.SubItems[2].Text) * int.Parse(txtsl.Text)).ToString();
                }
            }
            UpdateTotal();
        }

        private void lstbanhang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsl_TextChanged(object sender, EventArgs e)
        {
            if (!txtsl.Text.All(char.IsDigit))
            {
                MessageBox.Show("Bạn chỉ có thể nhập số nguyên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsl.Text = new string(txtsl.Text.Where(char.IsDigit).ToArray());
                txtsl.SelectionStart = txtsl.TextLength;
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            total = 0;
            lstbanhang.Items.Clear();
            txttienkhachtra.Clear();
            txttienthua.Clear();
            lbltongtien.Text = "";
            txtmasp.Clear();
            txtsl.Clear();
            txttensp.Clear();
        }


        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainDesktop.Controls.Add(childForm);
            panelMainDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
