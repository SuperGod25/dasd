using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestiune_Coafor
{
    public partial class Marfa : Form
    {
        public Marfa()
        {
            InitializeComponent();
        }

        private void Marfa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mFdbDataSet2.Marfa' table. You can move, or remove it, as needed.
            this.marfaTableAdapter1.Fill(this.mFdbDataSet2.Marfa);
            
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BazaDeDateMF dbmenu = new BazaDeDateMF();
            this.Hide();
            dbmenu.Closed += (s, args) => this.Close();
            dbmenu.Show();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            this.marfaTableAdapter1.Fill(this.mFdbDataSet2.Marfa);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void finalContract_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pretBuc_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void furnizor_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantitate_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeProdus_txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void d_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
