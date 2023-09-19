using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace onclassweek5BT
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.TopMost = true;
            f2.Dock = DockStyle.Right;
            List<Student> students;
            f2.Show();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.MdiParent = this;
            f2.TopMost = true;
            f2.Dock = DockStyle.Right;
            List<Student> students;
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void SetDataFromForm2(string dataMSSV, string dataHoTen, string dataDTB, string dataKhoa)
        { 
            students.Add(new Student() { MSSV = dataMSSV, HoTen = dataHoTen, DTB = Convert.ToDouble(dataDTB), Khoa = dataKhoa });
            var source = new BindingSource(students, null);
            dgvData.DataSource = source;

        }
        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void tstbFind_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tstbFind_Enter(object sender, EventArgs e)
        {
        }

        private void tslFind_Click(object sender, EventArgs e)
        {
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chucNangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
