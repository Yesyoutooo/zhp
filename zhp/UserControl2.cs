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
        }
    }
}
