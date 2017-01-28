using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;
using Ex04.Menus.Delegates;

namespace Ex04
{
    class ClassMainMenu
    {
        class MenuInterface : ClassMenusInterfaces
        {
            private readonly List<ClassMenusInterfaces> m_MenusInterfaces = new List<ClassMenusInterfaces>();

            public void BuildMenuItem()
            {
                throw new NotImplementedException();
            }
        }

        class MenuDelegate
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
