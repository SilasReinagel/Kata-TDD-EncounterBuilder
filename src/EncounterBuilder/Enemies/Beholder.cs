namespace EncounterBuilder.Enemies
{
    public sealed class Beholder : Creature
    {
        public int Level { get; }
        
        public Beholder(int level) => Level = level;
    }
}
