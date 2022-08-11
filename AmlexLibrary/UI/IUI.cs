using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmlexLibrary.UI
{
    public interface IUI
    {
        ushort EffectID { get; set; }
        short LayerID { get; set; }

        bool ShouldBlockMouse { get; set; }
        CSteamID PlayerID { get; set; }

        void SendUI(UnturnedPlayer player);

        bool CanUseButton(Player player);
        void Load();

        void Unload();
    }
}
