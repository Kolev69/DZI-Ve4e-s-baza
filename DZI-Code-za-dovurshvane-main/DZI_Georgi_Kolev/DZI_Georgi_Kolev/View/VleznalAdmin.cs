using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZI_Georgi_Kolev
{
    public partial class VleznalAdmin : Form
    {
        public VleznalAdmin()
        {
            InitializeComponent();
        }

        private void VleznalAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dZI_Georgi_12ADataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.dZI_Georgi_12ADataSet.admin);

        }
    }
}
