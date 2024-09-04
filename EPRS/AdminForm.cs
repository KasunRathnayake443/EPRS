using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPRS
{
    public partial class AdminForm : Form
    {
        private string _username;
        public AdminForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
