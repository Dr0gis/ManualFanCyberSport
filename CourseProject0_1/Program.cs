using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseProject0_1
{
    class MethodsReadFile
    {
        public static string ReadFile()
        {
            return File.ReadAllText(@"C:\Users\ІгорСушинський\OneDrive\Документы\Visual Studio 2015\Projects\CourseProject0_1\ListPlayer.txt");
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
            string temp = "";
            string tempName = "";
            string tempNickname = "";
            string tempSurname = "";
            string tempTeam = "";
            string tempCountry = "";
            string tempCity = "";
            string tempNationality = "";
            string tempDateBirth = "";
            string tempRole = "";
            string[] tempSignature = new string[3];
            string[] tempHistoryTeams;
            string tempNumberGames = "";
            double ProcentWinGames = 0;
            string MMR = "";
            List <List<Player>> ListPlayerInDiscypline = new List<List<Player>>();
            List<Player> ListPlayer = new List<Player>();

            for (int i = 0; i < TextPlayer.Length; i++)
            {
                if (TextPlayer[i] == 'N' && TextPlayer[i + 1] == 'a' && TextPlayer[i + 2] == 'm' && TextPlayer[i + 3] == 'e' && TextPlayer[i - 1] == '\t')
                {
                    for (int j = 7; true; j++)
                    {
                        if (TextPlayer[i + j] == ';')
                        {
                            break;
                        }
                        tempName += TextPlayer[i + j];
                    }
                }
                if (TextPlayer[i] == 'N' && TextPlayer[i + 1] == 'i' && TextPlayer[i + 2] == 'c' && TextPlayer[i + 3] == 'k' && TextPlayer[i - 1] == '\t')
                {
                    for (int j = 11; true; j++)
                    {
                        if (TextPlayer[i + j] == ';')
                        {
                            break;
                        }
                        tempNickname += TextPlayer[i + j];
                    }
                }
                if (TextPlayer[i] == 'S' && TextPlayer[i + 1] == 'u' && TextPlayer[i + 2] == 'r' && TextPlayer[i + 3] == 'n' && TextPlayer[i - 1] == '\t')
                {
                    for (int j = 10; true; j++)
                    {
                        if (TextPlayer[i + j] == ';')
                        {
                            break;
                        }
                        tempSurname += TextPlayer[i + j];
                    }
                }
                if (TextPlayer[i] == 'T' && TextPlayer[i + 1] == 'e' && TextPlayer[i + 2] == 'a' && TextPlayer[i + 3] == 'm' && TextPlayer[i - 1] == '\t')
                {
                    for (int j = 7; true; j++)
                    {
                        if (TextPlayer[i + j] == ';')
                        {
                            break;
                        }
                        tempTeam += TextPlayer[i + j];
                    }
                }
            }
            Player tempPlayer = new Dota2Player(tempName, tempNickname, tempSurname, tempTeam);
            return tempPlayer;
        }
        public static List<List<Player>> CreateListPlayer()
        {
            //List<string[]> ListPlayer = new List<string[]>();

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
        public string Name;
        public string Nickname;
        public string Surname;
        public string Team;
        public string Country;
        public string City;
        public string Nationality;
        public string DateBirth;
        public string Role;
        public string[] Signature;
        public string[] HistoryTeams;
        public int NumberGames;
        public double ProcentWinGames;
        public string MMR;

        public string MajorInfo()
        {
            string rez = "";
            rez += Name + ' ';
            rez += Nickname + ' ';
            rez += Surname + ' ';
            rez += Team + ' ';
            return rez;
        }
    }

    class Dota2Player : Player
    {
        public Dota2Player(string name, string nickname, string surname, string team)
        {
            Name = name;
            Nickname = nickname;
            Surname = surname;
            Team = team;
        }
    }

    class CSGOPlayer : Player
    {
        public CSGOPlayer(string name, string nickname, string surname, string team)
        {
            Name = name;
            Nickname = nickname;
            Surname = surname;
            Team = team;
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
