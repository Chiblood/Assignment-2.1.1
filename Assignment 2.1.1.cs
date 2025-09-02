/*Design a class hierarchy of your choice. (Need only class files ) */
namespace Assignment_2._1._1
{
    // Base class
    public class Entity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Entity(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Description: {Description}");
        }
    }

    // Derived class
    public class PlayerCharacter : Entity
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public PlayerCharacter(int id, string description, string name, int level)
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
        public string Interact()
        {
            return $"{Name} interacts with the environment.";
        }
    }

    // Another derived class
    public class NPC : Entity
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public NPC(int id, string description, string name, string role)
            : base(id, description)
        {
            Name = name;
            Role = role;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Name: {Name}, Role: {Role}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the classes
            PlayerCharacter player = new PlayerCharacter(1, "A brave warrior", "Arthas", 10);
            NPC npc = new NPC(2, "A wise old wolf hound", "Tracy", "Quest Giver");

            // Display information
            player.DisplayInfo();
            Console.WriteLine(player.Interact());

            npc.DisplayInfo();
        }
    }
}