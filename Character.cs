/*Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/
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