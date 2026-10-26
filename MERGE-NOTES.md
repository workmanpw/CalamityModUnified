# CalamityModUnified — merge notes (2026-10-26)

Base: official CalamityModPublic 2.2.2 (1a8cebd27e) merged with the local
Projects 2.4.5 tree (e7140a5152), then fixed to build clean under
tModLoader 2026.8.3.0: 0 errors, 97 warnings (headless build, 2026-10-26).

Sources merged in, in order:
- Projects local 2.4.5 (Ark of the Cosmos larger constellation, Ark of the
  Elements every-swing + spin homing, SlimeGod/BossRush paladin bounds,
  Skeletron Prime bounds, abyss divide-by-zero guard, SpriteBatch try/catch,
  shader GetInstance fix, EnhancedDarkness Snapshot/Transparent/LinearClamp,
  all fork Localization files, shader .fx/.xnb files)
- Personal/Mods/CalamityModPublic 8a113eaafa — already contained in the
  Projects tree; shader binaries byte-identical, no new code needed.
- Personal/Mods/CalamityModCustomPublicPrivateFork dirty changes — already
  contained in the Projects tree (abyss guard, Skeletron Prime bounds,
  SpriteBatch try/catch, build.txt hideResources=false/includeSource=true).
  Its older EnhancedDarkness reflection variant was superseded and discarded.
  Its namespace-renamed Localization files (Mods.CalamityModCustomPublicPrivateFork.*)
  were NOT copied; the current Mods.CalamityMod.* files are newer.

Deliberately excluded:
- CalamityModMusicCustomPublicPrivateFork deletion set — the music mod is a
  separate mod and that deletion set was never verified; do not merge it here.
- Windows ModSources copies — offline on 2026-10-26, not re-verified.
- Terraria-Mods snapshot Calamity 2.1.2 — older, superseded.
- The staged Ethereal gitlink deletion in the Personal fork — not a Calamity file.

Known stubs from the 0-error fix (see fix-224-errors commits):
- Bestiary forcible registration / was-seen marking disabled (private APIs gone).
- PermitNighttimeTownNPCSpawning is a no-op (hook removed in tML 2026).
- DivineSwine shimmer immunity removed.
- TheGift ShopHelper pricing uses reflection with a clamp fallback; check
  gifted town NPC prices in-game.
