using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace AmlexLibrary.UI
{
    public static class EffectManagerAmlex
    {
        public static void Send3DEffect(Vector3 pos, ushort Effectid, UnturnedPlayer player)
        {
            TriggerEffectParameters trigger = new TriggerEffectParameters(Effectid);
            trigger.position = pos;
            trigger.relevantDistance = 200f;
            if (player != null)
                trigger.relevantPlayerID = player.CSteamID;
            trigger.shouldReplicate = true;
            EffectManager.triggerEffect(trigger);
        }
        public static void SendUI(ushort effectid, short layerid, UnturnedPlayer player)
        {
            SendUI(effectid, layerid, player.CSteamID);
        }


        public static Task SendImageAsync(short layerid, CSteamID steamID, string prefabname, string imageurl)
        {
            var val = Provider.findTransportConnection(steamID);
            EffectManager.sendUIEffectImageURL(layerid, val, true, prefabname, imageurl);
            return Task.CompletedTask;

        }
        public static void SendVisibility(short layerid, CSteamID steamID, string prefabname, bool visible)
        {
            var val = Provider.findTransportConnection(steamID);
            EffectManager.sendUIEffectVisibility(layerid, val, true, prefabname, visible);
        }
        public static void SendUI(ushort effectid, short layerid, CSteamID steamID)
        {
            var val = Provider.findTransportConnection(steamID);
            EffectManager.sendUIEffect(effectid, layerid, val, true);
        }
        public static void SendText(short layerid, UnturnedPlayer player, string prefabname, string text)
        {
            SendText(layerid, player.CSteamID, prefabname, text);
        }

        public static void ClearEffect(ushort effectid, CSteamID steamid)
        {
            var val = Provider.findTransportConnection(steamid);
            EffectManager.askEffectClearByID(effectid, val);
        }
        public static void SendText(short layerid, CSteamID steamID, string prefabname, string text)
        {
            var val = Provider.findTransportConnection(steamID);
            EffectManager.sendUIEffectText(layerid, val, true, prefabname, text);
        }
    }
}
