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
        public static List<List<Player>> ListPlayerInDiscyplineSearched;

        public static List<string> ListCountry;
        public static List<string> ListTeam;
        public static List<string> ListCity;
        public static List<string> ListAge;
        public static List<string> ListRole;
        public static List<string> ListHero;

        public static Dota2Player PlayerDota2Clear
        {
            get
            {
                Dota2Player tempPlayer = new Dota2Player(new object[] {"", "", "", "", "", "", "", "0001.01.01", "", new string[] { "Abaddon", "Abaddon", "Abaddon" }, "0", "0", "", new int[] { 1, 1, 1, 1, 1 }, "default.png" });
                return tempPlayer;
            }
        }
        public static CSGOPlayer PlayerCSGOClear
        {
            get
            {
                CSGOPlayer tempPlayer = new CSGOPlayer(new object[] { "", "", "", "", "", "", "", "0001.01.01", "", new string[] { "AK-47", "AK-47", "AK-47" }, "0", "0", "", new int[] { 1, 1, 1, 1, 1 }, "default.png" });
                return tempPlayer;
            }
        }
        public static Dota2Player MyProfileDota2;
        public static CSGOPlayer MyProfileCSGO;

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

        public static bool FormMyProfileDota2Opened;
        public static bool FormMyProfileCSGOOpened;
    }
    class MethodsWorkWithFile
    {
        public static string[] ReadAllLinesFile(string NameFile)
        {
            return File.ReadAllLines(Environment.CurrentDirectory + @"\textfiles\" + NameFile);
        }
        public static string ReadAllTextFile(string NameFile)
        {
            return File.ReadAllText(Environment.CurrentDirectory + @"\textfiles\" + NameFile);
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
            string[] LinesFile = ReadAllLinesFile("ListPlayer.txt");
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

        public static void AddLists(string country, List<string> listCountry)
        {
            if (listCountry.IndexOf(country) == -1)
            {
                listCountry.Add(country);
            }
        }
        public static void CreateLists(List<List<Player>> ListPlayer)
        {
            List<string> ListCountry =  new List<string>();
            ListCountry.Add("All");
            List<string> ListTeam = new List<string>();
            ListTeam.Add("All");
            List<string> ListCity = new List<string>();
            ListCity.Add("All");
            //List<string> ListAge = new List<string>();
            List<string> ListRole = new List<string>();
            ListRole.Add("All");
            List<string> ListHero = new List<string>();
            ListHero.Add("All");

            foreach (List<Player> Discypline in ListPlayer)
            {
                foreach (Player Player in Discypline)
                {
                    AddLists(Player.Country, ListCountry);
                    AddLists(Player.Team, ListTeam);
                    AddLists(Player.City, ListCity);
                    //AddLists(Convert.ToString(Player.Age), ListAge);
                    AddLists(Player.Role, ListRole);
                }
            }
            string tempAgility = "Anti-Mage;Bloodseeker;Drow Ranger;Shadow Fiend;Juggernaut;Razor;Mirana;Venomancer;Morphling;Faceless Void;Phantom Lancer;Phantom Assassin;Vengeful Spirit;Viper;Riki;Clinkz;Sniper;Broodmother;Templar Assassin;Weaver;Luna;Spectre;Bounty Hunter;Nyx Assassin;Ursa;Meepo;Gyrocopter;Slark;Lone Druid;Medusa;Naga Siren;Terrorblade;Troll Warlord;Arc Warden;Ember Spirit";
            string tempStrength = "Earthshaker;Axe;Sven;Pudge;Tiny;Sand King;Kunkka;Slardar;Beastmaster;Tidehunter;Dragon Knight;Wraith King;Clockwerk;Lifestealer;Omniknight;Night Stalker;Huskar;Doom;Alchemist;Spirit Breaker;Brewmaster;Lycan;Treant Protector;Chaos Knight;Io;Undying;Centaur Warrunner;Magnus;Timbersaw;Abaddon;Bristleback;Tusk;Elder Titan;Legion Commander;Earth Spirit;Phoenix";
            string tempIntellect = "Crystal Maiden;Bane;Puck;Lich;Storm Spirit;Lion;Windranger;Witch Doctor;Zeus;Enigma;Lina;Necrophos;Shadow Shaman;Warlock;Tinker;Queen of Pain;Nature's Prophet;Death Prophet;Enchantress;Pugna;Jakiro;Dazzle;Chen;Leshrac;Silencer;Dark Seer;Ogre Magi;Batrider;Rubick;Ancient Apparition;Disruptor;Invoker;Keeper of the Light;Outworld Devourer;Skywrath Mage;Shadow Demon;Techies;Visage;Oracle;Winter Wyvern";

            string[] teamArrAgility = tempAgility.Split(';');
            string[] teamArrStrength = tempStrength.Split(';');
            string[] teamArrIntellect = tempIntellect.Split(';');

            ListHero.AddRange(teamArrAgility);
            ListHero.AddRange(teamArrStrength);
            ListHero.AddRange(teamArrIntellect);

            GlobalVariables.ListCountry = ListCountry;
            GlobalVariables.ListTeam = ListTeam;
            GlobalVariables.ListCity = ListCity;
            GlobalVariables.ListRole = ListRole;
            GlobalVariables.ListHero = ListHero;

        }

        public static void WriteFile(Dota2Player Dota2Player, string NameFile)
        {
            string AllFile = ReadAllTextFile(NameFile);
            string[] SplitOnDiscypline = AllFile.Split('@');
            SplitOnDiscypline[0] += Dota2Player.AllInfoForWriteInFile();
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\textfiles\" + NameFile, false))
            {
                sw.Write(SplitOnDiscypline[0]);
                sw.Write("\r\n@");
                sw.Write(SplitOnDiscypline[1]);
            }
        }
        public static void WriteFile(CSGOPlayer CSGOPlayer, string NameFile)
        {
            string AllFile = ReadAllTextFile(NameFile);
            string[] SplitOnDiscypline = AllFile.Split('@');
            SplitOnDiscypline[1] += CSGOPlayer.AllInfoForWriteInFile();
            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\textfiles\" + NameFile, false))
            {
                sw.Write(SplitOnDiscypline[0]);
                sw.Write("\r\n@");
                sw.Write(SplitOnDiscypline[1]);
            }
        }
        public static string[] RemovePlayerInFile(Player Player, string NameFile)
        {
            string[] AllLineFile = ReadAllLinesFile(NameFile);
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

            using (StreamWriter sw = new StreamWriter(Environment.CurrentDirectory + @"\textfiles\" + NameFile, false))
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
        public static void EditFile(Dota2Player PlayerOld, Dota2Player PlayerNew, string NameFile)
        {
            RemovePlayerInFile(PlayerOld, NameFile);
            WriteFile(PlayerNew, NameFile);
        }
        public static void EditFile(CSGOPlayer PlayerOld, CSGOPlayer PlayerNew, string NameFile)
        {
            RemovePlayerInFile(PlayerOld, NameFile);
            WriteFile(PlayerNew, NameFile);
        }

        public static Player[] ReadMyProfile()
        {
            Player[] MyProfiles = new Player[2];
            string[] AllLinesFile = File.ReadAllLines(Environment.CurrentDirectory + @"\textfiles\MyProfile.txt");

            string Dota2Name = AllLinesFile[2].Substring(9);
            string Dota2Nickname = AllLinesFile[3].Substring(13);
            string Dota2Surname = AllLinesFile[4].Substring(12);
            string Dota2Team = AllLinesFile[5].Substring(9);
            string Dota2Country = AllLinesFile[6].Substring(12);
            string Dota2City = AllLinesFile[7].Substring(9);
            string Dota2Nationality = AllLinesFile[8].Substring(16);
            string Dota2DateBirth = AllLinesFile[9].Substring(14);
            string Dota2Role = AllLinesFile[10].Substring(9);

            string[] Dota2SignatureTemp = AllLinesFile[11].Substring(14).Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Dota2SignatureTemp[0] = Dota2SignatureTemp[0].Substring(1);
            int templastIndex = Dota2SignatureTemp.Length - 1;
            Dota2SignatureTemp[templastIndex] = Dota2SignatureTemp[templastIndex].Substring(0, Dota2SignatureTemp[templastIndex].Length - 1);
            string[] Dota2Signature = Dota2SignatureTemp;

            string Dota2NumberGames = AllLinesFile[12].Substring(16);
            string Dota2ProcentWinGames = AllLinesFile[13].Substring(20);
            string Dota2MMR = AllLinesFile[14].Substring(8);

            string[] Dota2PentagonTemp = AllLinesFile[15].Substring(13).Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Dota2PentagonTemp[0] = Dota2PentagonTemp[0].Substring(1);
            templastIndex = Dota2PentagonTemp.Length - 1;
            Dota2PentagonTemp[templastIndex] = Dota2PentagonTemp[templastIndex].Substring(0, Dota2PentagonTemp[templastIndex].Length - 1);
            int[] tempIntArray = new int[Dota2PentagonTemp.Length];
            int j = 0;
            foreach (string element in Dota2PentagonTemp)
            {
                tempIntArray[j] = Convert.ToInt32(element);
                j++;
            }
            int[] Dota2Pentagon = tempIntArray;

            string Dota2PhotoProfile = AllLinesFile[16].Substring(17);

            MyProfiles[0] = new Dota2Player(new object[] { Dota2Name, Dota2Nickname, Dota2Surname, Dota2Team, Dota2Country, Dota2City, Dota2Nationality, Dota2DateBirth, Dota2Role, Dota2Signature, Dota2NumberGames, Dota2ProcentWinGames, Dota2MMR, Dota2Pentagon, Dota2PhotoProfile });

            string CSGOName = AllLinesFile[20].Substring(9);
            string CSGONickname = AllLinesFile[21].Substring(13);
            string CSGOSurname = AllLinesFile[22].Substring(12);
            string CSGOTeam = AllLinesFile[23].Substring(9);
            string CSGOCountry = AllLinesFile[24].Substring(12);
            string CSGOCity = AllLinesFile[25].Substring(9);
            string CSGONationality = AllLinesFile[26].Substring(16);
            string CSGODateBirth = AllLinesFile[27].Substring(14);
            string CSGORole = AllLinesFile[28].Substring(9);

            string[] CSGOSignatureTemp = AllLinesFile[29].Substring(14).Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            CSGOSignatureTemp[0] = CSGOSignatureTemp[0].Substring(1);
            templastIndex = CSGOSignatureTemp.Length - 1;
            CSGOSignatureTemp[templastIndex] = CSGOSignatureTemp[templastIndex].Substring(0, CSGOSignatureTemp[templastIndex].Length - 1);
            string[] CSGOSignature = CSGOSignatureTemp;

            string CSGONumberGames = AllLinesFile[30].Substring(16);
            string CSGOProcentWinGames = AllLinesFile[31].Substring(20);
            string CSGOMMR = AllLinesFile[32].Substring(8);

            string[] CSGOPentagonTemp = AllLinesFile[33].Substring(13).Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            CSGOPentagonTemp[0] = CSGOPentagonTemp[0].Substring(1);
            templastIndex = CSGOPentagonTemp.Length - 1;
            CSGOPentagonTemp[templastIndex] = CSGOPentagonTemp[templastIndex].Substring(0, CSGOPentagonTemp[templastIndex].Length - 1);
            tempIntArray = new int[CSGOPentagonTemp.Length];
            j = 0;
            foreach (string element in CSGOPentagonTemp)
            {
                tempIntArray[j] = Convert.ToInt32(element);
                j++;
            }
            int[] CSGOPentagon = tempIntArray;

            string CSGOPhotoProfile = AllLinesFile[34].Substring(17);

            MyProfiles[1] = new CSGOPlayer(new object[] { CSGOName, CSGONickname, CSGOSurname, CSGOTeam, CSGOCountry, CSGOCity, CSGONationality, CSGODateBirth, CSGORole, CSGOSignature, CSGONumberGames, CSGOProcentWinGames, CSGOMMR, CSGOPentagon, CSGOPhotoProfile });


            return MyProfiles;
        }
        //public static void
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
        public Player(Player player)
        {
            Name = String.Copy(player.Name);
            Nickname = String.Copy(player.Nickname);
            Surname = String.Copy(player.Surname);
            Team = String.Copy(player.Team);
            Country = String.Copy(player.Country);
            City = String.Copy(player.City);
            Nationality = String.Copy(player.Nationality);
            DateBirth = player.DateBirth;
            Age = player.Age;
            Role = String.Copy(player.Role);
            Array.Copy(player.signature, signature = new string[player.signature.Length], player.signature.Length);
            NumberGames = player.NumberGames;
            ProcentWinGames = player.ProcentWinGames;
            MMR = String.Copy(player.MMR);
            Array.Copy(player.Pentagon, Pentagon = new int[player.Pentagon.Length], player.Pentagon.Length);
            PhotoProfile = String.Copy(player.PhotoProfile);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
            set
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
        public Dota2Player(Player player) : base(player)
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
        public CSGOPlayer(Player player) : base(player)
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

            MethodsWorkWithFile.CreateLists(GlobalVariables.ListPlayerInDiscypline);

            Player[] MyProfiles = MethodsWorkWithFile.ReadMyProfile();
            GlobalVariables.MyProfileDota2 = (Dota2Player)MyProfiles[0];
            GlobalVariables.MyProfileCSGO = (CSGOPlayer)MyProfiles[1];

            GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.PlayerDota2Clear);
            GlobalVariables.ListPlayerInDiscypline[0].Add(GlobalVariables.MyProfileDota2);
            GlobalVariables.ListPlayerInDiscypline[1].Add(GlobalVariables.PlayerCSGOClear);
            GlobalVariables.ListPlayerInDiscyplineSearched = new List<List<Player>>(GlobalVariables.ListPlayerInDiscypline);

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
