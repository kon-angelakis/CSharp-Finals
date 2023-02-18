namespace Battleship
{
    public partial class Final : Form
    {
        private Player player;
        public Final(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

        //Current player wants to play again
        private void button1_Click(object sender, EventArgs e)
        {
            new Game_Form(player).Show();
            this.Close();
        }

        //Current player quits
        private void button2_Click(object sender, EventArgs e)
        {
            if(player.getGameCount() > 1) //If current player has played multiple games then the player's overall victories and losses are announced
            {
                MessageBox.Show("Victories: " + player.getTotalWins() + " \n " +
                    "Losses: " + player.getTotalLosses());
            }
            this.Close();
        }

        private void Final_Load(object sender, EventArgs e)
        {

        }
    }
}
