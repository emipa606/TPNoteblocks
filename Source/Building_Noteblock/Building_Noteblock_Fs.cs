using Verse;
using Verse.Sound;

namespace Noteblock;

public class Building_Noteblock_Fs : Building_Noteblock
{
    protected override void Spring(Pawn p)
    {
        SoundDefOf.TRAHS_Fs.PlayOneShot(new TargetInfo(Position, Map));
    }
}