using FWMDR8.Entity;

namespace FWMDR8.ViewModels
{
    public class MusicViewModel
    {
        public string Title { get; set; }
        public string Performer { get; set; }
        public ushort ReleaseDate { get; set; }
        public ushort MusicLength { get; set; }
        public byte Priority { get; set; }

        public MusicViewModel(Music music)
        {
            Title = music.GetTitle();
            Performer = music.GetPerformer();
            ReleaseDate = music.GetReleaseDate();
            MusicLength = music.GetMusicLength();
            Priority = (byte)music.GetPriority();
        }
    }
}
