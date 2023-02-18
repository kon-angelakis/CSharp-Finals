namespace Battleship
{
    internal class Ships
    {
        private int x, y, pos, shiplength;
        private List<Point> tempship = new List<Point>(); //Temporary ship position if valid will be added to placed
        private List<Point> placed = new List<Point>(); //Already existing ships in map
        private List<List<Point>> available= new List<List<Point>>();
        private Random r = new Random();

        public Ships() { }

        public void spawnShips() //Spawn all the exercise specific ships at once
        {
            spawnPlaneCarrier();
            spawnDestroyer();
            spawnWarship();
            spawnSubmarine();
        }
        public void spawnPlaneCarrier()
        {
            shiplength = 5;
            positionShip(shiplength);
        }

        public void spawnDestroyer() 
        {
            shiplength = 4;
            positionShip(shiplength);
        }

        public void spawnWarship() 
        { 
            shiplength = 3;
            positionShip(shiplength);
        }

        public void spawnSubmarine() 
        { 
            shiplength = 2;
            positionShip(shiplength);
        }

        protected void positionShip(int shiplength)
        {

            bool foundplace = false;
       
            while (foundplace == false)
            {
                tempship = new List<Point>();
                x = r.Next(0, 10);
                y = r.Next(0, 10);
                pos = r.Next(0, 2);
                if (pos == 0) //if pos 0 allign horizontally else vertically
                {
                    if (x + shiplength <= 9)
                    {
                        for (int i = x; i < x+shiplength; i++)
                        {
                            tempship.Add(new Point(i, y));
                        }
                    }
                }
                else
                {
                    if (y + shiplength <= 9)
                    {
                        for (int i = y; i < y+shiplength; i++)
                        {
                            tempship.Add(new Point(x, i));
                        }
                    }
                }

                foreach (Point p in tempship)
                {
                    if (placed.Contains(p))
                    {
                        foundplace = false;
                        break;
                    }
                    else
                    {
                        foundplace = true;
                    }
                }
                
            }  
            foreach(Point p in tempship)
            {
                placed.Add(p);
            }
            available.Add(tempship);

        }

        public List<Point> getLocations()
        {
            return (placed); //Returns placed ship locations 
        }

        public List<List<Point>> getAvailableShip()
        {
            return (available);
        }
    }
}
