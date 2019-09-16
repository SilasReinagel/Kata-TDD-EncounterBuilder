namespace EncounterBuilder.Heroes
{
    public sealed class Rogue : Creature
    {
        public int Level { get; }

        public Rogue(int level) => Level = level;
    }
}
