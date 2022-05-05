using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WageSys.ShowAll
{
    public partial class ShowDegree : Form
    {
        Model1 db = new Model1();

        public ShowDegree()
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

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {

                var bind = (from p in db.EmployeeDegreees
                            orderby p.degreeId ascending
                            group p by new
                            {
                                degree_Id = p.degreeId,
                                degree_Number = p.degreeNumber == null ? "" : p.degreeNumber,
                                degree_Amount = p.degreeAmount == null ? 0 : p.degreeAmount,
                                bouns_Number = p.bounsNumber == null ? 0 : p.bounsNumber

                            } into res
                            select res.Key).Distinct().ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.EmployeeDegreees
                            where p.degreeNumber.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower()) ||
                            p.bounsNumber.ToString().ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.degreeId ascending
                            group p by new
                            {
                                degree_Id = p.degreeId,
                                degree_Number = p.degreeNumber == null ? "" : p.degreeNumber,
                                degree_Amount = p.degreeAmount == null ? 0 : p.degreeAmount,
                                bouns_Number = p.bounsNumber == null ? 0 : p.bounsNumber
                            } into res
                            select res.Key).Distinct().ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }
    }
}
