/*Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/

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