using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace KacperBandyk_Komisariat
{
    class Action: Event
    {
        string place, partOfTheDay, weather, policeUnit, type;

        override public void Write(ListBox lb, PictureBox pb)
        {
            base.Write(lb,pb);
            lb.Items.Add("Miejsce: \t" + place);
            lb.Items.Add("Pora dnia: \t" + partOfTheDay);
            lb.Items.Add("Warunki atmosferyczne: \t" + weather);
            lb.Items.Add("Nazwa jednostki policji: \t" + policeUnit);
            lb.Items.Add("Typ akcji: \t" + GetTypeOfAction());
            pb.Image = picture;
        }

        public Action() : base()
        {
            place = "Unknown";
            partOfTheDay = "Unknown";
            weather = "Unknown";
            policeUnit = "Unknown";
            type = GetTypeOfAction();
        }

        public Action(int id, int idType, string state, string district, string community, string officerFirstName, string officerName, string officerRank, DateTime Data, bool usedGun, Bitmap picture, string partOfTheDay, string weather, string place, string policeUnit):base(id, idType, state, district, community, officerFirstName, officerName, officerRank, Data, usedGun, picture)
        {
            this.place = place;
            this.partOfTheDay = partOfTheDay;
            this.weather = weather;
            this.policeUnit = policeUnit;
            this.type = GetTypeOfAction();
        }

        private void SetTypeOfAction()
        {
            if (idType == 1)
                type = "Morderstwo";
            else if (idType == 2)
                type = "Kradzież";
            else if (idType == 3)
                type = "Włamanie";
            else if (idType == 4)
                type = "Przemyt";
            else
                type = "Nieznany";
        }
        public string GetTypeOfAction() => type;

        public override void WriteToFile(StreamWriter sw)
        {
            sw.WriteLine("Action");
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
            sw.WriteLine(place);
            sw.WriteLine(partOfTheDay);
            sw.WriteLine(weather);
            sw.WriteLine(policeUnit);
        }

        public override void WritePhotoToFile(string fullFileName)
        {
            picture.Save(fullFileName, ImageFormat.Bmp);
        }

        public override void ReadPhotoFromFile(string fullFileName)
        {
            try
            {
                picture = (Bitmap)Image.FromFile(fullFileName);
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override void ReadFromFile(StreamReader sr)
        {
            
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
                place = sr.ReadLine();
                partOfTheDay = sr.ReadLine();
                weather = sr.ReadLine();
                policeUnit = sr.ReadLine();
            

        }
    }
}
