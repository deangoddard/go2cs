﻿//******************************************************************************************************
//  errors_errorString.cs - Gbtc
//
//  Copyright © 2020, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  06/30/2020 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System.Runtime.CompilerServices;

namespace go;

public static partial class errors_package
{
    private partial struct errorString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public errorString(@string s = default)
        {
            this.s = s;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString() => $"{{{s}}}";

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator errorString(@string value) => new errorString(value);

        // Person to nil comparisons
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(errorString obj, NilType _) => obj.Equals(default(errorString));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(errorString obj, NilType nil) => !(obj == nil);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(NilType nil, errorString obj) => obj == nil;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(NilType nil, errorString obj) => obj != nil;
    }
}
