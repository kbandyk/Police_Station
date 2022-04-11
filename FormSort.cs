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
    public partial class FormSort : Form
    {
        public FormSort()
        {
            InitializeComponent();
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            listBoxSort.Items.Clear();
            foreach (Event p in FormView.listEvents)
                p.WriteShortly(listBoxSort);
        }

        private void buttonSortAndWrite_Click(object sender, EventArgs e)
        {
            FormView.listEvents.Sort();    //Sortowanie elementów listy

            listBoxSort.Items.Clear();
            foreach (Event p in FormView.listEvents)
                p.WriteShortly(listBoxSort);
        }
    }
}
