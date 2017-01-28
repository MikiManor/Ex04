using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04
{
    class MainMenu
    {
        class MenuDelegate
        {

        }

        class MenuInterface
        {

        }

        //void AddNewMenuItem();
        //void AddNewSubMenuItem();

        void Show()
        {
            int userSelection;
            bool v_Quit = true;

            do
            {
                Console.Clear();
                try 
                { 
                    userSelection = int.Parse(Console.ReadLine());
                    switch (userSelection)
                    {
                        case 0: Environment.Exit(0); break;
                        default: 
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong key pressed! press any key to try again...");
                    Console.ReadLine();
                    throw;
                }
            } while (!v_Quit);
        }
    }
}
