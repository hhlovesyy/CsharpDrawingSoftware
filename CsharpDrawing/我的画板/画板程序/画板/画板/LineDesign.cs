using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 画板
{
    public partial class LineDesign : Form
    {
        public LineDesign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBox1_KeyPress(object sender,KeyPressEventArgs e) 
        {
            if(e.KeyChar==(char)13)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
