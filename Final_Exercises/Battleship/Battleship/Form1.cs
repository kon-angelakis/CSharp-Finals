namespace Battleship
{
    public partial class Form1 : Form
    {
        private string nickname;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nickname = textBox1.Text;
            if(nickname == "")
            {
                MessageBox.Show("Please provide a nickname");
            }
            else
            {
                Player player = new Player(nickname); //Creates new player instance
                player.setGameCount(0);
                player.setTotalWins(0);
                player.setTotalLosses(0);
                Game_Form gameForm = new Game_Form(player); //Passes player instance as a parameter to the game form
                gameForm.Show();
            }
        }
    }
}