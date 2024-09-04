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
    public partial class StaffForm : Form
    {
        private string _username;
        public StaffForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }
    }
}
