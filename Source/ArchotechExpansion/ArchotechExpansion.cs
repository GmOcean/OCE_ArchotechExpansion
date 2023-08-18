// OCEArchotechExpansion, Version=0.0.1, Culture=neutral, PublicKeyToken=null
// OCEArchotechExpansion.Building_AncientArchotechDoor
using RimWorld;
using Verse;

namespace ArchotechExpansion
{
    public class Building_AncientArchotechDoor : Building_Door
    {
        public override bool PawnCanOpen(Pawn p)
        {
            if (((Building_Door)this).PawnCanOpen(p))
            {
                return ((ThingWithComps)this).GetComp<CompPowerTrader>().PowerOn;
            }
            return false;
        }
    }
}
