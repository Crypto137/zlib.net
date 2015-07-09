// inffixed.cs -- table for decoding fixed codes
// Copyright (C) 2007-2011 by the Authors
// For conditions of distribution and use, see copyright notice in License.txt

// Based on the automatically by makefixed() generated inffixed.h.

using System;

namespace Free.Ports.zLib
{
	public static partial class zlib
	{
		private static readonly code[] lenfix=new code[512]
		{
			new code(96,7, 0), new code(0,8, 80), new code(0,8,16), new code(20,8,115),
			new code(18,7,31), new code(0,8,112), new code(0,8,48), new code( 0,9,192),
			new code(16,7,10), new code(0,8, 96), new code(0,8,32), new code( 0,9,160),
			new code( 0,8, 0), new code(0,8,128), new code(0,8,64), new code( 0,9,224),
			new code(16,7, 6), new code(0,8, 88), new code(0,8,24), new code( 0,9,144),
			new code(19,7,59), new code(0,8,120), new code(0,8,56), new code( 0,9,208),
			new code(17,7,17), new code(0,8,104), new code(0,8,40), new code( 0,9,176), 
			new code( 0,8, 8), new code(0,8,136), new code(0,8,72), new code( 0,9,240),
			new code(16,7, 4), new code(0,8, 84), new code(0,8,20), new code(21,8,227),
			new code(19,7,43), new code(0,8,116), new code(0,8,52), new code( 0,9,200),
			new code(17,7,13), new code(0,8,100), new code(0,8,36), new code( 0,9,168),
			new code( 0,8, 4), new code(0,8,132), new code(0,8,68), new code( 0,9,232),
			new code(16,7, 8), new code(0,8, 92), new code(0,8,28), new code( 0,9,152),
			new code(20,7,83), new code(0,8,124), new code(0,8,60), new code( 0,9,216),
			new code(18,7,23), new code(0,8,108), new code(0,8,44), new code( 0,9,184),
			new code( 0,8,12), new code(0,8,140), new code(0,8,76), new code( 0,9,248),
			new code(16,7, 3), new code(0,8, 82), new code(0,8,18), new code(21,8,163),
			new code(19,7,35), new code(0,8,114), new code(0,8,50), new code( 0,9,196),
			new code(17,7,11), new code(0,8, 98), new code(0,8,34), new code( 0,9,164),
			new code( 0,8, 2), new code(0,8,130), new code(0,8,66), new code( 0,9,228),
			new code(16,7, 7), new code(0,8, 90), new code(0,8,26), new code( 0,9,148),
			new code(20,7,67), new code(0,8,122), new code(0,8,58), new code( 0,9,212),
			new code(18,7,19), new code(0,8,106), new code(0,8,42), new code( 0,9,180),
			new code( 0,8,10), new code(0,8,138), new code(0,8,74), new code( 0,9,244),
			new code(16,7, 5), new code(0,8, 86), new code(0,8,22), new code(64,8, 0),
			new code(19,7,51), new code(0,8,118), new code(0,8,54), new code( 0,9,204),
			new code(17,7,15), new code(0,8,102), new code(0,8,38), new code( 0,9,172),
			new code( 0,8, 6), new code(0,8,134), new code(0,8,70), new code( 0,9,236),
			new code(16,7, 9), new code(0,8, 94), new code(0,8,30), new code( 0,9,156),
			new code(20,7,99), new code(0,8,126), new code(0,8,62), new code( 0,9,220),
			new code(18,7,27), new code(0,8,110), new code(0,8,46), new code( 0,9,188),
			new code( 0,8,14), new code(0,8,142), new code(0,8,78), new code( 0,9,252),
			new code(96,7, 0), new code(0,8, 81), new code(0,8,17), new code(21,8,131),
			new code(18,7,31), new code(0,8,113), new code(0,8,49), new code( 0,9,194),
			new code(16,7,10), new code(0,8, 97), new code(0,8,33), new code( 0,9,162),
			new code( 0,8, 1), new code(0,8,129), new code(0,8,65), new code( 0,9,226),
			new code(16,7, 6), new code(0,8, 89), new code(0,8,25), new code( 0,9,146), 
			new code(19,7,59), new code(0,8,121), new code(0,8,57), new code( 0,9,210),
			new code(17,7,17), new code(0,8,105), new code(0,8,41), new code( 0,9,178),
			new code( 0,8, 9), new code(0,8,137), new code(0,8,73), new code( 0,9,242),
			new code(16,7, 4), new code(0,8, 85), new code(0,8,21), new code(16,8,258),
			new code(19,7,43), new code(0,8,117), new code(0,8,53), new code( 0,9,202),
			new code(17,7,13), new code(0,8,101), new code(0,8,37), new code( 0,9,170),
			new code( 0,8, 5), new code(0,8,133), new code(0,8,69), new code( 0,9,234),
			new code(16,7, 8), new code(0,8, 93), new code(0,8,29), new code( 0,9,154),
			new code(20,7,83), new code(0,8,125), new code(0,8,61), new code( 0,9,218),
			new code(18,7,23), new code(0,8,109), new code(0,8,45), new code( 0,9,186),
			new code( 0,8,13), new code(0,8,141), new code(0,8,77), new code( 0,9,250),
			new code(16,7, 3), new code(0,8, 83), new code(0,8,19), new code(21,8,195),
			new code(19,7,35), new code(0,8,115), new code(0,8,51), new code( 0,9,198),
			new code(17,7,11), new code(0,8, 99), new code(0,8,35), new code( 0,9,166),
			new code( 0,8, 3), new code(0,8,131), new code(0,8,67), new code( 0,9,230), 
			new code(16,7, 7), new code(0,8, 91), new code(0,8,27), new code( 0,9,150), 
			new code(20,7,67), new code(0,8,123), new code(0,8,59), new code( 0,9,214), 
			new code(18,7,19), new code(0,8,107), new code(0,8,43), new code( 0,9,182),
			new code( 0,8,11), new code(0,8,139), new code(0,8,75), new code( 0,9,246), 
			new code(16,7, 5), new code(0,8, 87), new code(0,8,23), new code(64,8,  0),
			new code(19,7,51), new code(0,8,119), new code(0,8,55), new code( 0,9,206),
			new code(17,7,15), new code(0,8,103), new code(0,8,39), new code( 0,9,174),
			new code( 0,8, 7), new code(0,8,135), new code(0,8,71), new code( 0,9,238),
			new code(16,7, 9), new code(0,8, 95), new code(0,8,31), new code( 0,9,158), 
			new code(20,7,99), new code(0,8,127), new code(0,8,63), new code( 0,9,222),
			new code(18,7,27), new code(0,8,111), new code(0,8,47), new code( 0,9,190),
			new code( 0,8,15), new code(0,8,143), new code(0,8,79), new code( 0,9,254),
			new code(96,7, 0), new code(0,8, 80), new code(0,8,16), new code(20,8,115),
			new code(18,7,31), new code(0,8,112), new code(0,8,48), new code( 0,9,193),
			new code(16,7,10), new code(0,8, 96), new code(0,8,32), new code( 0,9,161),
			new code( 0,8, 0), new code(0,8,128), new code(0,8,64), new code( 0,9,225),
			new code(16,7, 6), new code(0,8, 88), new code(0,8,24), new code( 0,9,145),
			new code(19,7,59), new code(0,8,120), new code(0,8,56), new code( 0,9,209),
			new code(17,7,17), new code(0,8,104), new code(0,8,40), new code( 0,9,177),
			new code( 0,8, 8), new code(0,8,136), new code(0,8,72), new code( 0,9,241),
			new code(16,7, 4), new code(0,8, 84), new code(0,8,20), new code(21,8,227),
			new code(19,7,43), new code(0,8,116), new code(0,8,52), new code( 0,9,201),
			new code(17,7,13), new code(0,8,100), new code(0,8,36), new code( 0,9,169),
			new code( 0,8, 4), new code(0,8,132), new code(0,8,68), new code( 0,9,233),
			new code(16,7, 8), new code(0,8, 92), new code(0,8,28), new code( 0,9,153),
			new code(20,7,83), new code(0,8,124), new code(0,8,60), new code( 0,9,217),
			new code(18,7,23), new code(0,8,108), new code(0,8,44), new code( 0,9,185),
			new code( 0,8,12), new code(0,8,140), new code(0,8,76), new code( 0,9,249),
			new code(16,7, 3), new code(0,8, 82), new code(0,8,18), new code(21,8,163), 
			new code(19,7,35), new code(0,8,114), new code(0,8,50), new code( 0,9,197),
			new code(17,7,11), new code(0,8, 98), new code(0,8,34), new code( 0,9,165), 
			new code( 0,8, 2), new code(0,8,130), new code(0,8,66), new code( 0,9,229),
			new code(16,7, 7), new code(0,8, 90), new code(0,8,26), new code( 0,9,149), 
			new code(20,7,67), new code(0,8,122), new code(0,8,58), new code( 0,9,213),
			new code(18,7,19), new code(0,8,106), new code(0,8,42), new code( 0,9,181),
			new code( 0,8,10), new code(0,8,138), new code(0,8,74), new code( 0,9,245), 
			new code(16,7, 5), new code(0,8, 86), new code(0,8,22), new code(64,8,  0), 
			new code(19,7,51), new code(0,8,118), new code(0,8,54), new code( 0,9,205),
			new code(17,7,15), new code(0,8,102), new code(0,8,38), new code( 0,9,173),
			new code( 0,8, 6), new code(0,8,134), new code(0,8,70), new code( 0,9,237),
			new code(16,7, 9), new code(0,8, 94), new code(0,8,30), new code( 0,9,157),
			new code(20,7,99), new code(0,8,126), new code(0,8,62), new code( 0,9,221),
			new code(18,7,27), new code(0,8,110), new code(0,8,46), new code( 0,9,189),
			new code( 0,8,14), new code(0,8,142), new code(0,8,78), new code( 0,9,253), 
			new code(96,7, 0), new code(0,8, 81), new code(0,8,17), new code(21,8,131), 
			new code(18,7,31), new code(0,8,113), new code(0,8,49), new code( 0,9,195),
			new code(16,7,10), new code(0,8, 97), new code(0,8,33), new code( 0,9,163), 
			new code( 0,8, 1), new code(0,8,129), new code(0,8,65), new code( 0,9,227), 
			new code(16,7, 6), new code(0,8, 89), new code(0,8,25), new code( 0,9,147), 
			new code(19,7,59), new code(0,8,121), new code(0,8,57), new code( 0,9,211),
			new code(17,7,17), new code(0,8,105), new code(0,8,41), new code( 0,9,179),
			new code( 0,8, 9), new code(0,8,137), new code(0,8,73), new code( 0,9,243), 
			new code(16,7, 4), new code(0,8, 85), new code(0,8,21), new code(16,8,258),
			new code(19,7,43), new code(0,8,117), new code(0,8,53), new code( 0,9,203),
			new code(17,7,13), new code(0,8,101), new code(0,8,37), new code( 0,9,171), 
			new code( 0,8, 5), new code(0,8,133), new code(0,8,69), new code( 0,9,235),
			new code(16,7, 8), new code(0,8, 93), new code(0,8,29), new code( 0,9,155),
			new code(20,7,83), new code(0,8,125), new code(0,8,61), new code( 0,9,219),
			new code(18,7,23), new code(0,8,109), new code(0,8,45), new code( 0,9,187),
			new code( 0,8,13), new code(0,8,141), new code(0,8,77), new code( 0,9,251),
			new code(16,7, 3), new code(0,8, 83), new code(0,8,19), new code(21,8,195),
			new code(19,7,35), new code(0,8,115), new code(0,8,51), new code( 0,9,199),
			new code(17,7,11), new code(0,8, 99), new code(0,8,35), new code( 0,9,167),
			new code( 0,8, 3), new code(0,8,131), new code(0,8,67), new code( 0,9,231),
			new code(16,7, 7), new code(0,8, 91), new code(0,8,27), new code( 0,9,151),
			new code(20,7,67), new code(0,8,123), new code(0,8,59), new code( 0,9,215),
			new code(18,7,19), new code(0,8,107), new code(0,8,43), new code( 0,9,183),
			new code( 0,8,11), new code(0,8,139), new code(0,8,75), new code( 0,9,247),
			new code(16,7, 5), new code(0,8, 87), new code(0,8,23), new code(64,8,  0),
			new code(19,7,51), new code(0,8,119), new code(0,8,55), new code( 0,9,207),
			new code(17,7,15), new code(0,8,103), new code(0,8,39), new code( 0,9,175),
			new code( 0,8, 7), new code(0,8,135), new code(0,8,71), new code( 0,9,239), 
			new code(16,7, 9), new code(0,8, 95), new code(0,8,31), new code( 0,9,159),
			new code(20,7,99), new code(0,8,127), new code(0,8,63), new code( 0,9,223),
			new code(18,7,27), new code(0,8,111), new code(0,8,47), new code( 0,9,191),
			new code( 0,8,15), new code(0,8,143), new code(0,8,79), new code( 0,9,255)
		};

		private static readonly code[] distfix=new code[32]
		{
	        new code(16,5, 1), new code(23,5, 257), new code(19,5, 17), new code(27,5, 4097),
			new code(17,5, 5), new code(25,5,1025), new code(21,5, 65), new code(29,5,16385),
			new code(16,5, 3), new code(24,5, 513), new code(20,5, 33), new code(28,5, 8193),
			new code(18,5, 9), new code(26,5,2049), new code(22,5,129), new code(64,5,    0),
			new code(16,5, 2), new code(23,5, 385), new code(19,5, 25), new code(27,5, 6145),
			new code(17,5, 7), new code(25,5,1537), new code(21,5, 97), new code(29,5,24577),
			new code(16,5, 4), new code(24,5, 769), new code(20,5, 49), new code(28,5,12289),
			new code(18,5,13), new code(26,5,3073), new code(22,5,193), new code(64,5,    0)
		};
	}
}
