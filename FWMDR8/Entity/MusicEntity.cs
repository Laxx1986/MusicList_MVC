using System.Windows.Forms.VisualStyles;

namespace FWMDR8.Entity
{
    public class Music
    {
        public int ID { get; set; }
        // Nem lehet üres és egyedi
        public string title { get; set; }

        //Nem lehet üres
        public string performer { get; set; }

        //Nem lehet negatív
        public int release_date { get; set; }

        //Nem lehet negatív
        public int music_length { get; set; }

        //Nem lehet negatív
        public int priority { get; set; }

        public Music(Music other)
        {
            ID = other.ID;
            title = other.title;
            performer = other.performer;
            release_date = other.release_date;
            music_length = other.music_length;
            priority = other.priority;
        }

        public Music()
        {
        }

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
