using System.Collections.Generic;
using CalamityMod.NPCs.Abyss;
using CalamityMod.NPCs.Astral;
using CalamityMod.NPCs.Crags;
using CalamityMod.NPCs.Deconstructors;
using CalamityMod.Systems.Collections;
using Terraria;
using Terraria.GameContent.Bestiary;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace CalamityMod.Systems
{
    public class BestiaryRegistrySystem : ModSystem
    {
        public override void PostSetupContent()
        {
            On_BestiaryDatabaseNPCsPopulator.AddEmptyEntries_CrittersAndEnemies_Automated += ForciblyAddEmptyEntriesForCritters;
            On_NPCWasNearPlayerTracker.ScanWorldForFinds += ForciblySetWasSeenByPlayer;

            // Manually register variants post-initiailization
            foreach (var pair in CalamityNPCSets.CountVariantsAsTheSameInBestiary)
                ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[pair.Key] = ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[pair.Value];
        }

        private void ForciblyAddEmptyEntriesForCritters(On_BestiaryDatabaseNPCsPopulator.orig_AddEmptyEntries_CrittersAndEnemies_Automated orig, BestiaryDatabaseNPCsPopulator self)
        {
            orig(self);
            // STUBBED for tModLoader 2026: private bestiary database APIs were removed.
        }


        private void ForciblySetWasSeenByPlayer(On_NPCWasNearPlayerTracker.orig_ScanWorldForFinds orig, NPCWasNearPlayerTracker self)
        {
            orig(self);
            // STUBBED for tModLoader 2026: private tracker fields were removed.
        }
    }
}
