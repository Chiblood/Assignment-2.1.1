/*Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/
namespace Assignment_2._1._1
{
    // Base class, restricted from instantiation
    public abstract class Entity(int id, string description)
    {
        public int Id { get; set; } = id;
        public string Description { get; set; } = description;

        // public Entity(int id, string description)
        // {
        //     Id = id;
        //     Description = description;
        // }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Description: {Description}");
        }
    }

    // Derived class
    public class Character : Entity
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Character(int id, string description, string name, int level = 1)
            : base(id, description)
        {
            Name = name;
            Level = level;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Name: {Name}, Level: {Level}");
        }

        public virtual string Interact()
        {
            return "I have nothing to say.";
        }
    }

    // Another derived class
    public class NPC(int id, string description, string name, string role = "Guard") : Character(id, description, name)
    {
        public string Role { get; set; } = role;
        public bool QuestGiver { get; set; } = role.ToLower() == "quest giver";

        public string Dialogue()
        {
            return Role.ToLower() switch
            {
                "quest giver" => "Hello, adventurer! What can I do for you.",
                "merchant" => "Welcome to my shop! Take a look at my wares.",
                _ => "Hello there!",
            };
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: {Role}");
        }
    }
    public class PlayerCharacter : Character
    {
        public PlayerCharacter(int id, string description, string name, int level = 1)
            : base(id, description, name, level)
        {
            // The base constructor already handles setting these properties.
            // No additional code is needed here.
        }

        // Override the Interact method to provide player-specific dialogue
        public override string Interact()
        {
            return $"Please help me save my friend Bumpy!";
        }
    }
    public class Mob : Entity
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string Loot { get; set; } = "Common Item";
        public Mob(int id, string description, string name, string loot = "Common Item", int level = 1)
            : base(id, description)
        {
            Name = name;
            Loot = loot;
            Level = level;
        }
        public virtual string Dialogue()
        {
            return "Grrr... *growls*";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Name: {Name}, Level: {Level}, Loot: {Loot}");
        }
    }
    public class Animal : Mob
    {
        public Animal(int id, string description, string name, string loot = "Animal Hide", int level = 1)
            : base(id, description, name, loot, level)
        {
            // The base constructor already handles setting these properties.
        }
        public override string Dialogue()
        {
            return "Yawn... *sniffs*";
        }
    }

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

            bluey.DisplayInfo();
            Console.WriteLine(bluey.Interact());

            socks.DisplayInfo();
            Console.WriteLine(socks.Dialogue());

            bumpy.DisplayInfo();
            Console.WriteLine(bumpy.Dialogue());
        }
    }
}