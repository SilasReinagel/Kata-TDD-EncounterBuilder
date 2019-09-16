using System.Collections.Generic;
using System.Linq;

namespace EncounterBuilder.Heroes
{
    public sealed class Party
    {
        private readonly IReadOnlyList<Creature> _heroes;

        public int TotalPartyLevel => _heroes.Sum(x => x.Level);

        public Party(params Creature[] heroes) => _heroes = heroes.ToList();
    }
}
