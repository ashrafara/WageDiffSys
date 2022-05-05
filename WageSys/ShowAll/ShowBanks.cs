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
    public partial class ShowBanks : Form
    {
        Model1 db = new Model1();

        public ShowBanks()
        {
            InitializeComponent();

            var deg = from p in db.Banks
                      select new
                      {
                          bankI_d = p.bankId,
                          main_Bank = p.mainBank == null ? "" : p.mainBank,
                          branc_hBank = p.branchBank == null ? "" : p.branchBank
                      };
            dataGridView1.DataSource = deg.Distinct().ToList();
            dataGridView1.Columns[0].HeaderText = "ر.م";
            dataGridView1.Columns[1].HeaderText = "اسم المصرف الرئيسي ";
            dataGridView1.Columns[2].HeaderText = "اسم الفرع  ";
        }

        private void ShowBanks_Load(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.ToString() == "")
            {

                var bind = (from p in db.Banks
                            orderby p.bankId ascending
                            group p by new
                            {
                                bankI_d = p.bankId,
                                main_Bank = p.mainBank == null ? "" : p.mainBank,
                                branc_hBank = p.branchBank == null ? "" : p.branchBank

                            } into res
                            select res.Key).Distinct().ToList();
                dataGridView1.DataSource = bind.ToList();
            }
            else
            {
                var bind = (from p in db.Banks
                            where p.mainBank.ToLower().Contains(txt_search.Text.ToString().ToLower()) ||
                            p.branchBank.ToLower().Contains(txt_search.Text.ToString().ToLower())
                            orderby p.bankId ascending
                            group p by new
                            {
                                bankI_d = p.bankId,
                                main_Bank = p.mainBank == null ? "" : p.mainBank,
                                branc_hBank = p.branchBank == null ? "" : p.branchBank
                            } into res
                            select res.Key).Distinct().ToList();
                dataGridView1.DataSource = bind.ToList();
            }
        }
    }
}
