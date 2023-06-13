using System.Collections.Generic;
using Verse;

namespace Noteblock;

public abstract class Building_Noteblock : Building
{
    private List<Pawn> touchingPawns = new List<Pawn>();

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Collections.Look(ref touchingPawns, "testees", LookMode.Reference);
    }

    public override void Tick()
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
            CheckSpring(pawn);
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

    private void CheckSpring(Pawn p)
    {
        if (!Rand.Chance(SpringChance(p)))
        {
            return;
        }

        Spring(p);
    }

    protected float SpringChance(Pawn p)
    {
        return 1f;
    }

    protected virtual void Spring(Pawn p)
    {
    }
}