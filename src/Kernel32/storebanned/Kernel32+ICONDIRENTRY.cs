﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="ICONDIRENTRY"/> nested type.
    /// </content>
    public partial class Kernel32
    {
        /// <summary>
        /// Represents an icon as stored in a '.ico' file
        /// </summary>
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct ICONDIRENTRY
        {
            /// <summary>
            /// Width, in pixels, of the image
            /// </summary>
            public byte bWidth;

            /// <summary>
            /// Height, in pixels, of the image
            /// </summary>
            public byte bHeight;

            /// <summary>
            /// Number of colors in image (0 if >= 8bpp)
            /// </summary>
            public byte bColorCount;

            /// <summary>
            /// Reserved
            /// </summary>
            public byte bReserved;

            /// <summary>
            /// Color Planes
            /// </summary>
            public ushort wPlanes;

            /// <summary>
            /// Bits per pixel
            /// </summary>
            public ushort wBitCount;

            /// <summary>
            /// How many bytes in this resource
            /// </summary>
            public uint dwBytesInRes;

            /// <summary>
            /// Location (relative to the start of the ICO file) of the actual image data.
            /// </summary>
            public uint dwImageOffset;
        }
    }
}
