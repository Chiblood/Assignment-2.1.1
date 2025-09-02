/* Assignment 2.2.1

Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/
namespace Assignment_2._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the classes
            PlayerCharacter bluey = new(1, "A brave adventurer", "Bluey", 6);
            NPC tracy = new(2, "A wise old wolf hound", "Tracy", "Quest Giver");
            Mob socks = new(3, "A wild puppy", "Socks", "Rare Item", 2);
            Animal bumpy = new(4, "A gentle and mild puppy", "Bumpy", "Skittles", 1);

            // Display information
            tracy.DisplayInfo();
            Console.WriteLine(tracy.Dialogue());
            Console.WriteLine();

            bluey.DisplayInfo();
            Console.WriteLine(bluey.Interact());
            Console.WriteLine();

            socks.DisplayInfo();
            Console.WriteLine(socks.Dialogue());
            Console.WriteLine();

            bumpy.DisplayInfo();
            Console.WriteLine(bumpy.Dialogue());
        }
    }
}