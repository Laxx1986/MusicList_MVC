using FWMDR8.Controller;
using FWMDR8.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FWMDR8
{
    public partial class Form2 : Form
    {
        MusicController musicController = new MusicController();



        public Form2()
        {

            InitializeComponent();

        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string title = musicTitleBox.Text;
            string performer = performerNameBox.Text;
            ushort release_date;
            ushort music_length;
            byte priority;
            if (ushort.TryParse(releaseDateBox.Text, out release_date)) { }

            if (ushort.TryParse(musicLengthBox.Text, out music_length)) { }

            if (byte.TryParse(priorityBox.Text, out priority)) { }

            Music music = new Music();
            music.SetTitle(title);
            music.SetPerformer(performer);
            music.SetReleaseDate(release_date);
            music.SetMusicLength(music_length);
            music.SetPriority(priority);



            musicController.AddMusic(music);
            this.Close();
        }
    }
}
