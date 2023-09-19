using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static onclassweek5BT.Form1;


namespace onclassweek5BT
{
    public partial class Form2 : Form
    {
        public string mssv { get; set; }
        public string hoten { get; set; }
        public double dtb { get; set; }
        public string khoa { get; set; }

        System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["Form1"];
        
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbmKhoa.SelectedIndex = 0;
            cbmKhoa.DisplayMember = "Khoa";
        }
       

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.txtMSSV.Text) ||
            string.IsNullOrWhiteSpace(this.txtHoTen.Text) ||
            string.IsNullOrWhiteSpace(this.txtDTB.Text) ||
            string.IsNullOrWhiteSpace((string)cbmKhoa.SelectedItem))
            {
                MessageBox.Show("Hay nhap day du thong tin!");
                return;
            }
            if (double.Parse(this.txtDTB.Text) >= 0 && double.Parse(this.txtDTB.Text) <= 10)
            {
                if (this.MdiParent is Form1 mdiParentForm)
                {
                    string dataMSSV = txtMSSV.Text;
                    string dataHoTen = txtHoTen.Text;
                    string dataDTB = txtDTB.Text;
                    string dataKhoa = cbmKhoa.Text;
                    mdiParentForm.SetDataFromForm2(dataMSSV, dataHoTen, dataDTB, dataKhoa);
                }
            }
            else
            {
                MessageBox.Show("Hay nhap diem tu 0 - 10!");
                txtDTB.Focus();
            }
        }
        private void SendDataToForm1Button_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbmKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
