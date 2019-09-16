namespace EncounterBuilder.Heroes
{
    public sealed class Wizard : Creature
    {
        public int Level { get; }

        public Wizard(int level) => Level = level;
    }
}
