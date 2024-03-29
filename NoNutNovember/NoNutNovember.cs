﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Features;

using Events = Exiled.Events.Handlers;

namespace NoNutNovember
{
    public class NoNutNovember : Plugin<Config>
    {
        public override string Name => "No Nut November";
        public override string Author => "Thunder";
        public override PluginPriority Priority => PluginPriority.Low;
        public override Version Version => new Version(1, 0, 3);
        public override Version RequiredExiledVersion => new Version(5, 2, 0);

        public static NoNutNovember Singleton;
        private EventHandlers Handler;

        public override void OnEnabled()
        {
            Singleton = this;
            Handler = new EventHandlers();

            Events.Player.ChangingRole += Handler.ChangingRole;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Events.Player.ChangingRole -= Handler.ChangingRole;

            Singleton = null;
            Handler = null;

            base.OnDisabled();
        }
    }
}
