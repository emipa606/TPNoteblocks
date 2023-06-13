using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_Cs : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_Cs.PlayOneShot(new TargetInfo(Position, Map));
    }
}