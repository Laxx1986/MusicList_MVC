using FWMDR8.Entity;

namespace FWMDR8.Dao
{
    public interface IMusicDao
    {
        bool AddMusic(Music music);
        bool ModifyMusic(Music music);
        Music GetMusic(String title);

        IEnumerable<Music> GetMusic();    
    }
}
