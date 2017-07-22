using System;
using System.Globalization;
using System.Drawing;
using Console = Colorful.Console;
using Colorful;
using System.Threading;
using System.Text;

namespace Shakespeare
{
    static class Game
    {
      static  string[] Words = new string[] { "Creature",
  "Luminous",
        "Ghastly",
     "Spectral",
       "Countryman",
       "Farrier",
       "Farmer" ,
      "Dreadful",
       "Apparition",
      "Hound",
         };
        static string[] Prompts = new string[] { "noun", "adjective", "adjective","adjective", "occupation", "occupation", "occupation", "adjective", "noun","noun"};
        static string Story;
        static string GameTitle;

        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }
        static void Start()
        {
           
          
            Console.Title = Repeat(' ',6)+"Script a story";
            Console.WriteLine(Repeat(' ',5)+"---------------------------------------------------");
            FigletFont font = FigletFont.Load("D:/Projects/Shakespeare/Shakespeare/script.flf");
            Figlet figlet = new Figlet(font);
            Console.WriteLine(figlet.ToAscii("Shakespeare"),ColorTranslator.FromHtml("#fdd835"));
            
            Console.WriteLine(Repeat(' ', 5)+"--------------------------------------------------");
           
           
        }
        static void GetWords()
        {
            //ask player to enter words
           for(int i=0;i<Words.Length;i++)
            {
                Console.Write(Repeat(' ',4)+"Please enter a/an " + Prompts[i] + ": ",Color.SkyBlue);
                Words[i] = Console.ReadLine();
            }
            
        }
        static void WriteStory()
        {
            //Concatenate strings to make a title
            GameTitle = "The " + Words[1] + " " + Words[2] + " " + Words[0];
            //So we can capitalize the words in our title
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);
            //Write the title to the console window
            Console.WriteLine(GameTitle);
            Console.Title = GameTitle;
            //write out story
            Story = "They all agreed that it was a huge {0}, {1}, {2}, and {3}.\nI have cross-examined these men, one of them a hard-headed {4}, \none a {5}, and one a moorland {6}, who all tell the same story\nof this {7} {8}, exactly corresponding to the {9} of the legend.";

            Console.WriteLine(Repeat(' ', 4) + Story,ColorTranslator.FromHtml("#1de9b6"), Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6], Words[7], Words[8], Words[9]);
        }
        public static string Repeat(char c, int count)
        {
            return new string(c, count);
        }
       
        public static string Insert_NewLine(int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
        static void End()
        {
            Console.WriteLine("\n"+Repeat(' ',8)+"Press enter to exit",Color.SpringGreen);
            Console.ReadKey();
        }
        public static void SetWindowSize()
        {
            //Console.SetWindowSize(120, 60);
            for (int i = 1; i < 80; i++)
            {

                Console.SetWindowSize(i, i);
                Thread.Sleep(50);
            }

        }
    }
        
        class Program
        {
            static void Main()
            {
            Game.SetWindowSize();
                Game.Run();
            }
        }

    }


