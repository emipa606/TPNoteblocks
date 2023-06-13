using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_Ds : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_Ds.PlayOneShot(new TargetInfo(Position, Map));
    }
}