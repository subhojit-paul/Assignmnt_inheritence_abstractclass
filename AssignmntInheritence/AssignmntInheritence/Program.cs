using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmntInheritence
{

    class Game
    {
        public int noOfPlayers;
        public string country;

        public int NoOfPlayers
        {
            get { return noOfPlayers; }
            set { noOfPlayers = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public Game()
        {

        }
        public Game(int _noOfPlayer, string _country)
        {
            noOfPlayers = _noOfPlayer;
            country = _country;

        }

        public void WorldCup(string country, string game)
        {
            //DateTime now = DateTime.Now;
            Console.WriteLine("{0} have won the {1} World Cup {2} ", country, game, DateTime.Now.ToString("yyyy"));
        }

    }

    class Cricket : Game
    {
        public string coachName;
        public string CoachName
        {
            get { return coachName; }
            set { coachName = value; }
        }
        public Cricket()
        {

        }
        public Cricket(int _players, string _country, string _coachName) : base(_players, _country)
        {
            coachName = _coachName;

        }



        class Football : Game
        {
            public string leagueName;
            public string LeagueName
            {
                get { return leagueName; }
                set { leagueName = value; }
            }
            public Football()
            {

            }
            public Football(int _players, string _country, string _leagueName) : base(_players, _country)
            {
                leagueName = _leagueName;
            }

        }

        class ShowGameDetails
        {
            public void ShowCricketDetails(int noOfPlayers, string country, string coachName)
            {

                Console.WriteLine("Country: {0} No of Players: {1} Coach Name: {2}", country, noOfPlayers, coachName);
            }

            public void ShowFootballDetails(int noOfPlayers, string country, string leagueName)
            {

                Console.WriteLine("Country: {0} No of Players: {1} League Name: {2}", country, noOfPlayers, leagueName);

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Cricket India = new Cricket();
                Cricket Australia = new Cricket();

                Football Spain = new Football();
                Football England = new Football();

                ShowGameDetails show = new ShowGameDetails();
                Console.WriteLine("------------Cricket Information----------");
                show.ShowCricketDetails(11, "India", "John Wright");
                show.ShowCricketDetails(11, "Australia", "John Buchanan");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------FootBall Information----------");
                show.ShowFootballDetails(11, "Spain", "Spanish League");
                show.ShowFootballDetails(11, "England", "English Premiur League");
                Console.WriteLine();
                Console.WriteLine();
                Game obj = new Game();
                obj.WorldCup("India", "Cricket");
                obj.WorldCup("Spain", "Football");

                Console.Read();

            }
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MultilevelInheritance
//{

//    public class Game
//    {
//        public int noOfPlayers;
//        public string country;
//        public string CurrentYear = DateTime.UtcNow.ToString("yyyy");
//        public Game()
//        {

//        }
//        public Game(int _noOfPlayers, string _country)
//        {
//            noOfPlayers = _noOfPlayers;
//            country = _country;
//        }
//        public void WorldCup(string country, int CurrentYear)
//        {
//            Console.WriteLine(" {0} have won WorldCup-{1}", country, CurrentYear);
//        }
//    }
//    public class Criket : Game
//    {
//        public string coachName;
//        public Criket()
//        {

//        }
//        public Criket(int _noOfPlayers, string _country, string _coach) : base(_noOfPlayers, _country)
//        {

//        }

//    }
//    class FootBall : Game
//    {
//        public string LeagueName;

//        public FootBall()
//        {

//        }
//        public FootBall(int _noOfPlayers, string _country, string _LeagueName) : base(_noOfPlayers, _country)
//        {
//            LeagueName = _LeagueName;
//        }
//    }
//    class ShowGameDetails
//    {
//        public void ShowCricketDetails(string country, int noOfPlayers, string Coach)
//        {
//            //Console.WriteLine("---------------CricketDetails----------------");
//            Console.WriteLine("Country: {0} No of Players :{1} Coach :{2} ", country, noOfPlayers, Coach);
//        }
//        public void ShowFootBallDetails(string country, int noOfPlayers, string Coach)
//        {
//            //Console.WriteLine("====================FootBall Details===============================");
//            Console.WriteLine("Country: {0} No of Players :{1} Coach :{2} ", country, noOfPlayers, Coach);
//        }
//    }




//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Criket India = new Criket();
//            Criket Australia = new Criket();
//            FootBall Spain = new FootBall();
//            FootBall England = new FootBall();
//            ShowGameDetails show = new ShowGameDetails();
//            Console.WriteLine("===========Cricket Details======================");
//            show.ShowCricketDetails("India", 11, "SAchin");
//            show.ShowCricketDetails("Australia", 11, "SAchin");
//            Console.WriteLine("===============Foot Ball Details=================");

//            show.ShowFootBallDetails("Australia", 8, "Dhoni");
//            show.ShowFootBallDetails("Spain", 8, "Dhoni");

//            Game G = new Game();
//            Console.WriteLine("                               ");


//            Australia.WorldCup("Australia", 2007);
//            Spain.WorldCup("Spain", 20007);


//            Console.Read();

//        }
//    }
//}




