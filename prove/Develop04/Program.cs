using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.RunSelection();
        }
    }
}

// the creative aspect of this program is the implementation of a menu class that can be used in any other program very easily.
// I also made the wait animation method a variable class that can receive input for how long the animation should play. 