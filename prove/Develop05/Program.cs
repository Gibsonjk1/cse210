using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        while (menu._isRunning == true)
        {
            menu.DisplayMenu();
            int choice = menu.GetUserChoice();
            menu.RunSelection(choice);
        }
    }
}