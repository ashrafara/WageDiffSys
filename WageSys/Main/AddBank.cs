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
    public partial class AddBank : Form
    {
        Model1 db = new Model1();

        public AddBank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bk = new Bank
            {
                mainBank = string.IsNullOrEmpty(txtbankName.Text) ? "" : txtbankName.Text.Trim(),
                branchBank= string.IsNullOrEmpty(textBox1.Text) ? "" : textBox1.Text.Trim()

            };
            db.Banks.Add(bk);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbankName_TextChanged(object sender, EventArgs e)
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
