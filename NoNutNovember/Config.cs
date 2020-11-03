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
        [Description("If set to true, users with RA ForceClass permission can still set people to SCP-173 (it won't spawn by default).")]
        public bool AllowForce173 { get; set; } = true;
    }
}
