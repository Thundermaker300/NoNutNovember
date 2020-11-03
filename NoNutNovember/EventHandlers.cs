using Exiled.Events.EventArgs;
using Exiled.Events.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exiled.API.Features;
using MEC;

namespace NoNutNovember
{
    public class EventHandlers
    {
        private List<RoleType> ScpRoles = new List<RoleType> { RoleType.Scp049, RoleType.Scp096, RoleType.Scp106, RoleType.Scp93953, RoleType.Scp93989 };
        private RoleType GetAvailableScp()
        {
            RoleType chosen = RoleType.None;
            ScpRoles.ShuffleList();
            foreach (RoleType r in ScpRoles)
            {
                if (Exiled.API.Features.Player.List.Where(Ply => Ply.Role == r).Count() < 1)
                {
                    chosen = r;
                    break;
                }
            }
            if (chosen == RoleType.None) // fallback if for some reason all the SCPs are taken
                chosen = ScpRoles.First();
            return chosen;
        }
        public void ChangingRole(ChangingRoleEventArgs ev)
        {
            if (ev.NewRole == RoleType.Scp173 && DateTime.Now.Month == 11)
            {
                if (Round.ElapsedTime.TotalSeconds > 3 && NoNutNovember.Singleton.Config.AllowForce173) // Assume that they were forced if it's later than 3 seconds into the game.
                {
                    return;
                }
                ev.NewRole = GetAvailableScp();
            }
        }
    }
}
