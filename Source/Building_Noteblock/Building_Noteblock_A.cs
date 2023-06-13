using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_A : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_A.PlayOneShot(new TargetInfo(Position, Map));
    }
}