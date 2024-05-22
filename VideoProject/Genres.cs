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
    public partial class Genres : Form
    {
        public Genres()
        {
            InitializeComponent();
        }

        private void жанрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.жанрыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.видеоПрокатDataSet);

        }

        private void Genres_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "видеоПрокатDataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this.видеоПрокатDataSet.Жанры);

        }
    }
}
