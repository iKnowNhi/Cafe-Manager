using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DEAN_SQL
{
    public partial class ChiTietHangHoa : Form
    {
        ChiTietHangHoa_BLL BLL = new ChiTietHangHoa_BLL();

        public string user, pass, server, data, connectionString;
        public ChiTietHangHoa(string username, string password, string servername, string database)
        {
            InitializeComponent();
            user = username;
            pass = password;
            server = servername;
            data = database;
            Login_DTO login = new Login_DTO(username, password, servername, database);
            BLL.login(login);
        }

        private void lst_dl_Click(object sender, EventArgs e)
        {
            cbomahg.SelectedValue = lst_dl.SelectedItems[0].SubItems[0].Text;
            cbomanl.SelectedValue = lst_dl.SelectedItems[0].SubItems[1].Text;          
            txtsoluong.Text = lst_dl.SelectedItems[0].SubItems[2].Text;
            txtdvt.Text = lst_dl.SelectedItems[0].SubItems[3].Text;
        }


        public void load_mahang()
        {
            try
            {
                cbomahg.DataSource = BLL.getall_mahang();
                cbomahg.DisplayMember = "TenHang_P";
                cbomahg.ValueMember = "MaHang_P";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lổi--> " + ex.Message);
            }

        }


        public void load_manguyenlieu()
        {
            try
            {
                cbomanl.DataSource = BLL.getall_manguyenlieu();
                cbomanl.DisplayMember = "TenNL_P";
                cbomanl.ValueMember = "MaNL_P";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lổi--> " + ex.Message);
            }

        }



        public void display()
        {
            try
            {
                foreach (ChiTietHangHoa_DTO cthh in BLL.display())
                {
                    ListViewItem item = new ListViewItem(cthh.MaHG_P);
                    item.SubItems.Add(cthh.MaNL_P);
                    item.SubItems.Add(cthh.SL_P);
                    item.SubItems.Add(cthh.DVT_P);
                    lst_dl.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lổi--> " + ex.Message);
            }

        }



        private void ChiTietHangHoa_Load(object sender, EventArgs e)
        {
            load_mahang();
            display();
            load_manguyenlieu();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (cbomahg.Text != "")
            {
                try
                {
                    ChiTietHangHoa_DTO cthh = new ChiTietHangHoa_DTO(cbomahg.SelectedValue.ToString(), cbomanl.SelectedValue.ToString(), txtsoluong.Text, txtdvt.Text);
                    string kq = BLL.them(cthh);
                    if (kq == "true")
                    {
                        lst_dl.Items.Clear();
                        display();
                    }
                    else
                    {
                        MessageBox.Show("Lổi-->" + kq + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã hóa đơn không được đễ trống", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietHangHoa_DTO cthh = new ChiTietHangHoa_DTO(cbomahg.SelectedValue.ToString(), cbomanl.SelectedValue.ToString(), txtsoluong.Text, txtdvt.Text);
                bool kq = BLL.xoa(cthh);
                if (kq == true)
                {
                    lst_dl.Items.Clear();
                    BLL.xoa(cthh);
                    display();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            ListViewItem item = lst_dl.FocusedItem;
            try
            {
                ChiTietHangHoa_DTO cthh = new ChiTietHangHoa_DTO(cbomahg.SelectedValue.ToString(), cbomanl.SelectedValue.ToString(), txtsoluong.Text, txtdvt.Text, item.SubItems[0].Text.Trim(), item.SubItems[1].Text.Trim());
                string kq = BLL.sua(cthh);
                if (kq == "true")
                {
                    lst_dl.Items.Clear();
                    display();
                }
                else
                {
                    MessageBox.Show("Lổi-->" + kq + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdvt.Clear();
            txtsoluong.Clear();
        }

    }
}
