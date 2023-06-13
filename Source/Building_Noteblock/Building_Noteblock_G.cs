using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_G : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_G.PlayOneShot(new TargetInfo(Position, Map));
    }
}