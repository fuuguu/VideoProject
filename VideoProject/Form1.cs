using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Posts pf = new Posts();
            pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Genres gf = new Genres();
            gf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cassettes cf = new Cassettes();
            cf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clients clf = new Clients();
            clf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Members ms = new Members();
            ms.Show();
        }
    }
}
