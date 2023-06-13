using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_B : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_B.PlayOneShot(new TargetInfo(Position, Map));
    }
}