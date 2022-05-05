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
    public partial class EditBranch : Form
    {
        Model1 db = new Model1();

        public EditBranch()
        {
            InitializeComponent();

            var emplpy = (from c in db.Banks
                          select new { c.mainBank, c.bankId }).ToList();
            comboBox1.DataSource = emplpy.ToList();
            comboBox1.DisplayMember = "mainBank";
            comboBox1.ValueMember = "bankId";

            var deg = from p in db.Branches
                      select new
                      {
                          bankI_d = p.branchId,
                          main_Bank = p.branchName == null ? "" : p.branchName,
                          b_Bank = p.Bank.mainBank == null ? "": p.Bank.mainBank,
                      };
            dataGridView1.DataSource = deg.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم المصرف الفرعي ";
            dataGridView1.Columns[2].HeaderText = "اسم المصرف الرئيسي ";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtbankName.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic main = comboBox1.SelectedValue;

            var bk = new Branch
            {
                branchId=int.Parse(textBox1.Text),
                branchName = string.IsNullOrEmpty(txtbankName.Text) ? null : txtbankName.Text,
                bankId = main

            };
            db.Branches.AddOrUpdate(bk);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var deleteddegree = (from dege in db.Branches
                                 where dege.branchId == id
                                 select dege).Single();

            db.Branches.Remove(deleteddegree);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");

        }

        private void EditBranch_Load(object sender, EventArgs e)
        {

        }
    }
}
