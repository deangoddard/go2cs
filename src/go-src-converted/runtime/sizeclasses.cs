// Code generated by mksizeclasses.go; DO NOT EDIT.
//go:generate go run mksizeclasses.go

// package runtime -- go2cs converted at 2020 October 09 04:48:38 UTC
// import "runtime" ==> using runtime = go.runtime_package
// Original source: C:\Go\src\runtime\sizeclasses.go

using static go.builtin;

namespace go
{
    public static partial class runtime_package
    {
        // class  bytes/obj  bytes/span  objects  tail waste  max waste
        //     1          8        8192     1024           0     87.50%
        //     2         16        8192      512           0     43.75%
        //     3         32        8192      256           0     46.88%
        //     4         48        8192      170          32     31.52%
        //     5         64        8192      128           0     23.44%
        //     6         80        8192      102          32     19.07%
        //     7         96        8192       85          32     15.95%
        //     8        112        8192       73          16     13.56%
        //     9        128        8192       64           0     11.72%
        //    10        144        8192       56         128     11.82%
        //    11        160        8192       51          32      9.73%
        //    12        176        8192       46          96      9.59%
        //    13        192        8192       42         128      9.25%
        //    14        208        8192       39          80      8.12%
        //    15        224        8192       36         128      8.15%
        //    16        240        8192       34          32      6.62%
        //    17        256        8192       32           0      5.86%
        //    18        288        8192       28         128     12.16%
        //    19        320        8192       25         192     11.80%
        //    20        352        8192       23          96      9.88%
        //    21        384        8192       21         128      9.51%
        //    22        416        8192       19         288     10.71%
        //    23        448        8192       18         128      8.37%
        //    24        480        8192       17          32      6.82%
        //    25        512        8192       16           0      6.05%
        //    26        576        8192       14         128     12.33%
        //    27        640        8192       12         512     15.48%
        //    28        704        8192       11         448     13.93%
        //    29        768        8192       10         512     13.94%
        //    30        896        8192        9         128     15.52%
        //    31       1024        8192        8           0     12.40%
        //    32       1152        8192        7         128     12.41%
        //    33       1280        8192        6         512     15.55%
        //    34       1408       16384       11         896     14.00%
        //    35       1536        8192        5         512     14.00%
        //    36       1792       16384        9         256     15.57%
        //    37       2048        8192        4           0     12.45%
        //    38       2304       16384        7         256     12.46%
        //    39       2688        8192        3         128     15.59%
        //    40       3072       24576        8           0     12.47%
        //    41       3200       16384        5         384      6.22%
        //    42       3456       24576        7         384      8.83%
        //    43       4096        8192        2           0     15.60%
        //    44       4864       24576        5         256     16.65%
        //    45       5376       16384        3         256     10.92%
        //    46       6144       24576        4           0     12.48%
        //    47       6528       32768        5         128      6.23%
        //    48       6784       40960        6         256      4.36%
        //    49       6912       49152        7         768      3.37%
        //    50       8192        8192        1           0     15.61%
        //    51       9472       57344        6         512     14.28%
        //    52       9728       49152        5         512      3.64%
        //    53      10240       40960        4           0      4.99%
        //    54      10880       32768        3         128      6.24%
        //    55      12288       24576        2           0     11.45%
        //    56      13568       40960        3         256      9.99%
        //    57      14336       57344        4           0      5.35%
        //    58      16384       16384        1           0     12.49%
        //    59      18432       73728        4           0     11.11%
        //    60      19072       57344        3         128      3.57%
        //    61      20480       40960        2           0      6.87%
        //    62      21760       65536        3         256      6.25%
        //    63      24576       24576        1           0     11.45%
        //    64      27264       81920        3         128     10.00%
        //    65      28672       57344        2           0      4.91%
        //    66      32768       32768        1           0     12.50%
        private static readonly long _MaxSmallSize = (long)32768L;
        private static readonly long smallSizeDiv = (long)8L;
        private static readonly long smallSizeMax = (long)1024L;
        private static readonly long largeSizeDiv = (long)128L;
        private static readonly long _NumSizeClasses = (long)67L;
        private static readonly long _PageShift = (long)13L;


        private static array<ushort> class_to_size = new array<ushort>(new ushort[] { 0, 8, 16, 32, 48, 64, 80, 96, 112, 128, 144, 160, 176, 192, 208, 224, 240, 256, 288, 320, 352, 384, 416, 448, 480, 512, 576, 640, 704, 768, 896, 1024, 1152, 1280, 1408, 1536, 1792, 2048, 2304, 2688, 3072, 3200, 3456, 4096, 4864, 5376, 6144, 6528, 6784, 6912, 8192, 9472, 9728, 10240, 10880, 12288, 13568, 14336, 16384, 18432, 19072, 20480, 21760, 24576, 27264, 28672, 32768 });
        private static array<byte> class_to_allocnpages = new array<byte>(new byte[] { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 2, 1, 2, 1, 3, 2, 3, 1, 3, 2, 3, 4, 5, 6, 1, 7, 6, 5, 4, 3, 5, 7, 2, 9, 7, 5, 8, 3, 10, 7, 4 });

        private partial struct divMagic
        {
            public byte shift;
            public byte shift2;
            public ushort mul;
            public ushort baseMask;
        }

        private static array<divMagic> class_to_divmagic = new array<divMagic>(new divMagic[] { {0,0,0,0}, {3,0,1,65528}, {4,0,1,65520}, {5,0,1,65504}, {4,11,683,0}, {6,0,1,65472}, {4,10,205,0}, {5,9,171,0}, {4,11,293,0}, {7,0,1,65408}, {4,13,911,0}, {5,10,205,0}, {4,12,373,0}, {6,9,171,0}, {4,13,631,0}, {5,11,293,0}, {4,13,547,0}, {8,0,1,65280}, {5,9,57,0}, {6,9,103,0}, {5,12,373,0}, {7,7,43,0}, {5,10,79,0}, {6,10,147,0}, {5,11,137,0}, {9,0,1,65024}, {6,9,57,0}, {7,9,103,0}, {6,11,187,0}, {8,7,43,0}, {7,8,37,0}, {10,0,1,64512}, {7,9,57,0}, {8,6,13,0}, {7,11,187,0}, {9,5,11,0}, {8,8,37,0}, {11,0,1,63488}, {8,9,57,0}, {7,10,49,0}, {10,5,11,0}, {7,10,41,0}, {7,9,19,0}, {12,0,1,61440}, {8,9,27,0}, {8,10,49,0}, {11,5,11,0}, {7,13,161,0}, {7,13,155,0}, {8,9,19,0}, {13,0,1,57344}, {8,12,111,0}, {9,9,27,0}, {11,6,13,0}, {7,14,193,0}, {12,3,3,0}, {8,13,155,0}, {11,8,37,0}, {14,0,1,49152}, {11,8,29,0}, {7,13,55,0}, {12,5,7,0}, {8,14,193,0}, {13,3,3,0}, {7,14,77,0}, {12,7,19,0}, {15,0,1,32768} });
        private static array<byte> size_to_class8 = new array<byte>(new byte[] { 0, 1, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12, 12, 13, 13, 14, 14, 15, 15, 16, 16, 17, 17, 18, 18, 18, 18, 19, 19, 19, 19, 20, 20, 20, 20, 21, 21, 21, 21, 22, 22, 22, 22, 23, 23, 23, 23, 24, 24, 24, 24, 25, 25, 25, 25, 26, 26, 26, 26, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27, 27, 27, 28, 28, 28, 28, 28, 28, 28, 28, 29, 29, 29, 29, 29, 29, 29, 29, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 30, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31, 31 });
        private static array<byte> size_to_class128 = new array<byte>(new byte[] { 31, 32, 33, 34, 35, 36, 36, 37, 37, 38, 38, 39, 39, 39, 40, 40, 40, 41, 42, 42, 43, 43, 43, 43, 43, 44, 44, 44, 44, 44, 44, 45, 45, 45, 45, 46, 46, 46, 46, 46, 46, 47, 47, 47, 48, 48, 49, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 51, 51, 51, 51, 51, 51, 51, 51, 51, 51, 52, 52, 53, 53, 53, 53, 54, 54, 54, 54, 54, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 55, 56, 56, 56, 56, 56, 56, 56, 56, 56, 56, 57, 57, 57, 57, 57, 57, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 58, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 59, 60, 60, 60, 60, 60, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 61, 62, 62, 62, 62, 62, 62, 62, 62, 62, 62, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 63, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 64, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 65, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66, 66 });
    }
}
