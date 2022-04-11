using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace KacperBandyk_Komisariat
{
    class Training:Event
    {
        int numberOfPersons = 0, maxPersons = 0;
        string place, type;
        bool accommodation;
        int[] tab = new int [3];
        override public void Write(ListBox lb, PictureBox pb)
        {
            base.Write(lb,pb);
            lb.Items.Add("Liczba osób: \t" + numberOfPersons);
            lb.Items.Add("Liczba miejsc: \t" + maxPersons);
            lb.Items.Add("Typ szkolenia: \t" + GetTypeOfTraining());
            lb.Items.Add("Miejsce: \t" + place);
            lb.Items.Add("Zakwaterowanie: \t" + accommodation);

        }
        public Training():base()
        {
            numberOfPersons = '0';
            maxPersons = '0';
            place = "Unknown";
            type = GetTypeOfTraining();
            accommodation = false;
        }

        public Training(int id, int idType, string state, string district, string community, string officerFirstName, string officerName, string officerRank, DateTime Data, bool usedGun, Bitmap picture, int numberOfPersons, int maxPersons, string place, bool accommodation) : base(id, idType, state, district, community, officerFirstName, officerName, officerRank, Data, usedGun, picture)
        {
            this.numberOfPersons = numberOfPersons;
            this.maxPersons = maxPersons;
            this.place = place;
            this.type = GetTypeOfTraining();
            this.accommodation= accommodation;
        }

        private void SetTypeOfTraining()
        {
            if (idType == 1)
                type = "Szkolenie związane z konwojowaniem i doprowadzaniem osób";
            else if (idType == 2)
                type = "Szkolenie dla dzielnicowych";
            else if (idType == 3)
                type = "Szkolenie z zakresu taktyki i technik przesłuchań";
            else if (idType == 4)
                type = "Szkolenie dla techników kryminalistyki";
            else
                type = "Nieznany";
        }
        public string GetTypeOfTraining()
        {
            return type;
        }


        public static Training o1 = new Training(1, 2, "Opolskie", "Nyski", "Nysa", "Jan", "Kowalski", "Inspektor", DateTime.Now, true, null, 10, 15, "KPP Nysa", false);
        public static Training o2 = new Training(1, 2, "Opolskie", "Nyski", "Nysa", "Jan", "Kowalski", "Inspektor", DateTime.Now, true, null, 10, 15, "KPP Nysa", false);
        //Operator ==
        public static bool operator ==(Training o1, Training o2)
        {
            return o1.idType == o2.idType;
        }

        //Operator !=
        public static bool operator !=(Training o1, Training o2)
        {
            return o1.idType != o2.idType;
        }

        //Operator +
        public static int operator +(Training o1, Training o2)
        {
            return o1.idType + o2.idType;
        }

        
        public override void WriteToFile(StreamWriter sw) //Zapis listy do pliku
        {
            sw.WriteLine("Training");
            sw.WriteLine(id);
            sw.WriteLine(idType);
            sw.WriteLine(state);
            sw.WriteLine(district);
            sw.WriteLine(community);
            sw.WriteLine(officerFirstName);
            sw.WriteLine(officerName);
            sw.WriteLine(officerRank);
            sw.WriteLine(Date);
            sw.WriteLine(usedGun);
            sw.WriteLine(numberOfPersons);
            sw.WriteLine(maxPersons);
            sw.WriteLine(place);
            sw.WriteLine(accommodation);
        }

        public override void WritePhotoToFile(string fullFileName)
        {
            picture.Save(fullFileName, ImageFormat.Bmp);
        }

        public override void ReadPhotoFromFile(string fullFileName)
        {
            picture = (Bitmap)Image.FromFile(fullFileName);
        }

        public override void ReadFromFile(StreamReader sr)
        {
            try
            {
                //sr.ReadLine();
                id = Convert.ToInt32(sr.ReadLine());
                idType = Convert.ToInt32(sr.ReadLine());
                state = sr.ReadLine();
                district = sr.ReadLine();
                community = sr.ReadLine();
                officerFirstName = sr.ReadLine();
                officerName = sr.ReadLine();
                officerRank = sr.ReadLine();
                Date = Convert.ToDateTime(sr.ReadLine());
                usedGun = Convert.ToBoolean(sr.ReadLine());
                numberOfPersons = Convert.ToInt32(sr.ReadLine());
                maxPersons = Convert.ToInt32(sr.ReadLine());
                place = sr.ReadLine();
                accommodation = Convert.ToBoolean(sr.ReadLine());
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
