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
    public partial class Furnizori : Form
    {
        public Furnizori()
        {
            InitializeComponent();
        }

        private void Furnizori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mFdbDataSet1.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.mFdbDataSet1.Furnizori);

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
            this.furnizoriTableAdapter.Fill(this.mFdbDataSet1.Furnizori);
        }
    }
}
