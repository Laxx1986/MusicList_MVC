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
            var dao2 = new MusicDao();
            return dao2.GetMusic();
        }

        public bool ModifyMusic(Music music)
        {
            return dao.ModifyMusic(music);
        }

        public bool AddMusic(Music music)
        {
            var dao2 = new MusicDao();
            return dao2.AddMusic(music);
        }
    }
}
