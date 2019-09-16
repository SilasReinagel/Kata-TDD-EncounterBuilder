using System.Collections.Generic;
using System.Linq;

namespace EncounterBuilder.Enemies
{
    public sealed class Bestiary
    {
        public IReadOnlyList<Creature> AllCreatures { get; }

        public Bestiary(params Creature[] creatures) => AllCreatures = creatures.ToList();
    }
}
