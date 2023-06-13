using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_F : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_F.PlayOneShot(new TargetInfo(Position, Map));
    }
}