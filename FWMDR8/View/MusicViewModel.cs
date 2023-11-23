using FWMDR8.Entity;

namespace FWMDR8.ViewModels
{
    public class MusicViewModel
    {

        public string Title { get; set; }
        public string Performer { get; set; }
        public int ReleaseDate { get; set; }
        public int MusicLength { get; set; }


        public MusicViewModel(Music music)
        {
            Title = music.GetTitle();
            Performer = music.GetPerformer();
            ReleaseDate = music.GetReleaseDate();
            MusicLength = music.GetMusicLength();
        }
    }
}
