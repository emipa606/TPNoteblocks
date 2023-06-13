using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_As : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_As.PlayOneShot(new TargetInfo(Position, Map));
    }
}