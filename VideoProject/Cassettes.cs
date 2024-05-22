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
    public partial class Cassettes : Form
    {
        public Cassettes()
        {
            InitializeComponent();
        }

        private void кассетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.кассетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.видеоПрокатDataSet);

        }

        private void Cassettes_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "видеоПрокатDataSet.Кассеты". При необходимости она может быть перемещена или удалена.
            this.кассетыTableAdapter.Fill(this.видеоПрокатDataSet.Кассеты);

        }
    }
}
