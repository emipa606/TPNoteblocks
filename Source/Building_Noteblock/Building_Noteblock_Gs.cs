using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_Gs : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_Gs.PlayOneShot(new TargetInfo(Position, Map));
    }
}