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
    public partial class Programari : Form
    {
        public Programari()
        {
            InitializeComponent();
        }

        private void Programari_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mFdbDataSet1.Progrmari' table. You can move, or remove it, as needed.
            this.progrmariTableAdapter.Fill(this.mFdbDataSet1.Progrmari);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            this.progrmariTableAdapter.Fill(this.mFdbDataSet1.Progrmari);
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            BazaDeDateMF dbmenu = new BazaDeDateMF();
            this.Hide();
            dbmenu.Closed += (s, args) => this.Close();
            dbmenu.Show();
        }
    }
}
