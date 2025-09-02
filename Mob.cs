/*Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/
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