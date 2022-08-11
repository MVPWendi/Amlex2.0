using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmlexLibrary.UI
{
    public abstract class PageUI : IUIPage
    {
        public string GameObjectName { get => GameObjectName; set => GameObjectName = value; }
        public bool IsVisible { get => IsVisible; set=> IsVisible = value; }
        public IUI UI { get => UI; set => UI = value; }
        public void SetActive(bool visible)
        {
            if (UI == null) throw new NullReferenceException();
            EffectManagerAmlex.SendVisibility(UI.LayerID, UI.PlayerID, GameObjectName, visible);
        }
    }
}
