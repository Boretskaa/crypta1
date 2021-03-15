using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace crypta1
{
    public partial class Завдання : Form
    {
        public Завдання()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Завдання1 f2 = new Завдання1();
            f2.Activate();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Завдання2 f3 = new Завдання2();
            f3.Activate();
            f3.Show();
        }
    }
}
