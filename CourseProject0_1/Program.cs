using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseProject0_1
{
    class GlobalVariables
    {
        public static List<List<Player>> ListPlayerInDiscypline;
    }
    class MethodsReadFile
    {
        public static string ReadFile()
        {
            return File.ReadAllText(@"C:\Users\Dr0gis\OneDrive\Документы\Visual Studio 2015\Projects\CourseProject0_1\ListPlayer.txt");
        }
        public static string[] SplitOnDiscypline(string textFile)
        {
            string[] ArrayDiscypline = textFile.Split('@');
            return ArrayDiscypline;
        }
        public static string[] SplitOnPlayer(string textDiscypline)
        {
            string[] ArrayPlayer = textDiscypline.Split('*');
            return ArrayPlayer;
        }
        public static Player CreateObjectPlayer(string TextPlayer)
        {
            string[] SplitOnPrompt = TextPlayer.Split(';');
            string[] NameField = new string[] 
            {
                "Name",
                "Nickname",
                "Surname",
                "Team",
                "Country",
                "City",
                "Nationality",
                "DateBirth",
                "Role",
                "Signature",
                "HistoryTeams",
                "NumberGames",
                "ProcentWinGames",
                "MMR",
                "Hexagon",
            };
            object[] ValueFild = new object[NameField.Length];
            string tempString;
            string[] tempStringArray;
            int[] tempIntArray;
            int templastIndex;

            List <List<Player>> ListPlayerInDiscypline = new List<List<Player>>();
            List<Player> ListPlayer = new List<Player>();

            for (int i = 0; i < SplitOnPrompt.Length - 1; i++)
            {
                switch (NameField[i])
                {
                    case "Signature":
                        tempString = SplitOnPrompt[i].Substring(SplitOnPrompt[i].IndexOf(NameField[i]) + NameField[i].Length + 3);
                        tempStringArray = tempString.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        tempStringArray[0] = tempStringArray[0].Substring(1);
                        templastIndex = tempStringArray.Length - 1;
                        tempStringArray[templastIndex] = tempStringArray[templastIndex].Substring(0, tempStringArray[templastIndex].Length - 1);
                        ValueFild[i] = tempStringArray;
                        break;
                    case "HistoryTeams":
                        tempString = SplitOnPrompt[i].Substring(SplitOnPrompt[i].IndexOf(NameField[i]) + NameField[i].Length + 3);
                        tempStringArray = tempString.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        tempStringArray[0] = tempStringArray[0].Substring(1);
                        templastIndex = tempStringArray.Length - 1;
                        tempStringArray[templastIndex] = tempStringArray[templastIndex].Substring(0, tempStringArray[templastIndex].Length - 1);
                        ValueFild[i] = tempStringArray;
                        break;
                    case "Hexagon":
                        tempString = SplitOnPrompt[i].Substring(SplitOnPrompt[i].IndexOf(NameField[i]) + NameField[i].Length + 3);
                        tempStringArray = tempString.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        tempStringArray[0] = tempStringArray[0].Substring(1);
                        templastIndex = tempStringArray.Length - 1;
                        tempStringArray[templastIndex] = tempStringArray[templastIndex].Substring(0, tempStringArray[templastIndex].Length - 1);
                        tempIntArray = new int[tempStringArray.Length];
                        int j = 0;
                        foreach (string element in tempStringArray)
                        {
                            tempIntArray[j] = Convert.ToInt32(element);
                            j++;
                        }
                        ValueFild[i] = tempIntArray;
                        break;
                    default:
                        ValueFild[i] = SplitOnPrompt[i].Substring(SplitOnPrompt[i].IndexOf(NameField[i]) + NameField[i].Length + 3);
                        break;
                }
            }
            Player tempPlayer = new Dota2Player(ValueFild);
            return tempPlayer;
        }
        public static List<List<Player>> CreateListPlayer()
        {
            string TextFile = ReadFile();
            string[] ArrayDiscypline = SplitOnDiscypline(TextFile);
            string[][] ArrayArraysPlayerInDiscypline = new string[ArrayDiscypline.Length][];
            int i = 0;
            foreach (string discypline in ArrayDiscypline)
            {
                ArrayArraysPlayerInDiscypline[i] = SplitOnPlayer(discypline);
                i++;
            }

            List<List<Player>> ListDiscyplineListPlayer = new List<List<Player>>();
            List<Player> ListPlayer = new List<Player>();
            i = 0;
            foreach (string[] disciplin in ArrayArraysPlayerInDiscypline)
            {
                foreach (string Player in disciplin)
                {
                    ListPlayer.Add(CreateObjectPlayer(Player));
                }
                ListDiscyplineListPlayer.Add(ListPlayer);
                ListPlayer = new List<Player>();
            }
            return ListDiscyplineListPlayer;
        }
    }

    abstract class Player
    {
        private string Name;
        private string Nickname;
        private string Surname;
        private string Team;
        private string Country;
        private string City;
        private string Nationality;
        private string DateBirth;
        private string Role;
        private string[] Signature;
        private string[] HistoryTeams;
        private int NumberGames;
        private double ProcentWinGames;
        private string MMR;
        private int[] Hexagon;

        public Player(object[] ArrayFilds)
        {
            Name = (string)ArrayFilds[0];
            Nickname = (string)ArrayFilds[1];
            Surname = (string)ArrayFilds[2];
            Team = (string)ArrayFilds[3];
            Country = (string)ArrayFilds[4];
            City = (string)ArrayFilds[5];
            Nationality = (string)ArrayFilds[6];
            DateBirth = (string)ArrayFilds[7];
            Role = (string)ArrayFilds[8];
            Signature = (string[])ArrayFilds[9];
            HistoryTeams = (string[])ArrayFilds[10];
            NumberGames = Convert.ToInt32((string)ArrayFilds[11]);
            ProcentWinGames = Convert.ToDouble((string)ArrayFilds[12]);
            MMR = (string)ArrayFilds[13];
            Hexagon = (int[])ArrayFilds[14];
        }
        public Player(string name, string nickname, string surname, string team)
        {
            Name = name;
            Nickname = nickname;
            Surname = surname;
            Team = team;
        }
        public string MajorInfo()
        {
            string rez = "";
            rez += Name + ' ';
            rez += Nickname + ' ';
            rez += Surname;
            return rez;
        }
        public string AllInfo()
        {
            string rez = "";
            rez += Name + ' ';
            rez += Nickname + ' ';
            rez += Surname + ' ';
            rez += Team + ' ';
            rez += Country + ' ';
            rez += City + ' ';
            rez += Nationality + ' ';
            rez += DateBirth + ' ';
            rez += Role + ' ';
            foreach (string element in Signature)
            {
                rez += element + ' ';
            }
            foreach (string element in HistoryTeams)
            {
                rez += element + ' ';
            }
            rez += ProcentWinGames;
            rez += ' ';
            rez += MMR + ' ';
            rez += ' ';
            foreach (int element in Hexagon)
            {
                rez += element;
                rez += ' ';
            }
            return rez;
        }
    }

    class Dota2Player : Player
    {
        public Dota2Player(object[] ArrayFilds) : base(ArrayFilds)
        {
        }
        public Dota2Player(string name, string nickname, string surname, string team) : base(name, nickname, surname, team)
        {
        }
    }

    class CSGOPlayer : Player
    {
        public CSGOPlayer(object[] ArrayFilds) : base(ArrayFilds)
        {
        }
        public CSGOPlayer(string name, string nickname, string surname, string team) : base(name, nickname, surname, team)
        {
        }
    }

    class Methods
    {
        public static void EnterDataProgram()
        {
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
