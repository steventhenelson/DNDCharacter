using System;

namespace DND
{
    class Program
    { 
        //Program = private new Program();
        Character Ch = new Character();
        ExportToPDF pdf = new ExportToPDF();
        public enum classenum { Exit = 0, Fighter = 1, Rouge = 2, Wizard = 3, Barbarian = 4, Cleric = 5, Ranger = 6, Paladin = 7, Warlock = 8, Monk = 9, Bard = 10, Sorcerer = 11, Druid = 12 }
        public enum raceenum { Exit = 0, Human = 1, Elf = 2, HalfElf = 3, Dwarf = 4, Dragonborn = 5, Tiefling = 6, Gensai = 7, Halfling = 8, HalfOrc = 9, Gnome = 10, Goliath = 11, Aarakocra = 12, Aasimar = 13 }
        public static int value = 5;

        static void Main(string[] args)
        {
            

            if (Create()) Console.WriteLine("Character Creation Successful");
            else
            {
                Console.WriteLine("ERROR: Restarting Character Creation");
                Create();
            }

            Display();

            Character.Export();
            Console.WriteLine("\nExporting character to file");
            //Console.WriteLine("Data exported to C:\\Users\\snelso4x\\Desktop\\character.txt");
            Console.WriteLine("Data exported to C:\\character.txt");
            // Keep the console window open in debug mode.
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }

        public static bool Create()
        {
            Console.Clear();
            Console.WriteLine("Dungeons & Dragons Character Creation!");
            Console.Write("Enter your real name: ");
            Character.PName = Console.ReadLine();
            Console.Write("Enter your character's name: ");
            Character.CName = Console.ReadLine();

            ChooseClass();
            ChooseRace();
            ChooseAlignment();
            ChooseBaseStats();




            return true;
        }

     

        public static void ChooseClass()
        {
            Console.Clear();
            Console.WriteLine("Please choose a Class: ");
            Console.WriteLine("(1)  Fighter \n(2)  Rouge \n(3)  Wizard \n(4)  Barbarian \n(5)  Cleric \n(6)  Ranger \n(7)  Paladin \n(8)  Warlock \n(9)  Monk \n(10) Bard \n(11) Sorcerer \n(12) Druid \n(0)  Exit");
            Console.Write("Class: ");

            string input = Console.ReadLine();
            int parsed;
            // turn into a methos with the range as an input
            if (int.TryParse(input, out parsed))
            {
                value = parsed;
            }
            else value = Roll(12);
            //return here

            //int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 0:
                    return;
                case 1:
                    Character.Charclass = nameof(classenum.Fighter);
                    break;
                case 2:
                    Character.Charclass = nameof(classenum.Rouge);
                    break;
                case 3:
                    Character.Charclass = nameof(classenum.Wizard);
                    break;
                case 4:
                    Character.Charclass = nameof(classenum.Barbarian);
                    break;
                case 5:
                    Character.Charclass = nameof(classenum.Cleric);
                    break;
                case 6:
                    Character.Charclass = nameof(classenum.Ranger);
                    break;
                case 7:
                    Character.Charclass = nameof(classenum.Paladin);
                    break;
                case 8:
                    Character.Charclass = nameof(classenum.Warlock);
                    break;
                case 9:
                    Character.Charclass = nameof(classenum.Monk);
                    break;
                case 10:
                    Character.Charclass = nameof(classenum.Bard);
                    break;
                case 11:
                    Character.Charclass = nameof(classenum.Wizard);
                    break;
                case 12:
                    Character.Charclass = nameof(classenum.Wizard);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

        }

        public static void ChooseRace()
        {
            Console.Clear();
            Console.WriteLine("Please choose a Race: ");
            Console.WriteLine("(1)  Human \n(2)  Elf \n(3)  Half-Elf \n(4)  Dwarf \n(5)  Dragonborn \n(6)  Tiefling \n(7)  Gensai \n(8)  Halfling \n(9)  Half-Orc \n(10) Gnome \n(11) Goliath \n(12) Aarakocra \n(13) Aasimar \n(0)  Exit");
            Console.Write("Race: ");

            string input = Console.ReadLine();
            int parsed;
            
            if (int.TryParse(input, out parsed))
            {
                value = parsed;
            }
            else value = Roll(13);


            //int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case 0:
                    return;
                case 1:
                    Character.Race = nameof(raceenum.Human);
                    break;
                case 2:
                    Character.Race = nameof(raceenum.Elf);
                    break;
                case 3:
                    //Character.Race = nameof(raceenum.HalfElf);
                    Character.Race = "Half Elf";
                    break;
                case 4:
                    Character.Race = nameof(raceenum.Dwarf);
                    break;
                case 5:
                    Character.Race = nameof(raceenum.Dragonborn);
                    break;
                case 6:
                    Character.Race = nameof(raceenum.Tiefling);
                    break;
                case 7:
                    Character.Race = nameof(raceenum.Gensai);
                    break;
                case 8:
                    Character.Race = nameof(raceenum.Halfling);
                    break;
                case 9:
                    //Character.Race = nameof(raceenum.HalfOrc);
                    Character.Race = "Half Orc";
                    break;
                case 10:
                    Character.Race = nameof(raceenum.Gnome);
                    break;
                case 11:
                    Character.Race = nameof(raceenum.Goliath);
                    break;
                case 12:
                    Character.Race = nameof(raceenum.Aarakocra);
                    break;
                case 13:
                    Character.Race = nameof(raceenum.Aasimar);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

        }

        public static void ChooseAlignment()
        {
            Console.Clear();
            Console.WriteLine("Please choose an Alignment: ");
            Console.WriteLine("(1) Lawful good:");
            //Console.WriteLine("    A lawful good character typically acts with compassion and always with honor \nand a sense of duty. Such characters include righteous knights, paladins, and most dwarves.");
            Console.WriteLine("(2) Neutral good:");
            //Console.WriteLine("    For the term in economics, see Neutral good. A neutral good character typically \nacts altruistically, without regard for or against lawful precepts such as rules or tradition. A neutral good character has no problems with cooperating with lawful officials, but does not feel beholden to them.");
            Console.WriteLine("(3) Chaotic good:");
            //Console.WriteLine("    A chaotic good character does what is necessary to bring about change for the \nbetter, disdains bureaucratic organizations that get in the way of social improvement, and places a high value on personal freedom, not only for oneself, but for others as well.[9] Chaotic good characters usually intend to do the right thing, but their methods are generally disorganized and often out of sync with the rest of society.");
            Console.WriteLine("(4) Lawful neutral:");
            //Console.WriteLine("    A lawful neutral character typically believes strongly in lawful concepts such \nas honor, order, rules, and tradition, and often follows a personal code. Examples of lawful neutral characters include a soldier who always follows orders, a judge or enforcer that adheres mercilessly to the word of the law, and a disciplined monk.");
            Console.WriteLine("(5) Neutral:");
            //Console.WriteLine("    A neutral character is neutral on both axes and tends not to feel strongly towards \nany alignment, or actively seeks their balance. Druids frequently follow this dedication to balance.");
            Console.WriteLine("(6) Chaotic neutral:");
            //Console.WriteLine("    A chaotic neutral character is an individualist who follows their own heart and \ngenerally shirks rules and traditions. Although chaotic neutral characters promote the ideals of freedom, it is their own freedom that comes first; good and evil come second to their need to be free.");
            Console.WriteLine("(7) Lawful evil:");
            //Console.WriteLine("    A lawful evil character sees a well-ordered system as being easier to exploit and \nshows a combination of desirable and undesirable traits.");
            Console.WriteLine("(8) Neutral evil:");
            //Console.WriteLine("    A neutral evil character is typically selfish and has no qualms about turning \non allies-of-the-moment, and usually makes allies primarily to further their own goals. A neutral evil character has no compunctions about harming others to get what they want, but neither will they go out of their way to cause carnage or mayhem when they see no direct benefit for themselves.");
            Console.WriteLine("(9) Chaotic evil:");
            //Console.WriteLine("    A chaotic evil character tends to have no respect for rules, other people's \nlives, or anything but their own desires, which are typically selfish and cruel. They set a high value on personal freedom, but do not have much regard for the lives or freedom of other people. Chaotic evil characters do not work well in groups because they resent being given orders and do not usually behave themselves unless there is no alternative.");
            Console.WriteLine("(0) Exit");
            Console.Write("Alignment: ");

            string input = Console.ReadLine();
            int parsed;
            // turn into a methos with the range as an input
            if (int.TryParse(input, out parsed))
            {
                value = parsed;
            }
            else value = Roll(9);

            //int value = int.Parse(Console.ReadLine());
            if (value >= 0 && value <= 9)
            {
                switch (value)
                {
                    case 0:
                        return;
                    case 1:
                        //Character.Alignment = nameof(raceenum.Human);
                        Character.Alignment = "Lawful Good";
                        break;
                    case 2:
                        //Character.Alignment = nameof(raceenum.Elf);
                        Character.Alignment = "Neutral Good";
                        break;
                    case 3:
                        //Character.Alignment = nameof(raceenum.HalfElf);
                        Character.Alignment = "Chaotic Good";
                        break;
                    case 4:
                        //Character.Alignment = nameof(raceenum.Dwarf);
                        Character.Alignment = "Lawful Neutral";
                        break;
                    case 5:
                        //Character.Alignment = nameof(raceenum.Dragonborn);
                        Character.Alignment = "Neutral";
                        break;
                    case 6:
                        //Character.Alignment = nameof(raceenum.Tiefling);
                        Character.Alignment = "Chaotic Neutral";
                        break;
                    case 7:
                        //Character.Alignment = nameof(raceenum.Gensai);
                        Character.Alignment = "Lawful Evil";
                        break;
                    case 8:
                        //Character.Alignment = nameof(raceenum.Halfling);
                        Character.Alignment = "Neutral Evil";
                        break;
                    case 9:
                        //Character.Alignment = nameof(raceenum.HalfOrc);
                        Character.Alignment = "Chaotic Evil";
                        break;
                    default:
                        Console.WriteLine("Invalid Selection");
                        break;
                }
            }
            else ChooseAlignment();
        }

        private static void ChooseBaseStats()
        {
            Console.Clear();
            int i,j,k;
            int[] rolls = { 15, 14, 13, 12, 10, 8 };
            string[] stats = { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };

            Console.WriteLine("Pick your preference: ");
            Console.Write("(1) Custom Stats \n(2) Default stats? ");
            string input = Console.ReadLine();
            int parsed;
            // turn into a methos with the range as an input
            if (int.TryParse(input, out parsed))
            {
                value = parsed;
            }
            else value = 2;
                 
            if (value == 1)
            {
                Console.WriteLine("Generating custom values");
                for (i = 0; i < 4; ++i)
                {
                    rolls[i] = RollBaseStats(6);
                }
            }
            else Console.WriteLine("Default it is");
            
            for (k = 0; k < 6; ++k)
            {
                Console.Clear();
                Console.WriteLine("Avaliable pool of stats: ");

                for (i = 0; i < 6; ++i)
                {
                    j = i + 1;
                    Console.WriteLine("(" + j + ") " + rolls[i] + " Points");
                }

                Console.Write("Which of the following stats do you want for " + stats[k] + "? ");

                string option = Console.ReadLine();
                // turn into a methos with the range as an input
                if (int.TryParse(option, out parsed))
                {
                    value = parsed;
                }
                else value = 1;

                if (value >= 1 && value <= 6)
                {
                    if (k == 0) Character.Strength = rolls[value - 1];
                    if (k == 1) Character.Dexterity = rolls[value - 1];
                    if (k == 2) Character.Constitution = rolls[value - 1];
                    if (k == 3) Character.Intelligence = rolls[value - 1];
                    if (k == 4) Character.Wisdom = rolls[value - 1];
                    if (k == 5) Character.Charisma = rolls[value - 1];

                    rolls[value - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Invlid");
                    --i;
                }
            }
            RaceBonuses();
        }

        private static int Roll(int sides)
        {
            int result;
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            result = rand.Next(1, sides+1);
            return result;
        }

        private static int RollBaseStats(int sides)
        {
            int i, first, second, third;
            int[] rolls = { 0, 0, 0, 0, 0, 0 };

            for (i = 0; i < 6; ++i)
            {
                rolls[i] = Roll(sides);
            }
  
            third = first = second = 0;
            for (i = 0; i < 6; i++)
            {
                // If current element is 
                // smaller than first
                if (rolls[i] > first)
                {
                    third = second;
                    second = first;
                    first = rolls[i];
                }

                // If arr[i] is in between first
                // and second then update second
                else if (rolls[i] > second)
                {
                    third = second;
                    second = rolls[i];
                }
                else if (rolls[i] > third)
                    third = rolls[i];
            }
            return first+second+third;
        }
   
        private static void RaceBonuses()
        {
            Console.Clear();
            Console.WriteLine("Checking for Racial Bonuses");
            System.Threading.Thread.Sleep(400);
            if (Character.Race == "Human")
            {
                Console.WriteLine("Congratulations Humans get +1 to Strength");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Humans get +1 to Dexterity");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Humans get +1 to Constitution");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Humans get +1 to Intelligence");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Humans get +1 to Wisdom");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Humans get +1 to Charisma");
                System.Threading.Thread.Sleep(800);
                Character.Strength += 1;
                Character.Dexterity += 1;
                Character.Constitution += 1;
                Character.Intelligence += 1;
                Character.Wisdom += 1;
                Character.Charisma += 1;
            }
            else if (Character.Race == "Elf")
            {
                Console.WriteLine("Congratulations Elves get +2 to Dexterity");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Elves get +1 to Intelligence");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Elves get +1 to Wisdom");
                System.Threading.Thread.Sleep(800);
                Character.Dexterity += 2;
                Character.Intelligence += 1;
                Character.Wisdom += 1;
            }
            else if (Character.Race == "Dwarf")
            {
                Console.WriteLine("Congratulations Dwarves get +2 to Strength");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Dwarves get +2 to Constitution");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Dwarves get +1 to Wisdom");
                System.Threading.Thread.Sleep(800);
                Character.Strength += 2;
                Character.Constitution += 2;
                Character.Wisdom += 1;
            }
            else if (Character.Race == "Halfling")
            {
                Console.WriteLine("Congratulations Humans get +2 to Dexterity");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Humans get +1 to Constitution");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("Congratulations Humans get +1 to Charisma");
                System.Threading.Thread.Sleep(800);
                Character.Dexterity += 2;
                Character.Constitution += 1;
                Character.Charisma += 1;
            }
            else
            {
                Console.WriteLine("Sorry, No Racial Bonuses for " + Character.CName);
                System.Threading.Thread.Sleep(1000);
                return;
            }
            Console.WriteLine("Adding bonus stat points");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Adding Complete");
            System.Threading.Thread.Sleep(800);
        }



        private static void Display()
        {
            Console.Clear();
            Console.WriteLine("Player Name: " + Character.PName);
            Console.WriteLine("Character Name: " + Character.CName);
            Console.WriteLine("Class: " + Character.Charclass);
            Console.WriteLine("Race: " + Character.Race);
            Console.WriteLine("Alignment: " + Character.Alignment);

            Console.WriteLine("Level: " + Character.Level);
            Console.WriteLine("Background: " + Character.Background);
            Console.WriteLine("Experience: " + Character.Xp);
            Console.WriteLine("Strength: " + Character.Strength);
            Console.WriteLine("Dexterity: " + Character.Dexterity);
            Console.WriteLine("Constitution: " + Character.Constitution);
            Console.WriteLine("Intelligence: " + Character.Intelligence);
            Console.WriteLine("Wisdom: " + Character.Wisdom);
            Console.WriteLine("Charisma: " + Character.Charisma);
            
        }
    }
}
