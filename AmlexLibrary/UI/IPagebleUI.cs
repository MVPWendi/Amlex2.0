using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmlexLibrary.UI
{

    // интерфейс с для уи с объектами, которые можно листать
    public interface IPagebleUI<T> : IUI
    {
        string NextButton { get; set; }
        string PrevButton { get; set; }       
        byte CurrentPage { get; set; }
        IEnumerable<T> UIObjects { get; set; }


        void UpdateButtons();
    }
}
