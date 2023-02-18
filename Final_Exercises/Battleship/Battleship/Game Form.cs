namespace Battleship
{
    public partial class Game_Form : Form
    {
        private Random r;
        private Player user;
        private static bool turn = true;
        private int timeElapsed = 0, moves = 0;
        private List<List<Point>> playerFleet = new List<List<Point>>();
        private List<List<Point>> enemyFleet = new List<List<Point>>();
        private List<Point> playerShips = new List<Point>();
        private List<Point> enemyShips = new List<Point>();
        private List<Point> hitSpots = new List<Point>();
        private List<Point>  enemyhitSpots = new List<Point>();
        private List<bool> destroyedplayerships = new List<bool> { false, false, false, false };
        private List<bool> destroyedenemyships = new List<bool> { false, false, false, false };

        public Game_Form(Player user)
        {
            InitializeComponent();
            this.user = user; 
        }

        private void Game_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
            EnemyFire.Start();
            Ships player = new Ships();
            Ships enemy = new Ships();
            enemy.spawnShips();
            player.spawnShips();
            playerFleet = player.getAvailableShip();
            enemyFleet = enemy.getAvailableShip();
            playerShips = player.getLocations();
            enemyShips = enemy.getLocations();
            //Displays the player's ships on the board
            foreach(Point p in playerShips)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Margin = new Padding(1, 1, 1, 1);
                pictureBox.BackColor = Color.Yellow;
                PlayerTerritory.Controls.Add(pictureBox, p.X,p.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { //Player Opens fire only if both comboboxes are valid
                if (turn)
                {
                    Point target;
                    int x, y;
                    x = comboBox1.SelectedIndex;
                    y = comboBox2.SelectedIndex;
                    target = new Point(x, y);
                    if (!hitSpots.Contains(target))
                    {
                        TurnLabel.Text = "CPU Turn";
                        TurnLabel.ForeColor = Color.MediumVioletRed;
                        string hit = openFire(EnemyTerritory, target, hitSpots, enemyShips, enemyFleet, destroyedenemyships);
                        moves++;
                        richTextBox1.AppendText("Player (" + (comboBox2.SelectedItem) + "," + (target.X+1) + ") " + hit +'\n');
                        turn = false;
                    }
                    else { MessageBox.Show("Spot already hit"); }
                }
                else { MessageBox.Show("Wait for you turn"); }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter both coordinates");
            }
        }

        //Check every 1 second and a half if player has attacked, more humanlike behaviour from the computer
        private void EnemyFire_Tick(object sender, EventArgs e)
        { 
            if (!turn)
            {
                EnemyFire.Stop();
                TurnLabel.Text = "Player Turn";
                TurnLabel.ForeColor = Color.Lime;
                Point target;
                int x, y, chance;
                PictureBox pictureBox = new PictureBox();
                target = new Point(); //Instantiate the object so the while loop runs at least once
                while (!enemyhitSpots.Contains(target))
                {
                    r = new Random();
                    chance = r.Next(0, 5); //CPU guesses right once every 5 times approximately
                    if(chance == 0)
                    {
                        int randpoint = r.Next(playerShips.Count());
                        target = playerShips[randpoint];
                    }
                    else
                    {
                        x = r.Next(0, 10);
                        y = r.Next(0, 10);
                        target = new Point(x, y);
                    }
                    if (!enemyhitSpots.Contains(target)) //Computer shouldnt hit the same place twice (random target is decided inside the loop)
                    {
                        string hit = openFire(PlayerTerritory, target, enemyhitSpots, playerShips, playerFleet, destroyedplayerships);
                        //Converts Y cords to unicode greek letters(offset is 912 u+0390)
                        richTextBox1.AppendText("CPU    (" + (Convert.ToChar(target.Y + 1 + 912)) + "," + (target.X + 1) + ") " + hit + '\n'); 
                    }
                }
                turn = true;
                EnemyFire.Start();
            }
        }

        private static string openFire(TableLayoutPanel oppositeTerritory, Point target, List<Point> targetSpot, List<Point> ships, List<List<Point>> fleet, List<bool> destroyedships)
        {
            PictureBox hitmark = new PictureBox();
            hitmark.Margin = new Padding(2, 2, 2, 2);
            oppositeTerritory.Controls.Remove(oppositeTerritory.GetControlFromPosition(target.X, target.Y));
            {
                for (int i = 0; i < fleet.Count; i++)
                {
                    for (int j = 0; j < fleet[i].Count; j++)
                    {
                        fleet[i].Remove(target);
                    }
                }
                foreach (List<Point> ship in fleet)
                {
                    if (ship.Count == 0)
                    {
                        int i = fleet.IndexOf(ship);
                        switch (i)
                        {
                            case (0):
                                if (!destroyedships[0])
                                {
                                    MessageBox.Show("Plane Carrier Destroyed");
                                }
                                destroyedships[0] = true;
                                break;
                            case (1):
                                if (!destroyedships[1])
                                {
                                    MessageBox.Show("Destroyer Destroyed");
                                }
                                destroyedships[1] = true;
                                break;
                            case (2):
                                if (!destroyedships[2])
                                {
                                    MessageBox.Show("Warship Destroyed");
                                }
                                destroyedships[2] = true;
                                break;
                            case (3):
                                if (!destroyedships[3])
                                {
                                    MessageBox.Show("Submarine Destroyed");
                                }
                                destroyedships[3] = true;
                                break;
                        }
                    }
                }
            }
            if (ships.Contains(target))
            {
                hitmark.BackColor = Color.Red;
                oppositeTerritory.Controls.Add(hitmark, target.X, target.Y);
                ships.Remove(target);
                targetSpot.Add(target);
                return ("Hit");
            }
            else
            {
                hitmark.BackColor = Color.Navy;
                oppositeTerritory.Controls.Add(hitmark, target.X, target.Y);
                ships.Remove(target);
                targetSpot.Add(target);
                return ("No-Hit");
            }
            
        }

        //Timer counts the duration of the game in seconds
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = "Time Elapsed: " + ++timeElapsed;
            if (playerShips.Count == 0)
            {
                timer1.Stop();
                closeGame("CPU");
            }
            if (enemyShips.Count == 0)
            {
                timer1.Stop();
                closeGame("Player");
            }
        }

        //Updates database, announces the winner and initializes the shut-down proccess prompting the user to either play again or quit
        private void closeGame(string winner)
        {
            user.updateDatabase(winner, timeElapsed);
            if (winner == "Player")
            {
                MessageBox.Show("The winner is: " + user.getName() + "!\n" +
                    "The game lasted: " + timeElapsed + " seconds and you made: " + moves + " moves!");
                user.setTotalWins(user.getTotalWins() + 1);
            }
            else
            {
                MessageBox.Show("The CPU won!");
                user.setTotalLosses(user.getTotalLosses() + 1);
            }
            user.setGameCount(user.getGameCount() + 1);
            new Final(user).Show();
            this.Close();
        }

        //Update richtextbox so it always shows the latest information written on it
        private void richTextBox1_TextChanged(object sender, EventArgs e) 
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}
