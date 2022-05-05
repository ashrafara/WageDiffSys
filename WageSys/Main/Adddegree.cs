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
    public partial class Adddegree : Form
    {
        Model1 db = new Model1();

        public Adddegree()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var degree = new EmployeeDegreee
            {
                degreeNumber = string.IsNullOrEmpty(txtdegreeNo.Text) ? "" : (txtdegreeNo.Text),
                degreeAmount = Convert.ToDouble(txtdegreecost.Text) * 1000 / 1000,
                bounsNumber = string.IsNullOrEmpty(txtbounsCost.Text) ? (double?)0 : double.Parse(txtbounsCost.Text) * 1000 / 1000
            };
            db.EmployeeDegreees.Add(degree);
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
