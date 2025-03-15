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
    // For the creativity portion of this assignment, I used ChatGPT to help me create a list of silly characters you can be as you level up
    // There is a menu item to display your character, and a cacluation for which level you are on. this makes it so you don't have to save
    // level information in the file.
}