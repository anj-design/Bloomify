
using System;
using System.Media;

class TitleScreen
{
    public static void Show()
    {
        string[] bannerLines = {
"                       ___  ___  ___  ___  ___    ____  __     __    __   _  _  __  ____  _  _    ___  ___  ___  ___  ___   ",
"                      (___)(___)(___)(___)(___)  (  _ \\(  )   /  \\  /  \\ ( \\/ )(  )(  __)( \\/ )  (___)(___)(___)(___)(___)  ",
"                       ___  ___  ___  ___  ___    ) _ (/ (_/\\(  O )(  O )/ \\/ \\ )(  ) _)  )  /    ___  ___  ___  ___  ___   ",
"                      (___)(___)(___)(___)(___)  (____/\\____/ \\__/  \\__/ \\_)(_/(__)(__)  (__/    (___)(___)(___)(___)(___)  "
        };

        Console.Clear();
        Console.WriteLine(); // one blank line at top

        foreach (var line in bannerLines)
        {
            int leftPadding = (Console.WindowWidth - line.Length) / 2;
            if (leftPadding < 0) leftPadding = 0;
            Console.WriteLine(new string(' ', leftPadding) + line);
        }

    }
}

class Menu
{
    public static void ShowMenu()
    {
        string[] menuItems = { "Start Focus", "History", "Garden" };
        int selectedIndex = 0;
        
        while (true)
        {
            Console.Clear();
            TitleScreen.Show();
            Console.WriteLine("\n\n\n"); // spacing between banner and menu

            for (int i = 0; i < menuItems.Length; i++)
            {
                string line = menuItems[i];
                int leftPadding = (Console.WindowWidth - line.Length) / 2;

                if (i == selectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(new string(' ', leftPadding) + line);
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(new string(' ', leftPadding) + line);
                }
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = (selectedIndex - 1 + menuItems.Length) % menuItems.Length;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = (selectedIndex + 1) % menuItems.Length;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    TitleScreen.Show();

                    while (true)
                    {
                        ConsoleKeyInfo subKey = Console.ReadKey(true);
                        if (subKey.Key == ConsoleKey.Spacebar)
                        {
                            break; // go back to menu loop
                        }
                        else if (subKey.Key == ConsoleKey.Enter)
                        {
                            Environment.Exit(0); // exit program
                        }
                    }
                    break;
            }

        }
    }
}