using RimWorld;
using Verse;

namespace Noteblock;

[DefOf]
public static class SoundDefOf
{
    public static SoundDef TRAHS_B;

    public static SoundDef TRAHS_As;

    public static SoundDef TRAHS_A;

    public static SoundDef TRAHS_Gs;

    public static SoundDef TRAHS_G;

    public static SoundDef TRAHS_Fs;

    public static SoundDef TRAHS_F;

    public static SoundDef TRAHS_E;

    public static SoundDef TRAHS_Ds;

    public static SoundDef TRAHS_D;

    public static SoundDef TRAHS_C;

    public static SoundDef TRAHS_Cs;

    static SoundDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(SoundDefOf));
    }
}