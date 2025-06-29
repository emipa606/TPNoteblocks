using System.Collections.Generic;
using Verse;

namespace Noteblock;

public abstract class Building_Noteblock : Building
{
    private List<Pawn> touchingPawns = [];

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Collections.Look(ref touchingPawns, "testees", LookMode.Reference);
    }

    protected override void Tick()
    {
        if (!Spawned)
        {
            base.Tick();
            return;
        }

        var thingList = Position.GetThingList(Map);
        foreach (var thing in thingList)
        {
            if (thing is not Pawn pawn || touchingPawns.Contains(pawn))
            {
                continue;
            }

            touchingPawns.Add(pawn);
            checkSpring(pawn);
        }

        for (var j = 0; j < touchingPawns.Count; j++)
        {
            var pawn2 = touchingPawns[j];
            if (!pawn2.Spawned || pawn2.Position != Position)
            {
                touchingPawns.Remove(pawn2);
            }
        }

        base.Tick();
    }

    private void checkSpring(Pawn p)
    {
        if (!Rand.Chance(springChance()))
        {
            return;
        }

        Spring(p);
    }

    private static float springChance()
    {
        return 1f;
    }

    protected virtual void Spring(Pawn p)
    {
    }
}