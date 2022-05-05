using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;

namespace WageSys.Edit
{
    public partial class EditBank : Form
    {
        Model1 db = new Model1();

        public EditBank()
        {
            InitializeComponent();

            var deg = from p in db.Banks
                      select new
                      {
                          bankI_d = p.bankId,
                          main_Bank = p.mainBank == null ? "" : p.mainBank,
                          branc_hBank = p.branchBank == null ? "" : p.branchBank,
                      };
            dataGridView1.DataSource = deg.Distinct().ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم المصرف الرئيسي ";
            dataGridView1.Columns[2].HeaderText = "اسم الفرع  ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bk = new Bank
            {
                bankId=int.Parse(textBox1.Text),
                mainBank = txtbankName.Text,
                branchBank= textBox2.Text
            };
            db.Banks.AddOrUpdate(bk);
            db.SaveChanges();
            MessageBox.Show("تم التعديل");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtbankName.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var deleteddegree = (from dege in db.Banks
                                 where dege.bankId == id
                                 select dege).Single();

            db.Banks.Remove(deleteddegree);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void EditBank_Load(object sender, EventArgs e)
        {

        }
        private void txtbankName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
    }
}
