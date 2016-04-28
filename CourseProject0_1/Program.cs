using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseProject0_1
{
    class GlobalVariables
    {
        public static List<List<Player>> ListPlayerInDiscypline;
        public static MainForm MainFormObject;
        public static float[][] ArrayCoordsPentagons;
        public static int CheckOnRefreshPicturePentagonLeft;
        public static int CheckOnRefreshPicturePentagonRight;
        public static string SelectedDiscypline;

        public static object MessageErrorData()
        {
            DialogResult result = MessageBox.Show("Исходные данные ошибочные", "Ошибка в текстовом файле", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (result == DialogResult.OK)
            {
                return null;
            }
            return null;
        }
        public static DialogResult MessageErrorDataPicture()
        {
            return MessageBox.Show("Указаный графический файл не найден", "Ошибка, файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void DrawingPentagonPlayer(PictureBox PictureBoxPentagon, int[] SelectedPlayerPentagon, Pen Colour)
        {
            Graphics g = PictureBoxPentagon.CreateGraphics();
            g.DrawLine
            (
                Colour,
                ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][0],
                ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][1],
                ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][2],
                ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][3]
            );
            g.DrawLine
            (
                Colour,
                ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][2],
                ArrayCoordsPentagons[SelectedPlayerPentagon[1] - 1][3],
                ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][4],
                ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][5]
            );
            g.DrawLine
            (
                Colour,
                ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][4],
                ArrayCoordsPentagons[SelectedPlayerPentagon[2] - 1][5],
                ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][6],
                ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][7]
            );
            g.DrawLine
            (
                Colour,
                ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][6],
                ArrayCoordsPentagons[SelectedPlayerPentagon[3] - 1][7],
                ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][8],
                ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][9]
            );
            g.DrawLine
            (
                Colour,
                ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][8],
                ArrayCoordsPentagons[SelectedPlayerPentagon[4] - 1][9],
                ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][0],
                ArrayCoordsPentagons[SelectedPlayerPentagon[0] - 1][1]
            );
        }
    }
    class MethodsReadFile
    {
        public static string[] ReadFile()
        {
            return File.ReadAllLines(Environment.CurrentDirectory + @"\textfiles\ListPlayer.txt");
        }
        public static Player CreateObjectPlayer(string[] LinesFile, int IndexStart, int IndexEnd)
        {
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
                "NumberGames",
                "ProcentWinGames",
                "MMR",
                "Pentagon",
                "PhotoProfile",
            };
            object[] ValueFild = new object[NameField.Length];
            string tempString;
            string[] tempStringArray;
            int[] tempIntArray;
            int templastIndex;
            int tempIndexNameField = 0;

            for (int i = IndexStart; i < IndexEnd; i++)
            {
                switch (NameField[tempIndexNameField])
                {
                    case "Signature":
                        tempString = LinesFile[i].Substring(LinesFile[i].IndexOf(NameField[tempIndexNameField]) + NameField[tempIndexNameField].Length + 3);
                        if (tempString == "" || tempString[0] != '[' || tempString[tempString.Length - 1] != ']')
                        {
                            return (Player)GlobalVariables.MessageErrorData();
                        }
                        tempStringArray = tempString.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            tempStringArray[0] = tempStringArray[0].Substring(1);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            return (Player)GlobalVariables.MessageErrorData();
                        }
                        templastIndex = tempStringArray.Length - 1;
                        tempStringArray[templastIndex] = tempStringArray[templastIndex].Substring(0, tempStringArray[templastIndex].Length - 1);
                        ValueFild[tempIndexNameField] = tempStringArray;
                        break;
                    case "Pentagon":
                        tempString = LinesFile[i].Substring(LinesFile[i].IndexOf(NameField[tempIndexNameField]) + NameField[tempIndexNameField].Length + 3);
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
                        ValueFild[tempIndexNameField] = tempIntArray;
                        break;
                    default:
                        ValueFild[tempIndexNameField] = LinesFile[i].Substring(LinesFile[i].IndexOf(NameField[tempIndexNameField]) + NameField[tempIndexNameField].Length + 3);
                        break;
                }
                tempIndexNameField++;
            }
            Player tempPlayer = new Dota2Player(ValueFild);
            return tempPlayer;
        }
        public static List<List<Player>> CreateListPlayer()
        {
            List<List<Player>> ListDiscyplineListPlayer = new List<List<Player>>();
            List<Player> TempListPlayer = new List<Player>();
            string[] LinesFile = ReadFile();
            int IndexStart = 1;
            int IndexEnd;
            int i = 0;
            foreach (string Line in LinesFile)
            {
                if (Line.IndexOf('*') == 1)
                {
                    IndexEnd = i;
                    TempListPlayer.Add(CreateObjectPlayer(LinesFile, IndexStart, IndexEnd));
                    IndexStart = IndexEnd + 1;
                }
                if (Line.IndexOf('@') == 0)
                {
                    IndexEnd = i;
                    TempListPlayer.Add(CreateObjectPlayer(LinesFile, IndexStart, IndexEnd));
                    ListDiscyplineListPlayer.Add(TempListPlayer);
                    IndexStart = IndexEnd + 2;
                    TempListPlayer = new List<Player>();
                }
                if (i == LinesFile.Length - 1)
                {
                    IndexEnd = i + 1;
                    TempListPlayer.Add(CreateObjectPlayer(LinesFile, IndexStart, IndexEnd));
                    ListDiscyplineListPlayer.Add(TempListPlayer);
                }
                i++;
            }

            return ListDiscyplineListPlayer;
        }
        /*
        public static string ReadFile1()
        {
            return File.ReadAllText(Environment.CurrentDirectory + @"\textfiles\ListPlayer.txt");
        }
        public static string[] SplitOnDiscypline1(string textFile)
        {
            string[] ArrayDiscypline = textFile.Split('@');
            return ArrayDiscypline;
        }
        public static string[] SplitOnPlayer1(string textDiscypline)
        {
            string[] ArrayPlayer = textDiscypline.Split('*');
            return ArrayPlayer;
        }
        public static Player CreateObjectPlayer1(string TextPlayer)
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
                "NumberGames",
                "ProcentWinGames",
                "MMR",
                "Pentagon",
                "PhotoProfile",
            };
            //GlobalVariables.NameFieldInClassPlayer = NameField;
            object[] ValueFild = new object[NameField.Length];
            string tempString;
            string[] tempStringArray;
            int[] tempIntArray;
            int templastIndex;

            List<List<Player>> ListPlayerInDiscypline = new List<List<Player>>();
            List<Player> ListPlayer = new List<Player>();

            for (int i = 0; i < SplitOnPrompt.Length - 1; i++)
            {
                switch (NameField[i])
                {
                    case "Signature":
                        tempString = SplitOnPrompt[i].Substring(SplitOnPrompt[i].IndexOf(NameField[i]) + NameField[i].Length + 3);
                        if (tempString == "" || tempString[0] != '[' || tempString[tempString.Length - 1] != ']')
                        {
                            return (Player)GlobalVariables.MessageErrorData();
                        }
                        tempStringArray = tempString.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        try
                        {
                            tempStringArray[0] = tempStringArray[0].Substring(1);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            return (Player)GlobalVariables.MessageErrorData();
                        }
                        templastIndex = tempStringArray.Length - 1;
                        tempStringArray[templastIndex] = tempStringArray[templastIndex].Substring(0, tempStringArray[templastIndex].Length - 1);
                        ValueFild[i] = tempStringArray;
                        break;
                    case "Pentagon":
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
        public static List<List<Player>> CreateListPlayer1()
        {
            string TextFile = ReadFile1();
            string[] ArrayDiscypline = SplitOnDiscypline1(TextFile);
            string[][] ArrayArraysPlayerInDiscypline = new string[ArrayDiscypline.Length][];
            int i = 0;
            foreach (string discypline in ArrayDiscypline)
            {
                ArrayArraysPlayerInDiscypline[i] = SplitOnPlayer1(discypline);
                i++;
            }

            List<List<Player>> ListDiscyplineListPlayer = new List<List<Player>>();
            List<Player> ListPlayer = new List<Player>();
            i = 0;
            foreach (string[] disciplin in ArrayArraysPlayerInDiscypline)
            {
                foreach (string Player in disciplin)
                {
                    Player tempPlayer = CreateObjectPlayer1(Player);
                    if (tempPlayer == null)
                    {
                        return null;
                    }
                    ListPlayer.Add(tempPlayer);
                }
                ListDiscyplineListPlayer.Add(ListPlayer);
                ListPlayer = new List<Player>();
            }
            return ListDiscyplineListPlayer;
        }
        */
    }

    abstract class Player
    {
        private string name;
        private string nickname;
        private string surname;
        private string team;
        private string country;
        private string city;
        private string nationality;
        private DateTime dateBirth;
        private int age;
        private string role;
        private string[] signature;
        private int numberGames;
        private double procentWinGames;
        private string mmr;
        private int[] pentagon;
        private string photoProfile;

        public Player(object[] ArrayFilds)
        {
            Name = (string)ArrayFilds[0];
            Nickname = (string)ArrayFilds[1];
            Surname = (string)ArrayFilds[2];
            Team = (string)ArrayFilds[3];
            Country = (string)ArrayFilds[4];
            City = (string)ArrayFilds[5];
            Nationality = (string)ArrayFilds[6];
            string[] tempStringDateBirth = ((string)ArrayFilds[7]).Split('.');
            int tempYear = Convert.ToInt32(tempStringDateBirth[2]);
            int tempMonth = Convert.ToInt32(tempStringDateBirth[1]);
            int tempDay = Convert.ToInt32(tempStringDateBirth[0]);
            DateBirth = new DateTime(tempYear, tempMonth, tempDay);
            Age = DateTime.Today.Year - DateBirth.Year;
            if (DateBirth > DateTime.Today.AddYears(-Age))
            {
                Age--;
            }
            Role = (string)ArrayFilds[8];
            Signature = (string[])ArrayFilds[9];
            NumberGames = Convert.ToInt32((string)ArrayFilds[10]);
            ProcentWinGames = Convert.ToDouble((string)ArrayFilds[11]);
            MMR = (string)ArrayFilds[12];
            Pentagon = (int[])ArrayFilds[13];
            PhotoProfile = (string)ArrayFilds[14];
        }
        public Player(string name, string nickname, string surname, string team)
        {
            Name = name;
            Nickname = nickname;
            Surname = surname;
            Team = team;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }
        public string Nickname
        {
            get
            {
                return nickname;
            }
            private set
            {
                nickname = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            private set
            {
                surname = value;
            }
        }
        public string Team
        {
            get
            {
                return team;
            }
            private set
            {
                team = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            private set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            private set
            {
                city = value;
            }
        }
        public string Nationality
        {
            get
            {
                return nationality;
            }
            private set
            {
                nationality = value;
            }
        }
        public DateTime DateBirth
        {
            get
            {
                return dateBirth;
            }
            private set
            {
                dateBirth = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set
            {
                age = value;
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
            private set
            {
                role = value;
            }
        }
        public string[] Signature
        {
            get
            {
                return signature;
            }
            private set
            {
                signature = value;
            }
        }
        public int NumberGames
        {
            get
            {
                return numberGames;
            }
            private set
            {
                numberGames = value;
            }
        }
        public double ProcentWinGames
        {
            get
            {
                return procentWinGames;
            }
            private set
            {
                procentWinGames = value;
            }
        }
        public string MMR
        {
            get
            {
                return mmr;
            }
            private set
            {
                mmr = value;
            }
        }
        public int[] Pentagon
        {
            get
            {
                return pentagon;
            }
            private set
            {
                pentagon = value;
            }
        }
        public string PhotoProfile
        {
            get
            {
                return photoProfile;
            }
            private set
            {
                photoProfile = value;
            }
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
            rez += DateBirth.ToString() + ' ';
            rez += Age;
            rez += ' ';
            rez += Role + ' ';
            foreach (string element in Signature)
            {
                rez += element + ' ';
            }
            rez += NumberGames;
            rez += ' ';
            rez += ProcentWinGames;
            rez += ' ';
            rez += MMR + ' ';
            rez += ' ';
            foreach (int element in Pentagon)
            {
                rez += element;
                rez += ' ';
            }
            rez += PhotoProfile;
            return rez;
        }
        public string MMRInfo()
        {
            string rez = "";
            rez += MMR + ' ';
            rez += Name + ' ';
            rez += Nickname + ' ';
            rez += Surname;
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
            GlobalVariables.ListPlayerInDiscypline = MethodsReadFile.CreateListPlayer();
            GlobalVariables.CheckOnRefreshPicturePentagonLeft = 0;
            GlobalVariables.CheckOnRefreshPicturePentagonLeft = 0;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (GlobalVariables.ListPlayerInDiscypline != null)
            {
                GlobalVariables.MainFormObject = new MainForm();
                Application.Run(GlobalVariables.MainFormObject);
            }
            //GlobalVariables.MainFormObject = new MainForm();
            //Application.Run(GlobalVariables.MainFormObject);
        }
    }
}
