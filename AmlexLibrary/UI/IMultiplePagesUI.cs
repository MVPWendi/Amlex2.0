using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmlexLibrary.UI
{
    // интерфейс страница УИ
    public interface IMultiplePagesUI : IUI
    {     
        IEnumerable<IUIPage> Pages { get; set; }

        void ChangePage();
    }
}
