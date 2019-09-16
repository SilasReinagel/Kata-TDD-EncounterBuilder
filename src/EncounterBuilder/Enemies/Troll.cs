namespace EncounterBuilder.Enemies
{
    public sealed class Troll : Creature
    {
        public int Level { get; }

        public Troll(int level) => Level = level;
    }
}
