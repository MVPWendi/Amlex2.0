using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmlexLibrary.UI
{
    // интерфейс страница УИ
    public interface IUIPage
    {
        string GameObjectName { get; set; }
        bool IsVisible { get; set; }
        void SetActive(bool visible);

        IUI UI { get; set; }
    }
}
