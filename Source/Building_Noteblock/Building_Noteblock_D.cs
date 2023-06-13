using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_D : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_D.PlayOneShot(new TargetInfo(Position, Map));
    }
}