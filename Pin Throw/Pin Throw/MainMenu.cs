namespace Pin_Throw
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        bool sound = true;
        string difficulty = "Medium";

        private void BPlay_Click(object sender, EventArgs e)
        {
            Game game = new Game(difficulty, sound);
            this.Hide();
            if (game.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void BSettings_Click(object sender, EventArgs e)
        {
            FSettings fSettings = new FSettings();
            fSettings.SetDifficulty(difficulty);
            fSettings.SetMuted(sound);

            if (fSettings.ShowDialog() == DialogResult.OK)
            {
                sound = fSettings.GetMuted();
                difficulty = fSettings.GetDifficulty();
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}