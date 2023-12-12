using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zhp.Models;

namespace zhp
{
    public partial class UserControl2 : UserControl
    {
        Context context = new Context();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            előadáBindingSource.DataSource = context.Előadás.ToList();
            operaAdatokBindingSource.DataSource = context.OperaAdatok.ToList();
            rendezésAdatokBindingSource.DataSource = context.RendezésAdatok.ToList();
            kezdésAdatokBindingSource.DataSource = context.KezdésAdatok.ToList();
            évadAdatokBindingSource.DataSource = context.ÉvadAdatok.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
