﻿using Rocket.Core.Plugins;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmlexBank
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance;

        protected override void Load()
        {
           
            Instance = this;
        }


        protected override void Unload()
        {
            Instance = null;
        }
    }
}
