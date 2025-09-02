/* Assignment 2.1.1
Design a class hierarchy of your choice. (Need only class files ) 
    Entity
        Character
            PlayerCharacter
            NPC
        Mob
            Animal
*/

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