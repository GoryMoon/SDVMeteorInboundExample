using StardewModdingAPI;
using StardewModdingAPI.Events;
using static SimpleSoundManager.ModCore;

namespace MeteorInboundExample
{
    public class MeteorInboundExample: Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.SaveLoaded += OnGameLoopOnSaveLoaded;
        }

        private void OnGameLoopOnSaveLoaded(object sender, SaveLoadedEventArgs args)
        {
            MusicManager.playSound("MeteorInboundContent", "MeteorInbound");
        }
    }
}