using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.WorldBuilding;

namespace CalamityMod.Utilities
{
    internal static class HitModiferUtils
    {
        internal static void ApplyScalingForcedCrit(this ref NPC.HitModifiers modifiers, Projectile Projectile)
        {
            modifiers.SetCrit();
            float critDamage = Main.player[Projectile.owner].GetTotalCritChance(Projectile.DamageType) * 0.02f;
            modifiers.CritDamage += critDamage;
        }
    }
}
