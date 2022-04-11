using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        FormAction FormAction = new FormAction();
        FormTraining FormTraining = new FormTraining();
        FormView FormView = new FormView();
        FormOperator FormOperator = new FormOperator();
        FormSort FormSort = new FormSort();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEvent_Click(object sender, EventArgs e)
        {
           //Event event1 = new Event();
            //event1.Write(listBoxEvent);
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            FormAction.ShowDialog();
        }

        private void buttonTraining_Click(object sender, EventArgs e)
        {
            FormTraining.ShowDialog();
        }

        private void buttonDialog_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            FormView.ShowDialog();
        }

        private void buttonOperator_Click(object sender, EventArgs e)
        {
            FormOperator.ShowDialog();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            FormSort.ShowDialog();
        }
    }
}
