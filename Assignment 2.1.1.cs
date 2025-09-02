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
    // Base class
    public class Entity(int id, string description)
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
    }

    // Another derived class
    public class NPC(int id, string description, string name, string role = "Guard") : Character(id, description, name)
    {
        public string Role { get; set; } = role;
        public bool QuestGiver { get; set; } = role.ToLower() == "quest giver";

        public string Dialogue
        {
            get
            {
                return Role.ToLower() switch // This is a C# 8.0 feature called a switch expression.
                {
                    "quest giver" => "Greetings, adventurer! I have a task for you.",
                    "merchant" => "Welcome to my shop! Take a look at my wares.",
                    "trainer" => "I can help you hone your skills.",
                    _ => "Hello there!",
                };
            }
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Name: {Name}, Level: {Level}, Role: {Role}");
        }
    }
    public class PlayerCharacter : Character
    {
        public PlayerCharacter(int id, string description, string name, int level = 1)
            : base(id, description, name, level)
        {
            Name = name;
            Level = level;
            Description = description;

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
        }

        public static string Interact()
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
            Name = name;
            Loot = loot;
            Level = level;
        }
        public override string Dialogue()
        {
            return "Yawn... *sniffs*";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Name: {Name}, Level: {Level}, Loot: {Loot}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the classes
            PlayerCharacter Bluey = new(1, "A brave adventurer", "Bluey", 6);
            NPC Tracy = new(2, "A wise old wolf hound", "Tracy", "Quest Giver");
            Mob Socks = new(3, "A wild puppy", "Socks", "Rare Item");
            Animal Bumpy = new(4, "A gentle and mild puppy", "Bumpy", "Skittles", 1);

            // Display information
            Bluey.DisplayInfo();
            Console.WriteLine(Bluey.Interact());

            Tracy.DisplayInfo();
            Console.WriteLine(Tracy.Dialogue);

            Socks.DisplayInfo();
            Console.WriteLine(Socks.Dialogue);

            Bumpy.DisplayInfo();
            Console.WriteLine(Bumpy.Dialogue);
        }
    }
}