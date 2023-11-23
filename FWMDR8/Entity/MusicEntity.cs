using System.Windows.Forms.VisualStyles;

namespace FWMDR8.Entity
{
    public class Music
    {
        public int ID { get; set; }
        // Nem lehet üres és egyedi
        public string title;

        //Nem lehet üres
        public string performer;

        //Nem lehet negatív
        public int release_date;

        //Nem lehet negatív
        public int music_length;

        //Nem lehet negatív
        public int priority;

        public string GetTitle() { return title; }
        public void SetTitle(string _title)
        {
            title = _title;
        }

        public string GetPerformer() { return performer; }
        public void SetPerformer(string _performer)
        {
            performer = _performer;
        }

        public int GetReleaseDate() { return release_date; }

        public void SetReleaseDate(int _release_date)
        {
            release_date = _release_date;
        }

        public int GetMusicLength() { return music_length; }

        public void SetMusicLength(int _music_length)
        {
            music_length = _music_length;
        }

        public int GetPriority() { return priority; }

        public void SetPriority(int _priority)
        {
            priority = _priority;
        }
    }
}
