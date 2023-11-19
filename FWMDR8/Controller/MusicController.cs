using FWMDR8.Dao;
using FWMDR8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FWMDR8.Controller
{
    public class MusicController
    {
        private readonly IMusicDao dao;
        public MusicController(IMusicDao musicDao)
        {
            dao = musicDao;
        }

        public MusicController()
        {
        }

        public IEnumerable<Music> GetMusic()
        {
            return dao.GetMusic();
        }

        public bool ModifyMusic(Music music)
        {
            return dao.ModifyMusic(music);
        }

        public bool AddMusic(Music music)
        {

            MessageBox.Show("Controller" + music.GetTitle() + " " + music.GetPerformer() + " " + music.GetReleaseDate() + " " + music.GetMusicLength() + " " + music.GetPriority());
            return dao.AddMusic(music);
        }
    }
}
