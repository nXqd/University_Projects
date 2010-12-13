using System;
using System.Windows.Forms;

using DTO;
using BUS;

namespace QLNS
{
    public partial class ThayDoiThamSo : Form
    {
        public ThayDoiThamSo()
        {
            InitializeComponent();
        }

        private void Label5Click(object sender, EventArgs e)
        {

        }

        private void Button2Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThayDoiThamSo_Load(object sender, EventArgs e)
        {
            // Display all information
            var thamSos = ThamSoBUS.GetAll();
            txtNo.Text = thamSos.NoLN.ToString();
            txtNhapNN.Text = thamSos.SoLuongNhapNN.ToString();
            txtTonLN.Text = thamSos.LuongTonLN.ToString();
            txtTonNN.Text = thamSos.LuongTonNN.ToString();
            chkChoTraDu.Checked = thamSos.ChoTraDu;

        }

        private void Button1Click(object sender, EventArgs e)
        {
            // Get all information and update
            try
            {
                var thamSos = new ThamSoDTO
                {
                    ChoTraDu = chkChoTraDu.Checked,
                    LuongTonLN = int.Parse(txtTonLN.Text),
                    LuongTonNN = int.Parse(txtTonNN.Text),
                    NoLN = decimal.Parse(txtNo.Text),
                    SoLuongNhapNN = int.Parse(txtNhapNN.Text)
                };
                ThamSoBUS.UpdateAll(thamSos);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Bạn đã nhập sai đơn vị các giá trị!");
                throw;
            }

        }

        private void TextBox5TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2TextChanged(object sender, EventArgs e)
        {

        }
    }
}
