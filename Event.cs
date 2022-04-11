using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;

namespace KacperBandyk_Komisariat
{
    abstract public class Event : IComparable<Event>
    {
        protected int id = 0, idType = 0;
        protected string state, district, community, officerFirstName, officerName, officerRank;
        protected DateTime Date;
        protected bool usedGun;
        protected Bitmap picture;



        public Event()
        {
            id++;
            this.idType = 1;
            this.state = "Unknown";
            this.district = "Unknown";
            this.community = "Unknown";
            this.officerFirstName = "Unknown";
            this.officerName = "Unknown";
            this.officerRank = "Unknown";
            Date = DateTime.Now;
            usedGun = true;
        }
        public Event(int id, int idType, string state, string district, string community, string officerName, string officerFirstName, string officerRank, DateTime Date, bool usedGun, Bitmap picture)
        {
            id++;
            this.idType = idType;
            this.state = state;
            this.district = district;
            this.community = community;
            this.officerName = officerName;
            this.officerFirstName = officerFirstName;
            this.officerRank = officerRank;
            this.Date = Date;
            this.usedGun = usedGun;
            this.picture = picture;

        }

        public Event(Event previousEvent)
        {
            id++;
            idType = previousEvent.idType;
            state = previousEvent.state;
            district = previousEvent.district;
            community = previousEvent.community;
            officerFirstName = previousEvent.officerFirstName;
            officerName = previousEvent.officerName;
            officerRank = previousEvent.officerRank;
            Date = previousEvent.Date;
            usedGun = previousEvent.usedGun;
            picture = previousEvent.picture;
        }

        ~Event()
        {
        }

        virtual public void Write(ListBox lb, PictureBox pb)
        {
            lb.Items.Clear();
            lb.Items.Add("Numer: \t" + id);
            lb.Items.Add("Numer id: \t" + idType);
            lb.Items.Add("Województwo: \t" + state);
            lb.Items.Add("Powiat: \t" + district);
            lb.Items.Add("Gmina: \t" + community);
            lb.Items.Add("Imię prowadzącego: \t" + officerFirstName);
            lb.Items.Add("Nazwisko prowadzącego: \t" + officerName);
            lb.Items.Add("Ranga prowadzącego: \t" + officerRank);
            lb.Items.Add("Data: \t" + Date);
            lb.Items.Add("Czy była broń użyta: \t" + usedGun);
            pb.Image = picture;
        }

        public virtual void WriteToFile(StreamWriter sw)
        {
        }

        public virtual void ReadFromFile(StreamReader sr)
        {
        }

        public virtual void WritePhotoToFile(string fullFileName)
        {
        }

        public virtual void ReadPhotoFromFile(string fullFileName)
        {
        }

        public int GetUsedGun()
        {
            return Convert.ToInt32(usedGun);
        }

        public void WriteShortly(ListBox lb)
        {
            lb.Items.Add(state + ", " + district + ", " + Date.ToString("yyyy’-‘MM’-‘dd’"));
        }

        public int CompareTo(Event other)
        {
            if (other == null)
            {
                return 1;
            }

            //Sortowanie wedlug wojewodztwa
            if (String.Compare(this.state, other.state) == 1)
            {
                return 1;
            }
            else if (String.Compare(this.state, other.state) == -1)
            {
                return -1;
            }
            else
            {
                //Sortowanie wedlug powiatu
                if (String.Compare(this.district, other.district) == 1)
                    return 1;
                else if (String.Compare(this.district, other.district) == -1)
                    return -1;
                else
                {
                    //Sortowanie wedlug daty
                    if (this.Date > other.Date)
                        return 1;
                    else if (this.Date < other.Date)
                        return -1;

                    return 0;
                }
            }

        }
    }
}
