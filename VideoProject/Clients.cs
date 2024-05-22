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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.видеоПрокатDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "видеоПрокатDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.видеоПрокатDataSet.Клиенты);

        }

        private void дата_взятияLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            клиентыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.видеоПрокатDataSet);
        }
    }
}
