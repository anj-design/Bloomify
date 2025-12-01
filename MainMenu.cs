using System;
using System.Media;

class Banner
{
    public static void Show()
    {
        Console.WriteLine(@"
                                ___  ___  ___  ___  ___    ____  __     __    __   _  _  __  ____  _  _    ___  ___  ___  ___  ___   
                               (___)(___)(___)(___)(___)  (  _ \(  )   /  \  /  \ ( \/ )(  )(  __)( \/ )  (___)(___)(___)(___)(___)  
                                ___  ___  ___  ___  ___    ) _ (/ (_/\(  O )(  O )/ \/ \ )(  ) _)  )  /    ___  ___  ___  ___  ___   
                               (___)(___)(___)(___)(___)  (____/\____/ \__/  \__/ \_)(_/(__)(__)  (__/    (___)(___)(___)(___)(___)  
");
    }
}

// === Added code: Menu class ===
class MainMenu
{
    public static void Show()
    {
        Console.CursorVisible = false;
        string[] menuItems = new string[]
        {
@"
                         ____  ____  __   ____  ____    ____  __    ___  _  _  ____ 
                        / ___)(_  _)/ _\ (  _ \(_  _)  (  __)/  \  / __)/ )( \/ ___)
                        \___ \  )( /    \ )   /  )(     ) _)(  O )( (__ ) \/ (\___ \
                        (____/ (__)\_/\_/(__\_) (__)   (__)  \__/  \___)\____/(____/
",
@"
                                 _  _  __  ____  ____  __  ____  _  _                        
                                / )( \(  )/ ___)(_  _)/  \(  _ \( \/ )                       
                                ) __ ( )( \___ \  )( (  O ))   / )  /                        
                                \_)(_/(__)(____/ (__) \__/(__\_)(__/                         
",
@"
                                 ___   __   ____  ____  ____  __ _                          
                                / __) / _\ (  _ \(    \(  __)(  ( \                         
                               ( (_ \/    \ )   / ) D ( ) _) /    /                         
                                \___/\_/\_/(__\_)(____/(____)\_)__)                         
"
        };

        int selectedIndex = 0;

        while (true)
        {
            Console.Clear();
            Banner.Show(); // <-- connect: show your banner first
            Console.WriteLine("\n");
            DrawMenu(menuItems, selectedIndex);

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
                    Console.WriteLine("You selected:\n");
                    Console.WriteLine(menuItems[selectedIndex]);
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey(true);
                    break;
            }
        }
    }

    static void DrawMenu(string[] items, int selectedIndex)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i == selectedIndex)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(items[i]);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}

// === Entry point ===
