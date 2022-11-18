using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_15_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } // Form1()


        private void btnExampleForm_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        } // btnExampleForm_Click()
    } // class

} // namespace
