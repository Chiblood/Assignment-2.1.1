/*Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/
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
