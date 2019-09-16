namespace EncounterBuilder.Enemies
{
    public sealed class Rat : Creature
    {
        public int Level { get; }
        
        public Rat(int level) => Level = level;
    }
}
