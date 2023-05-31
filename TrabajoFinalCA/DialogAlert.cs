using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalCA
{
    public partial class DialogAlert : Form
    {
        public DialogAlert()
        {
            InitializeComponent();
        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
