using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoNutNovember
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("If set to true, 'NNN' will be added at the end of the server name (invisible), so that players can search for it.")]
        public bool AllowForce173 { get; set; } = true;
    }
}
