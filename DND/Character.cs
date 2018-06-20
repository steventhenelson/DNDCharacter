using System;
using System.IO;

namespace DND
{
    public partial class Character
    {
        static string pName = "";
        static string cName = "";
        static string charClass = "";
        static int level = 1;
        static string background = "";
        static string race = "";
        static string alignment = "";
        static int xp = 0;
        static int strength = 0;
        static int dexterity = 0;
        static int constitution = 0;
        static int intelligence = 0;
        static int wisdom = 0;
        static int charisma = 0;
        static int acroatics = 0;
        static int animalHandling = 0;
        static int arcana = 0;
        static int athletics = 0;
        static int deception = 0;
        static int history = 0;
        static int insight = 0;
        static int intimidation = 0;
        static int investigation = 0;
        static int medicine = 0;
        static int nature = 0;
        static int perception = 0;
        static int performance = 0;
        static int persuasion = 0;
        static int religion = 0;
        static int sleightOfHand = 0;
        static int stealth = 0;
        static int survival = 0;

        public static string PName { get => pName; set => pName = value; }
        public static string CName { get => cName; set => cName = value; }
        public static string Charclass { get => charClass; set => charClass = value; }
        public static int Level { get => level; set => level = value; }
        public static string Background { get => background; set => background = value; }
        public static string Race { get => race; set => race = value; }
        public static string Alignment { get => alignment; set => alignment = value; }
        public static int Xp { get => xp; set => xp = value; }
        public static int Strength { get => strength; set => strength = value; }
        public static int Dexterity { get => dexterity; set => dexterity = value; }
        public static int Constitution { get => constitution; set => constitution = value; }
        public static int Intelligence { get => intelligence; set => intelligence = value; }
        public static int Wisdom { get => wisdom; set => wisdom = value; }
        public static int Charisma { get => charisma; set => charisma = value; }
        public static int Acroatics { get => acroatics; set => acroatics = value; }
        public static int AnimalHandling { get => animalHandling; set => animalHandling = value; }
        public static int Arcana { get => arcana; set => arcana = value; }
        public static int Athletics { get => athletics; set => athletics = value; }
        public static int Deception { get => deception; set => deception = value; }
        public static int History { get => history; set => history = value; }
        public static int Insight { get => insight; set => insight = value; }
        public static int Intimidation { get => intimidation; set => intimidation = value; }
        public static int Investigation { get => investigation; set => investigation = value; }
        public static int Medicine { get => medicine; set => medicine = value; }
        public static int Nature { get => nature; set => nature = value; }
        public static int Perception { get => perception; set => perception = value; }
        public static int Performance { get => performance; set => performance = value; }
        public static int Persuasion { get => persuasion; set => persuasion = value; }
        public static int Religion { get => religion; set => religion = value; }
        public static int SleightOfHand { get => sleightOfHand; set => sleightOfHand = value; }
        public static int Stealth { get => stealth; set => stealth = value; }
        public static int Survival { get => survival; set => survival = value; }

        public static void Export()
        {
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //path = Path.Combine(path, "\\character.txt");

            //string path = @"C:\\Users\\snelso4x\\Desktop\\character.txt"; //This one works
            string path = @"C:\\DND\\character.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Player Name...: " + pName);
                    sw.WriteLine("Character Name: " + cName);
                    sw.WriteLine("Class.........: " + charClass);
                    sw.WriteLine("Level.........: " + level);
                    sw.WriteLine("Race..........: " + race);
                    sw.WriteLine("Alignment.....: " + alignment);
                    sw.WriteLine("Experience....: " + xp);
                    sw.WriteLine("Strength......: " + strength);
                    sw.WriteLine("Dexterity.....: " + dexterity);
                    sw.WriteLine("Constituiton..: " + constitution);
                    sw.WriteLine("Intelligence..: " + intelligence);
                    sw.WriteLine("Wisdom........: " + wisdom);
                    sw.WriteLine("Charisma......: " + charisma);
                    sw.WriteLine("" );
                    sw.WriteLine("" );
                    //sw.WriteLine("" + );
                    sw.Flush();
                    sw.Close();
                }
            }
            /*
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }*/
        }
    }
}