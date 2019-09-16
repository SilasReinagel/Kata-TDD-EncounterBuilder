namespace EncounterBuilder.Heroes
{
    public sealed class Fighter : Creature
    {
        public int Level { get; }

        public Fighter(int level) => Level = level;
    }
}
