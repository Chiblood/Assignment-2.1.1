/*Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/
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