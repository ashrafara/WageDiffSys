using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageSys.Main
{
    public partial class Addbranch : Form
    {
        Model1 db = new Model1();

        public Addbranch()
        {
            InitializeComponent();

            var emplpy = (from c in db.Banks
                          select new { c.mainBank, c.bankId }).ToList();
            comboBox1.DataSource = emplpy.ToList();
            comboBox1.DisplayMember = "mainBank";
            comboBox1.ValueMember = "bankId";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dynamic main = comboBox1.SelectedValue;

            var bk = new Branch
            {
                branchName = string.IsNullOrEmpty(txtbankName.Text) ? null : txtbankName.Text,
                bankId=main 
            };
            db.Branches.Add(bk);
            db.SaveChanges();
            MessageBox.Show("تم الاضافة");
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
