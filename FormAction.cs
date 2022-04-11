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
    public partial class FormAction : Form
    {
        public FormAction()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxIdType.Text) > 0)
                {
                    FormView.listEvents.Add(new Action(1, Convert.ToInt32(textBoxIdType.Text), textBoxState.Text, textBoxDistrict.Text, textBoxCommunity.Text, textBoxOfficerFirstName.Text, textBoxOfficerName.Text, textBoxOfficerRank.Text, dateTimePickerActionDate.Value, checkBoxActionGun.Checked, (Bitmap)pictureBox1.Image, textBoxPartOfTheDay.Text, textBoxWeather.Text, textBoxPlace.Text, textBoxPoliceUnit.Text));
                    FormView.listEvents[FormView.listEvents.Count - 1].Write(listBoxAction, pictureBox2);
                }
                else
                {
                    MessageBox.Show("Błędne dane");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textBoxIdType.Text = "";
                textBoxState.Text = "";
                textBoxDistrict.Text = "";
                textBoxCommunity.Text = "";
                textBoxPlace.Text = "";
                textBoxOfficerFirstName.Text = "";
                textBoxOfficerName.Text = "";
                textBoxOfficerRank.Text = "";
                textBoxPartOfTheDay.Text = "";
                textBoxWeather.Text = "";
                textBoxPoliceUnit.Text = "";
                checkBoxActionGun.Checked = false;
                dateTimePickerActionDate.Value = DateTime.Now;
            }
        }

        private void listBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";   //ścieżka
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //filtr plików
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;
                        pictureBox1.Image = Image.FromFile(filePath);
                    }
                    catch (OutOfMemoryException ex)
                    {
                        MessageBox.Show("Nieprawiłowy plik");
                    }
                }
            }
        }

        private void buttonAutocomplete_Click(object sender, EventArgs e)
        {
            textBoxIdType.Text = "1";
            textBoxState.Text = "Opolskie";
            textBoxDistrict.Text = "Nyski";
            textBoxCommunity.Text = "Nysa";
            textBoxPlace.Text = "KPP Nysa";
            textBoxOfficerFirstName.Text = "Zbigniew";
            textBoxOfficerName.Text = "Noga";
            textBoxOfficerRank.Text = "Inspektor";
            textBoxPartOfTheDay.Text = "Popołudnie";
            textBoxWeather.Text = "Słońce";
            textBoxPoliceUnit.Text = "Kryminalna";
            checkBoxActionGun.Checked = true;
            dateTimePickerActionDate.Value = DateTime.Now;
            pictureBox1.Image = Image.FromFile("C:\\action\\picture1.bmp");


        }
    }
}
