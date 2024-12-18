using System.IO;
namespace MyMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            Player.URL = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileDialog1.FileName)){
                Player.URL = openFileDialog1.FileName;
                Player.Ctlcontrols.play();// plays music

            }
            //Player.Ctlcontrols.play(); //plays music
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause(); //pause music
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop(); //stop music

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Player_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = trackBar1.Value;
        }

    }
}
