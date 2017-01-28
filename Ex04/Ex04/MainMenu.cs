using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04
{
    class MainMenu
    {
        //void AddNewMenuItem();
        //void AddNewSubMenuItem();

        void Show()
        {

            bool v_Quit = true;
            
            do
            {
                Console.Clear();
                try
                {

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
