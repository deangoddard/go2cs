// Code generated by mkbuiltin.go. DO NOT EDIT.

// package gc -- go2cs converted at 2020 October 09 05:40:40 UTC
// import "cmd/compile/internal/gc" ==> using gc = go.cmd.compile.@internal.gc_package
// Original source: C:\Go\src\cmd\compile\internal\gc\builtin.go
using types = go.cmd.compile.@internal.types_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {


        private static slice<ptr<types.Type>> runtimeTypes()
        {
            array<ptr<types.Type>> typs = new array<ptr<types.Type>>(131L);
            typs[0L] = types.Bytetype;
            typs[1L] = types.NewPtr(typs[0L]);
            typs[2L] = types.Types[TANY];
            typs[3L] = types.NewPtr(typs[2L]);
            typs[4L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]) }));
            typs[5L] = types.Types[TUINTPTR];
            typs[6L] = types.Types[TBOOL];
            typs[7L] = types.Types[TUNSAFEPTR];
            typs[8L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[5]), anonfield(typs[1]), anonfield(typs[6]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]) }));
            typs[9L] = functype(null, null, null);
            typs[10L] = types.Types[TINTER];
            typs[11L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[10]) }), null);
            typs[12L] = types.Types[TINT32];
            typs[13L] = types.NewPtr(typs[12L]);
            typs[14L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[13]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[10]) }));
            typs[15L] = types.Types[TINT];
            typs[16L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[15]), anonfield(typs[15]) }), null);
            typs[17L] = types.Types[TUINT];
            typs[18L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[17]), anonfield(typs[15]) }), null);
            typs[19L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }), null);
            typs[20L] = types.Types[TFLOAT64];
            typs[21L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[20]) }), null);
            typs[22L] = types.Types[TINT64];
            typs[23L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[22]) }), null);
            typs[24L] = types.Types[TUINT64];
            typs[25L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[24]) }), null);
            typs[26L] = types.Types[TCOMPLEX128];
            typs[27L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[26]) }), null);
            typs[28L] = types.Types[TSTRING];
            typs[29L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }), null);
            typs[30L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[2]) }), null);
            typs[31L] = types.NewArray(typs[0L], 32L);
            typs[32L] = types.NewPtr(typs[31L]);
            typs[33L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[28]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[34L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[28]), anonfield(typs[28]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[35L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[28]), anonfield(typs[28]), anonfield(typs[28]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[36L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[28]), anonfield(typs[28]), anonfield(typs[28]), anonfield(typs[28]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[37L] = types.NewSlice(typs[28L]);
            typs[38L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[37]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[39L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[15]) }));
            typs[40L] = types.NewArray(typs[0L], 4L);
            typs[41L] = types.NewPtr(typs[40L]);
            typs[42L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[41]), anonfield(typs[22]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[43L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[1]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[44L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[45L] = types.Runetype;
            typs[46L] = types.NewSlice(typs[45L]);
            typs[47L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[46]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }));
            typs[48L] = types.NewSlice(typs[0L]);
            typs[49L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[32]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[48]) }));
            typs[50L] = types.NewArray(typs[45L], 32L);
            typs[51L] = types.NewPtr(typs[50L]);
            typs[52L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[51]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[46]) }));
            typs[53L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[15]), anonfield(typs[3]), anonfield(typs[15]), anonfield(typs[5]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[15]) }));
            typs[54L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[15]), anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[15]) }));
            typs[55L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[45]), anonfield(typs[15]) }));
            typs[56L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[28]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[15]) }));
            typs[57L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[2]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[2]) }));
            typs[58L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[2]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]) }));
            typs[59L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[2]) }));
            typs[60L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[2]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[2]), anonfield(typs[6]) }));
            typs[61L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[1]), anonfield(typs[1]) }), null);
            typs[62L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]) }), null);
            typs[63L] = types.NewPtr(typs[5L]);
            typs[64L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[63]), anonfield(typs[7]), anonfield(typs[7]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[65L] = types.Types[TUINT32];
            typs[66L] = functype(null, null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[65]) }));
            typs[67L] = types.NewMap(typs[2L], typs[2L]);
            typs[68L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[22]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[67]) }));
            typs[69L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[15]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[67]) }));
            typs[70L] = functype(null, null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[67]) }));
            typs[71L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]) }));
            typs[72L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[2]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]) }));
            typs[73L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[3]), anonfield(typs[1]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]) }));
            typs[74L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[6]) }));
            typs[75L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[2]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[6]) }));
            typs[76L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[3]), anonfield(typs[1]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[6]) }));
            typs[77L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[3]) }), null);
            typs[78L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]), anonfield(typs[2]) }), null);
            typs[79L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]) }), null);
            typs[80L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[67]) }), null);
            typs[81L] = types.NewChan(typs[2L], types.Cboth);
            typs[82L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[22]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[81]) }));
            typs[83L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[81]) }));
            typs[84L] = types.NewChan(typs[2L], types.Crecv);
            typs[85L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[84]), anonfield(typs[3]) }), null);
            typs[86L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[84]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[87L] = types.NewChan(typs[2L], types.Csend);
            typs[88L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[87]), anonfield(typs[3]) }), null);
            typs[89L] = types.NewArray(typs[0L], 3L);
            typs[90L] = tostruct(new slice<ptr<Node>>(new ptr<Node>[] { namedfield("enabled",typs[6]), namedfield("pad",typs[89]), namedfield("needed",typs[6]), namedfield("cgo",typs[6]), namedfield("alignme",typs[24]) }));
            typs[91L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[3]), anonfield(typs[3]) }), null);
            typs[92L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[3]) }), null);
            typs[93L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[3]), anonfield(typs[15]), anonfield(typs[3]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[15]) }));
            typs[94L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[87]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[95L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[84]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[96L] = types.NewPtr(typs[6L]);
            typs[97L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[96]), anonfield(typs[84]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[98L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[1]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[15]), anonfield(typs[6]) }));
            typs[99L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[15]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]) }));
            typs[100L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[22]), anonfield(typs[22]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]) }));
            typs[101L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[15]), anonfield(typs[15]), anonfield(typs[7]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]) }));
            typs[102L] = types.NewSlice(typs[2L]);
            typs[103L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[1]), anonfield(typs[102]), anonfield(typs[15]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[102]) }));
            typs[104L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[3]), anonfield(typs[5]) }), null);
            typs[105L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]), anonfield(typs[5]) }), null);
            typs[106L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[3]), anonfield(typs[5]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[107L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[3]), anonfield(typs[3]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[108L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]), anonfield(typs[7]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[6]) }));
            typs[109L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]), anonfield(typs[5]), anonfield(typs[5]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[5]) }));
            typs[110L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]), anonfield(typs[5]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[5]) }));
            typs[111L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[22]), anonfield(typs[22]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[22]) }));
            typs[112L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[24]), anonfield(typs[24]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[24]) }));
            typs[113L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[20]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[22]) }));
            typs[114L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[20]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[24]) }));
            typs[115L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[20]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[65]) }));
            typs[116L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[22]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[20]) }));
            typs[117L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[24]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[20]) }));
            typs[118L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[65]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[20]) }));
            typs[119L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[26]), anonfield(typs[26]) }), new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[26]) }));
            typs[120L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[5]) }), null);
            typs[121L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[5]), anonfield(typs[5]) }), null);
            typs[122L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]), anonfield(typs[1]), anonfield(typs[5]) }), null);
            typs[123L] = types.NewSlice(typs[7L]);
            typs[124L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[7]), anonfield(typs[123]) }), null);
            typs[125L] = types.Types[TUINT8];
            typs[126L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[125]), anonfield(typs[125]) }), null);
            typs[127L] = types.Types[TUINT16];
            typs[128L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[127]), anonfield(typs[127]) }), null);
            typs[129L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[65]), anonfield(typs[65]) }), null);
            typs[130L] = functype(null, new slice<ptr<Node>>(new ptr<Node>[] { anonfield(typs[24]), anonfield(typs[24]) }), null);
            return typs[..];
        }
    }
}}}}
