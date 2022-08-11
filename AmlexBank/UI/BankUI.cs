using AmlexLibrary.UI;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmlexBank
{
    internal class BankUI : IMultiplePagesUI
    {
        public IEnumerable<IUIPage> Pages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ushort EffectID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public short LayerID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool ShouldBlockMouse { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CSteamID PlayerID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool CanUseButton(Player player)
        {
            throw new NotImplementedException();
        }

        public void ChangePage()
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void SendUI(UnturnedPlayer player)
        {
            throw new NotImplementedException();
        }

        public void Unload()
        {
            throw new NotImplementedException();
        }
    }
}
