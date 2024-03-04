using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace injection_modelo
{
    public partial class MDIMenu : Form
    {
          public MDIMenu()
        {
            InitializeComponent();
        }
        private void MDIMenu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   
        }

        private void MDIMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
