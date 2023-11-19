using System.Windows.Forms.VisualStyles;

namespace FWMDR8.Entity
{
    public class Music
    {
        public IntegerProperty ID;
        // Nem lehet üres és egyedi
        public string title;

        //Nem lehet üres
        public string performer;

        //Nem lehet negatív
        public ushort release_date;

        //Nem lehet negatív
        public ushort music_length;

        //Nem lehet negatív
        public byte priority;

        public string GetTitle() { return title; }
        public void SetTitle(string _title)
        {
            if (string.IsNullOrEmpty(_title))
            {
                throw new ArgumentNullException("The title must be not empty or not null");
            }
            title = _title;
        }

        public string GetPerformer() { return performer; }
        public void SetPerformer(string _performer)
        {
            if (string.IsNullOrEmpty(_performer))
            {
                throw new ArgumentNullException("The perfomer must be not empty or not null");
            }
            performer = _performer;
        }

        public ushort GetReleaseDate() { return release_date; }

        public void SetReleaseDate(ushort _release_date)
        {
            if (_release_date < 0)
            {
                throw new Exception("The release date cannot be negative!");
            }
            release_date = _release_date;
        }

        public ushort GetMusicLength() { return music_length; }

        public void SetMusicLength(ushort _music_length)
        {
            if (_music_length < 0)
            {
                throw new Exception("The music length cannot be negative!");
            }
            music_length = _music_length;
        }

        public ushort GetPriority() { return priority; }

        public void SetPriority(byte _priority)
        {
            if (_priority < 0)
            {
                throw new Exception("The music length cannot be negative!");
            }
            priority = _priority;
        }
    }
}
