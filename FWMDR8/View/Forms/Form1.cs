using FWMDR8.Controller;
using FWMDR8.Entity;
using FWMDR8.Dao;

namespace FWMDR8
{
    public partial class Form1 : Form
    {
        private readonly MusicController musicController;
        public Form1()
        {
            InitializeComponent();
            musicController = new MusicController(new MusicDao());
        }



        private void újZeneHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2(musicController);
            Form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browsingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            musicGridView.Visible = true;
            button1.Visible = true;
            var music = musicController.GetMusic();

            var viewModels = new List<Music>();

            foreach (var item in music)
            {
                viewModels.Add(new Music(item));
            }

            musicGridView.DataSource = null;
            musicGridView.DataSource = viewModels;
            musicGridView.Visible = true;

            musicGridView.Columns["ID"].Visible = false;
            musicGridView.Columns["priority"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicGridView.Visible = false;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form2 = new Form2(musicController);
            Form2.Show();
        }

        private void musicGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(musicGridView.CurrentRow.DataBoundItem is Music music))
            {

                return;
            }

            var Form2 = new Form2(musicController, music);
            MessageBox.Show("musicGridView_CellContentClick executed!");
            Form2.ShowDialog();

        }
    }
}