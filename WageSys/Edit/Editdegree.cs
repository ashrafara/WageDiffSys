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
    public partial class Editdegree : Form
    {
        Model1 db = new Model1();

        public Editdegree()
        {
            InitializeComponent();

            var deg = from p in db.EmployeeDegreees
                      select new
                      {
                          degree_Id = p.degreeId,
                          degree_Number = p.degreeNumber == null ? "" : p.degreeNumber,
                          degree_Amount = p.degreeAmount == null ? 0 : p.degreeAmount,
                          bouns_Number = p.bounsNumber == null ? 0 : p.bounsNumber
                      };
            dataGridView1.DataSource = deg.ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "الدرجة الوظيفية ";
            dataGridView1.Columns[2].HeaderText = "قيمة الدرجة الوظيفية";
            dataGridView1.Columns[3].HeaderText = "قيمة العلاوة السنوية ";

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var degree = new EmployeeDegreee
            {
                degreeId=int.Parse(textBox1.Text),
                degreeNumber =  (txtdegreeNo.Text),
                degreeAmount = Convert.ToDouble(txtdegreecost.Text),
                bounsNumber =  Convert.ToDouble(txtbounsCost.Text)
            };
            db.EmployeeDegreees.AddOrUpdate(degree);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                txtdegreeNo.Text = row.Cells[1].Value.ToString();
                txtdegreecost.Text = row.Cells[2].Value.ToString();
                txtbounsCost.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);

            var deleteddegree = (from dege in db.EmployeeDegreees
                                 where dege.degreeId == id
                                 select dege).Single();

            db.EmployeeDegreees.Remove(deleteddegree);
            db.SaveChanges();
            MessageBox.Show("تم الحذف");
        }

        private void Editdegree_Load(object sender, EventArgs e)
        {

        }
        private void txtdegreecost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtdegreecost.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtbounsCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtbounsCost.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
