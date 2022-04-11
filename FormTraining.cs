using System;
using System.Windows.Forms;
using System.Drawing;

namespace KacperBandyk_Komisariat
{
    public partial class FormTraining : Form
    {

        public FormTraining()
        {
            InitializeComponent();
        }

        private void buttonTraining_Click(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(textBoxIdType.Text) > 0 &&
                Convert.ToInt32(textBoxNumberOfPersons.Text) > 0 &&
                Convert.ToInt32(textBoxMaxPersons.Text) > 0)
                {
                    FormView.listEvents.Add(new Training(1, Convert.ToInt32(textBoxIdType.Text), textBoxState.Text, textBoxDistrict.Text, textBoxCommunity.Text, textBoxOfficerFirstName.Text, textBoxOfficerName.Text, textBoxOfficerRank.Text, dateTimePickerTrainingDate.Value, checkBoxTrainingGun.Checked, (Bitmap)pictureBox1.Image, Convert.ToInt32(textBoxNumberOfPersons.Text), Convert.ToInt32(textBoxMaxPersons.Text), textBoxPlace.Text, checkBoxAccommodation.Checked));
                    FormView.listEvents[FormView.listEvents.Count - 1].Write(listBoxTraining, pictureBox2);
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
                dateTimePickerTrainingDate.Value = DateTime.Now;
                checkBoxTrainingGun.Checked = false;
                checkBoxAccommodation.Checked = false;
                textBoxNumberOfPersons.Text = "";
                textBoxMaxPersons.Text = "";
            }

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
                        MessageBox.Show("Nieprawidłowy plik");
                    }
                }
            }
        }

        private void textBoxState_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

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
            dateTimePickerTrainingDate.Value = DateTime.Now;
            checkBoxTrainingGun.Checked = true;
            checkBoxAccommodation.Checked = false;
            textBoxNumberOfPersons.Text = "12";
            textBoxMaxPersons.Text = "15";
            pictureBox1.Image = Image.FromFile("C:\\training\\picture1.bmp");
        }
    }
}
