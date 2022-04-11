using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KacperBandyk_Komisariat
{
    public partial class FormOperator : Form
    {
        public FormOperator()
        {
            InitializeComponent();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            textBoxEqual.Text = Convert.ToString(Training.o1 == Training.o2);
        }

        private void buttonNotEqual_Click(object sender, EventArgs e)
        {
            {
                textBoxNotEqual.Text = Convert.ToString(Training.o1 != Training.o2);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            {
                textBoxAdd.Text = Convert.ToString(Training.o1 + Training.o2);
            }
        }
    }
}
