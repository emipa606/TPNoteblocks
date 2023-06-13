using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_C : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_C.PlayOneShot(new TargetInfo(Position, Map));
    }
}