using FWMDR8.Controller;
using FWMDR8.ViewModels;

namespace FWMDR8
{
    public partial class Form1 : Form
    {
        MusicController musicController = new MusicController();
        public Form1()
        {
            InitializeComponent();
        }



        private void újZeneHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modifyMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        }

        private void browsingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicGridView.Visible = true;
            button1.Visible = true;
            var music = musicController.GetMusic();
            //TODO: Ez tuti nem jó így, még utána járni
            var viewModels = new List<MusicViewModel>();

            foreach (var item in music)
            {
                viewModels.Add(new MusicViewModel(item));
            }

            musicGridView.DataSource = null;
            musicGridView.DataSource = viewModels;
            musicGridView.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicGridView.Visible = false;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2();
            Form2.Show();
        }
    }
}