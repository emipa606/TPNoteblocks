using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_E : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_E.PlayOneShot(new TargetInfo(Position, Map));
    }
}