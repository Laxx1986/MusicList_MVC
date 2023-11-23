using FWMDR8.Controller;
using FWMDR8.Dao;
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
        private readonly MusicController musicController = new MusicController();
        private readonly int Id;
        private readonly bool IsModification = false;


        public Form2(MusicController controller)
        {

            InitializeComponent();
            this.musicController = controller;

        }

        public Form2(MusicController controller, Music music)
        {
            InitializeComponent();
            IsModification = true;
            Id = music.ID;
            musicTitleBox.Text = music.title;
            performerNameBox.Text = music.performer;
            releaseDateBox.Text = ""+music.release_date;
            musicLengthBox.Text = "" + music.music_length;
            priorityBox.Text = "" + music.priority;
            saveButton.Text = "Modify";
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string title = musicTitleBox.Text;
            string performer = performerNameBox.Text;
            int release_date;
            int music_length;
            int priority;

            if (!int.TryParse(releaseDateBox.Text, out release_date)) {
                MessageBox.Show("A release date csak szám lehet!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            if (!int.TryParse(musicLengthBox.Text, out music_length)) {

                MessageBox.Show("A zene hossza csak szám lehet!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            if (!int.TryParse(priorityBox.Text, out priority)) {

                MessageBox.Show("A prioritás csak szám lehet!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }
            if (title == string.Empty || performer == string.Empty)
            {
                MessageBox.Show("Kötelező megadni a zene címét és az előadót", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            if ((release_date < 1900) || (release_date > 2023))
            {
                MessageBox.Show("A release date 1900 és 2023 közé kell essen!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            if (music_length < 0 || priority < 0)
            {
                MessageBox.Show("Negatív számot nem lehet megadni", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            Music music = new Music();
            music.SetTitle(title);
            music.SetPerformer(performer);
            music.SetReleaseDate(release_date);
            music.SetMusicLength(music_length);
            music.SetPriority(priority);

            if (IsModification)
            {
                music.ID = Id;
                musicController.ModifyMusic(music);
            } else 
            { 
                musicController.AddMusic(music);
            }

            
            this.Close();
        }
    }
}
