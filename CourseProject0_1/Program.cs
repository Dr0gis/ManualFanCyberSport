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
    class MethodsWorkWithFile
    {
        public static string[] ReadAllLinesFile()
        {
            return File.ReadAllLines(Environment.CurrentDirectory + @"\textfiles\ListPlayer.txt");
        }
        public static string ReadAllTextFile()
        {
            return File.ReadAllText(Environment.CurrentDirectory + @"\textfiles\ListPlayer.txt");
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
            string[] LinesFile = ReadAllLinesFile();
            int IndexStart = 1;
            int IndexEnd;
            int i = 0;
            foreach (string Line in LinesFile)
            {
                if (Line.IndexOf('*') == 1)
                {
                    IndexStart = i + 1;
                    IndexEnd = IndexStart + 15;
                    TempListPlayer.Add(CreateObjectPlayer(LinesFile, IndexStart, IndexEnd));
                }
                if (Line.IndexOf('@') == 0)
                {
                    ListDiscyplineListPlayer.Add(TempListPlayer);
                    TempListPlayer = new List<Player>();
                }
                if (i == LinesFile.Length - 1)
                {
                    ListDiscyplineListPlayer.Add(TempListPlayer);
                }
                i++;
            }

            return ListDiscyplineListPlayer;
        }
        public static void WriteFile(Dota2Player Dota2Player)
        {
            string AllFile = ReadAllTextFile();
            string[] SplitOnDiscypline = AllFile.Split('@');
            SplitOnDiscypline[0] += Dota2Player.AllInfoForWriteInFile();
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\textfiles\Example.txt", false))
            {
                sw.Write(SplitOnDiscypline[0]);
                sw.Write("\r\n@");
                sw.Write(SplitOnDiscypline[1]);
            }
        }
        public static void WriteFile(CSGOPlayer CSGOPlayer)
        {
            string AllFile = ReadAllTextFile();
            string[] SplitOnDiscypline = AllFile.Split('@');
            SplitOnDiscypline[1] += CSGOPlayer.AllInfoForWriteInFile();
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\textfiles\Example.txt", false))
            {
                sw.Write(SplitOnDiscypline[0]);
                sw.Write("\r\n@");
                sw.Write(SplitOnDiscypline[1]);
            }
        }
        public static string[] RemovePlayerInFile(Player Player)
        {
            string[] AllLineFile = ReadAllLinesFile();
            string[] NewLineFie = new string[AllLineFile.Length - 15];
            //int i = 0;
            int indexStart = 0;
            int indexEnd = 0;
            int index = 0;
            foreach (string Line in AllLineFile)
            {
                index = Line.IndexOf(Player.Nickname);
                if (index == 13)
                {
                    break;
                }
                indexStart++;
            }
            if (indexStart >= AllLineFile.Length)
            {
                return null;
            }
            indexStart -= 1;
            indexEnd = indexStart + 15;

            int j = 0;
            for (int i = 0; i < indexStart; i++)
            {
                NewLineFie[i] = AllLineFile[i];
                j = i;
            }
            for (int i = indexEnd; i < AllLineFile.Length; i++)
            {
                NewLineFie[j] = AllLineFile[i];
                j++;
            }

            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\textfiles\Example.txt", false))
            {
                int i = 0;
                foreach (string Line in NewLineFie)
                {
                    if (i == NewLineFie.Length - 1)
                    {
                        sw.Write(Line);
                        break;
                    }
                    sw.WriteLine(Line);
                    i++;
                }
            }
            return NewLineFie;
        }
        public static void EditFile(Dota2Player Player)
        {
            RemovePlayerInFile(Player);
            WriteFile(Player);
        }
        public static void EditFile(CSGOPlayer Player)
        {
            RemovePlayerInFile(Player);
            WriteFile(Player);
        }
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
        public string AllInfoForWriteInFile()
        {
            string rez = "";
            rez += "\t";
            rez += '*';

            rez += "\r\n";
            rez += "\t\t";
            rez += "Name = ";
            rez += Name;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Nickname = ";
            rez += Nickname;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Surname = ";
            rez += Surname;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Team = ";
            rez += Team;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Country = ";
            rez += Country;

            rez += "\r\n";
            rez += "\t\t";
            rez += "City = ";
            rez += City;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Nationality = ";
            rez += Nationality;

            rez += "\r\n";
            rez += "\t\t";
            rez += "DateBirth = ";
            rez += ((DateBirth.Day < 10) ? "0" + DateBirth.Day + "." : DateBirth.Day + ".") + ((DateBirth.Month < 10) ? "0" + DateBirth.Month + "." : DateBirth.Month + ".") + DateBirth.Year;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Role = ";
            rez += Role;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Signature = [";
            rez += string.Join(", ", Signature);
            rez += ']';

            rez += "\r\n";
            rez += "\t\t";
            rez += "NumberGames = ";
            rez += NumberGames;

            rez += "\r\n";
            rez += "\t\t";
            rez += "ProcentWinGames = ";
            rez += ProcentWinGames;

            rez += "\r\n";
            rez += "\t\t";
            rez += "MMR = ";
            rez += MMR;

            rez += "\r\n";
            rez += "\t\t";
            rez += "Pentagon = [";
            rez += string.Join(", ", Pentagon);
            rez += ']';

            rez += "\r\n";
            rez += "\t\t";
            rez += "PhotoProfile = ";
            rez += PhotoProfile;

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
            GlobalVariables.ListPlayerInDiscypline = MethodsWorkWithFile.CreateListPlayer();
            GlobalVariables.CheckOnRefreshPicturePentagonLeft = 0;
            GlobalVariables.CheckOnRefreshPicturePentagonLeft = 0;
            //MethodsWorkWithFile.WriteFile((Dota2Player)GlobalVariables.ListPlayerInDiscypline[0][5]);
            //MethodsWorkWithFile.WriteFile((Dota2Player)GlobalVariables.ListPlayerInDiscypline[0][0]);
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
