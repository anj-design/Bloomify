using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace Bloomify_2._0
{
    class Program
    {
        public static void Main(string[] args)
        {
            InputSimulator simulator = new InputSimulator();

            simulator.Keyboard.KeyPress(VirtualKeyCode.F11); // fullscreen
            simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.SUBTRACT); // Zoom out
            Thread.Sleep(100);
            Background.Show();
        }

        public static void MainMenu()
        {
            Banner.Show();   // show your ASCII art first
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey(true);

            //Menu.Show();     // then launch the interactive menu
        }


    }

}