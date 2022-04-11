using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KacperBandyk_Komisariat
{
    public partial class FormView : Form
    {

        Action a;
        Training s;
        public static List<Event> listEvents = new List<Event>();
        int i = listEvents.Count;
        public FormView()
        {
            InitializeComponent();
        }

        private void FormView_Load(object sender, EventArgs e)
        {
            
                
                
            
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listEvents.Count; i++)     //dla każdego (i-tego) elementu listy
                {
                    listEvents[i].Write(listBoxViewData, pictureBoxViewImage);     //wypisz (i-ty) element listy w listBox
                    MessageBox.Show("Element nr " + i);          //pokaż okno z informacją
                }
                listEvents[0].Write(listBoxViewData, pictureBoxViewImage);
            }
            catch(ArgumentOutOfRangeException argex)
            {
                MessageBox.Show("Brak obiektów na liście! \n"+argex.Message);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (i == 0)
                buttonPrevious.Enabled = false;
            else
            {
                buttonPrevious.Enabled = true;
                i--;
                listEvents[i].Write(listBoxViewData, pictureBoxViewImage);
            }
            if (i >= (listEvents.Count - 1))
                buttonNext.Enabled = false;
            else
                buttonNext.Enabled = true;


        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (i >= (listEvents.Count - 1))
                buttonNext.Enabled = false;
            else
            {
                buttonNext.Enabled = true;
                i++;
                listEvents[i].Write(listBoxViewData, pictureBoxViewImage);
            }
            if (i == 0)
                buttonPrevious.Enabled = false;
            else
                buttonPrevious.Enabled = true;


        }

        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            //Ustawienie ścieżki z katalogiem do przechowywania obrazków (path)
            //oraz utworzenie katalogu
            string path = textBoxPath.Text;     //wczytanie pełnej ścieżki z nazwą katalogu z pola tekstowego
            bool exists = System.IO.Directory.Exists(path);
            if (!exists)
                System.IO.Directory.CreateDirectory(path);

            //Utworzenie okna dialogowego do wybrania pliku wyjściowego i ustawienie jego parametrów
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Plik tekstowy|*.txt";
            sfd.Title = "Do jakiego pliku chcesz zapisać dane studentów?";
            sfd.ShowDialog();               //pokazanie okna dialogowego

            //Zapis danych do plików
            if (sfd.FileName != "")
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);   //otwarcie pliku do zapisu danych
                int i = 0;
                foreach (Event s in listEvents)                  //dla każdego elementu listy
                {
                    s.WriteToFile(sw);                  //ZAPIS PÓL/DANYCH TEKSTOWYCH

                    string fullFileName = path + "file" + i + ".bmp";   //wywołaj metodę Write zapisującą do pliku przy użyciu sw
                    s.WritePhotoToFile(fullFileName);   //ZAPISA OBRAZKA
                    i++;
                }
                sw.Close();                                         //zamknięcie pliku
            }
            
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();              //utworzenie okna dialogowego do wybrania pliku wejściowego
            if (ofd.ShowDialog() == DialogResult.OK)                //pokazanie okna dialogowego
            {
                StreamReader sr = new StreamReader(ofd.FileName);   //otwarcie pliku do odczytu danych
                while (!sr.EndOfStream)
                {
                    if (sr.ReadLine() == "Training")
                    {
                        Training s = new Training();          //utworzenie kolejnego obiektu klasy Student

                        s.ReadFromFile(sr);                 //wywołanie metody odczytującej kolejne pola z pliku do obiektu

                        //foreach (Event s in listEvents)
                        //{
                            int i = 0;
                            string path = textBoxPath.Text;
                            string fullFileName = path + "file" + i + ".bmp";
                            s.ReadPhotoFromFile(fullFileName);
                            i++;
                        //}
                        //TU TRZEBA DODAĆ INSTRUKCJE WCZYTUJĄCE OBRAZEK DO OBIEKTU s
                        //(Z WYWOŁANIEM METODY s.ReadFotoFromFile(...))

                        listEvents.Add(s);                 //dodanie obiektu do listy "listPersons"
                    }
                    else
                    {
                        Action a = new Action();

                        a.ReadFromFile(sr);                 //wywołanie metody odczytującej kolejne pola z pliku do obiektu

                        int i = 0;
                        string path = textBoxPath.Text;
                        string fullFileName = path + "file" + i + ".bmp";
                        a.ReadPhotoFromFile(fullFileName);
                        i++;
                        //TU TRZEBA DODAĆ INSTRUKCJE WCZYTUJĄCE OBRAZEK DO OBIEKTU s
                        //(Z WYWOŁANIEM METODY s.ReadFotoFromFile(...))

                        listEvents.Add(a);                 //dodanie obiektu do listy "listPersons"
                    }
                    
                }
                sr.Close();                                         //zamknięcie pliku
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (textBoxRemoveElement.Text != "")
                listEvents.RemoveAt(Convert.ToInt32(textBoxRemoveElement.Text));
            else
                MessageBox.Show("Błąd! Brak podanej wartości");
        }

        private void buttonRemove_MouseHover(object sender, EventArgs e)
        {

             buttonRemove.BackColor = Color.Maroon;
             buttonRemove.ForeColor = Color.Black;
        }

        private void buttonRemove_MouseLeave(object sender, EventArgs e)
        {
            buttonRemove.BackColor = Color.White;
            buttonRemove.ForeColor = Color.Black;
        }

        private void buttonView_MouseHover(object sender, EventArgs e)
        {
            buttonView.Size = new Size(145, 35);
        }

        private void buttonView_MouseLeave(object sender, EventArgs e)
        {
            buttonView.Size = new Size(138, 27);
        }

        private void buttonGunPercent_Click(object sender, EventArgs e)
        {
            textBoxGunPercent.Text = "";
            float numberOfActions = 0;
            float numberOfUsedGunActions = 0;
            for (int i = 0; i < listEvents.Count; i++)
            {
                numberOfUsedGunActions += listEvents[i].GetUsedGun();
                numberOfActions++;
            }
            if (numberOfActions > 0)
            {
                textBoxGunPercent.Text = Convert.ToString((numberOfUsedGunActions / numberOfActions) * 100)+"%";
            }
            else
                MessageBox.Show("Brak elementów na liście");
        }
    }
}
