using System.ComponentModel;
using Sidekick.UI.Leagues.Betrayal;
using Sidekick.UI.Leagues.Blight;
using Sidekick.UI.Leagues.Delve;

namespace Sidekick.UI.Leagues
{
    public class LeagueViewModel : ILeagueViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public LeagueViewModel()
        {
            Betrayal = new BetrayalLeague();
            Blight = new BlightLeague();
            Delve = new DelveLeague();
        }

        public BetrayalLeague Betrayal { get; private set; }

        public BlightLeague Blight { get; private set; }

        public DelveLeague Delve { get; private set; }
    }
}
