// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    /// <summary>The interface that represents an absolute reference to a font face. It contains font face type, appropriate file references and face identification data. Various font data such as metrics, names and glyph outlines is obtained from IDWriteFontFace.</summary>
    [Guid("5F49804D-7024-4D43-BFA9-D25984F53849")]
    public unsafe struct IDWriteFontFace
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFace* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFace* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFace* This);

        /// <summary>Obtains the file format type of a font face.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_FACE_TYPE __GetType(IDWriteFontFace* This);

        /// <summary>Obtains the font files representing a font face.</summary>
        /// <param name="numberOfFiles">The number of files representing the font face.</param>
        /// <param name="fontFiles">User provided array that stores pointers to font files representing the font face. This parameter can be NULL if the user is only interested in the number of files representing the font face. This API increments reference count of the font file pointers returned according to COM conventions, and the client should release them when finished.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFiles(IDWriteFontFace* This, [NativeTypeName("UINT32")] uint* numberOfFiles, IDWriteFontFile** fontFiles = null);

        /// <summary>Obtains the zero-based index of the font face in its font file or files. If the font files contain a single face, the return value is zero.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetIndex(IDWriteFontFace* This);

        /// <summary>Obtains the algorithmic style simulation flags of a font face.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_FONT_SIMULATIONS _GetSimulations(IDWriteFontFace* This);

        /// <summary>Determines whether the font is a symbol font.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsSymbolFont(IDWriteFontFace* This);

        /// <summary>Obtains design units and common metrics for the font face. These metrics are applicable to all the glyphs within a fontface and are used by applications for layout calculations.</summary>
        /// <param name="fontFaceMetrics">Points to a DWRITE_FONT_METRICS public structure to fill in. The metrics returned by this function are in font design units.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetMetrics(IDWriteFontFace* This, DWRITE_FONT_METRICS* fontFaceMetrics);

        /// <summary>Obtains the number of glyphs in the font face.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT16")]
        public delegate ushort _GetGlyphCount(IDWriteFontFace* This);

        /// <summary>Obtains ideal glyph metrics in font design units. Design glyphs metrics are used for glyph positioning.</summary>
        /// <param name="glyphIndices">An array of glyph indices to compute the metrics for.</param>
        /// <param name="glyphCount">The number of elements in the glyphIndices array.</param>
        /// <param name="glyphMetrics">Array of DWRITE_GLYPH_METRICS public structures filled by this function. The metrics returned by this function are in font design units.</param>
        /// <param name="isSideways">Indicates whether the font is being used in a sideways run. This can affect the glyph metrics if the font has oblique simulation because sideways oblique simulation differs from non-sideways oblique simulation.</param>
        /// <returns>Standard HRESULT error code. If any of the input glyph indices are outside of the valid glyph index range for the current font face, E_INVALIDARG will be returned.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDesignGlyphMetrics(IDWriteFontFace* This, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = FALSE);

        /// <summary>Returns the nominal mapping of UTF-32 Unicode code points to glyph indices as defined by the font 'cmap' table. Note that this mapping is primarily provided for line layout engines built on top of the physical font API. Because of OpenType glyph substitution and line layout character substitution, the nominal conversion does not always correspond to how a Unicode string will map to glyph indices when rendering using a particular font face. Also, note that Unicode Variation Selectors provide for alternate mappings for character to glyph. This call will always return the default variant.</summary>
        /// <param name="codePoints">An array of UTF-32 code points to obtain nominal glyph indices from.</param>
        /// <param name="codePointCount">The number of elements in the codePoints array.</param>
        /// <param name="glyphIndices">Array of nominal glyph indices filled by this function.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphIndices(IDWriteFontFace* This, [NativeTypeName("UINT32[]")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16")] ushort* glyphIndices);

        /// <summary>Finds the specified OpenType font table if it exists and returns a pointer to it. The function accesses the underlying font data via the IDWriteFontFileStream interface implemented by the font file loader.</summary>
        /// <param name="openTypeTableTag">Four character tag of table to find. Use the DWRITE_MAKE_OPENTYPE_TAG() macro to create it. Unlike GDI, it does not support the special TTCF and null tags to access the whole font.</param>
        /// <param name="tableData">Pointer to base of table in memory. The pointer is only valid so long as the FontFace used to get the font table still exists (not any other FontFace, even if it actually refers to the same physical font).</param>
        /// <param name="tableSize">Byte size of table.</param>
        /// <param name="tableContext">Opaque context which must be freed by calling ReleaseFontTable. The context actually comes from the lower level IDWriteFontFileStream, which may be implemented by the application or DWrite itself. It is possible for a NULL tableContext to be returned, especially if the implementation directly memory maps the whole file. Nevertheless, always release it later, and do not use it as a test for function success. The same table can be queried multiple times, but each returned context can be different, so release each separately.</param>
        /// <param name="exists">True if table exists.</param>
        /// <returns>Standard HRESULT error code.If a table can not be found, the function will not return an error, but the size will be 0, table NULL, and exists = FALSE. The context does not need to be freed if the table was not found.</returns>
        /// <remarks>The context for the same tag may be different for each call,so each one must be held and released separately.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _TryGetFontTable(IDWriteFontFace* This, [NativeTypeName("UINT32")] uint openTypeTableTag, void** tableData, [NativeTypeName("UINT32")] uint* tableSize, void** tableContext, [NativeTypeName("BOOL")] int* exists);

        /// <summary>Releases the table obtained earlier from TryGetFontTable.</summary>
        /// <param name="tableContext">Opaque context from TryGetFontTable.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _ReleaseFontTable(IDWriteFontFace* This, void* tableContext);

        /// <summary>Computes the outline of a run of glyphs by calling back to the outline sink interface.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="glyphIndices">Array of glyph indices.</param>
        /// <param name="glyphAdvances">Optional array of glyph advances in DIPs.</param>
        /// <param name="glyphOffsets">Optional array of glyph offsets.</param>
        /// <param name="glyphCount">Number of glyphs.</param>
        /// <param name="isSideways">If true, specifies that glyphs are rotated 90 degrees to the left and vertical metrics are used. A client can render a vertical run by specifying isSideways = true and rotating the resulting geometry 90 degrees to the right using a transform.</param>
        /// <param name="isRightToLeft">If true, specifies that the advance direction is right to left. By default, the advance direction is left to right.</param>
        /// <param name="geometrySink">Interface the function calls back to draw each element of the geometry.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGlyphRunOutline(IDWriteFontFace* This, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [Optional, NativeTypeName("FLOAT[]")] float* glyphAdvances, [Optional, NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink")] IntPtr geometrySink);

        /// <summary>Determines the recommended rendering mode for the font given the specified size and rendering parameters.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="measuringMode">Specifies measuring mode that will be used for glyphs in the font. Renderer implementations may choose different rendering modes for given measuring modes, but best results are seen when the corresponding modes match: DWRITE_RENDERING_MODE_CLEARTYPE_NATURAL for DWRITE_MEASURING_MODE_NATURAL DWRITE_RENDERING_MODE_CLEARTYPE_GDI_CLASSIC for DWRITE_MEASURING_MODE_GDI_CLASSIC DWRITE_RENDERING_MODE_CLEARTYPE_GDI_NATURAL for DWRITE_MEASURING_MODE_GDI_NATURAL</param>
        /// <param name="renderingParams">Rendering parameters object. This parameter is necessary in case the rendering parameters object overrides the rendering mode.</param>
        /// <param name="renderingMode">Receives the recommended rendering mode to use.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetRecommendedRenderingMode(IDWriteFontFace* This, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode);

        /// <summary>Obtains design units and common metrics for the font face. These metrics are applicable to all the glyphs within a fontface and are used by applications for layout calculations.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the font size and pixelsPerDip.</param>
        /// <param name="fontFaceMetrics">Points to a DWRITE_FONT_METRICS public structure to fill in. The metrics returned by this function are in font design units.</param>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleMetrics(IDWriteFontFace* This, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics);

        /// <summary>Obtains glyph metrics in font design units with the return values compatible with what GDI would produce. Glyphs metrics are used for positioning of individual glyphs.</summary>
        /// <param name="emSize">Logical size of the font in DIP units. A DIP ("device-independent pixel") equals 1/96 inch.</param>
        /// <param name="pixelsPerDip">Number of physical pixels per DIP. For example, if the DPI of the rendering surface is 96 this value is 1.0f. If the DPI is 120, this value is 120.0f/96.</param>
        /// <param name="transform">Optional transform applied to the glyphs and their positions. This transform is applied after the scaling specified by the font size and pixelsPerDip.</param>
        /// <param name="useGdiNatural"> When set to FALSE, the metrics are the same as the metrics of GDI aliased text. When set to TRUE, the metrics are the same as the metrics of text measured by GDI using a font created with CLEARTYPE_NATURAL_QUALITY.</param>
        /// <param name="glyphIndices">An array of glyph indices to compute the metrics for.</param>
        /// <param name="glyphCount">The number of elements in the glyphIndices array.</param>
        /// <param name="glyphMetrics">Array of DWRITE_GLYPH_METRICS public structures filled by this function. The metrics returned by this function are in font design units.</param>
        /// <param name="isSideways">Indicates whether the font is being used in a sideways run. This can affect the glyph metrics if the font has oblique simulation because sideways oblique simulation differs from non-sideways oblique simulation.</param>
        /// <returns>Standard HRESULT error code. If any of the input glyph indices are outside of the valid glyph index range for the current font face, E_INVALIDARG will be returned.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetGdiCompatibleGlyphMetrics(IDWriteFontFace* This, [NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS[]")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = FALSE);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        public DWRITE_FONT_FACE_TYPE _GetType()
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFiles([NativeTypeName("UINT32")] uint* numberOfFiles, IDWriteFontFile** fontFiles = null)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFiles>(lpVtbl->GetFiles)(This, numberOfFiles, fontFiles);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetIndex()
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetIndex>(lpVtbl->GetIndex)(This);
            }
        }

        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetSimulations>(lpVtbl->GetSimulations)(This);
            }
        }

        [return: NativeTypeName("BOOL")]
        public int IsSymbolFont()
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsSymbolFont>(lpVtbl->IsSymbolFont)(This);
            }
        }

        public void GetMetrics(DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetMetrics>(lpVtbl->GetMetrics)(This, fontFaceMetrics);
            }
        }

        [return: NativeTypeName("UINT16")]
        public ushort GetGlyphCount()
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphCount>(lpVtbl->GetGlyphCount)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDesignGlyphMetrics([NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = FALSE)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDesignGlyphMetrics>(lpVtbl->GetDesignGlyphMetrics)(This, glyphIndices, glyphCount, glyphMetrics, isSideways);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphIndices([NativeTypeName("UINT32[]")] uint* codePoints, [NativeTypeName("UINT32")] uint codePointCount, [NativeTypeName("UINT16")] ushort* glyphIndices)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphIndices>(lpVtbl->GetGlyphIndices)(This, codePoints, codePointCount, glyphIndices);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int TryGetFontTable([NativeTypeName("UINT32")] uint openTypeTableTag, void** tableData, [NativeTypeName("UINT32")] uint* tableSize, void** tableContext, [NativeTypeName("BOOL")] int* exists)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_TryGetFontTable>(lpVtbl->TryGetFontTable)(This, openTypeTableTag, tableData, tableSize, tableContext, exists);
            }
        }

        public void ReleaseFontTable(void* tableContext)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_ReleaseFontTable>(lpVtbl->ReleaseFontTable)(This, tableContext);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGlyphRunOutline([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [Optional, NativeTypeName("FLOAT[]")] float* glyphAdvances, [Optional, NativeTypeName("DWRITE_GLYPH_OFFSET[]")] DWRITE_GLYPH_OFFSET* glyphOffsets, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("BOOL")] int isSideways, [NativeTypeName("BOOL")] int isRightToLeft, [NativeTypeName("IDWriteGeometrySink")] IntPtr geometrySink)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGlyphRunOutline>(lpVtbl->GetGlyphRunOutline)(This, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRecommendedRenderingMode([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, DWRITE_MEASURING_MODE measuringMode, IDWriteRenderingParams* renderingParams, DWRITE_RENDERING_MODE* renderingMode)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRecommendedRenderingMode>(lpVtbl->GetRecommendedRenderingMode)(This, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, DWRITE_FONT_METRICS* fontFaceMetrics)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleMetrics>(lpVtbl->GetGdiCompatibleMetrics)(This, emSize, pixelsPerDip, transform, fontFaceMetrics);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetGdiCompatibleGlyphMetrics([NativeTypeName("FLOAT")] float emSize, [NativeTypeName("FLOAT")] float pixelsPerDip, [Optional] DWRITE_MATRIX* transform, [NativeTypeName("BOOL")] int useGdiNatural, [NativeTypeName("UINT16[]")] ushort* glyphIndices, [NativeTypeName("UINT32")] uint glyphCount, [NativeTypeName("DWRITE_GLYPH_METRICS[]")] DWRITE_GLYPH_METRICS* glyphMetrics, [NativeTypeName("BOOL")] int isSideways = FALSE)
        {
            fixed (IDWriteFontFace* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGdiCompatibleGlyphMetrics>(lpVtbl->GetGdiCompatibleGlyphMetrics)(This, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr _GetType;

            public IntPtr GetFiles;

            public IntPtr GetIndex;

            public IntPtr GetSimulations;

            public IntPtr IsSymbolFont;

            public IntPtr GetMetrics;

            public IntPtr GetGlyphCount;

            public IntPtr GetDesignGlyphMetrics;

            public IntPtr GetGlyphIndices;

            public IntPtr TryGetFontTable;

            public IntPtr ReleaseFontTable;

            public IntPtr GetGlyphRunOutline;

            public IntPtr GetRecommendedRenderingMode;

            public IntPtr GetGdiCompatibleMetrics;

            public IntPtr GetGdiCompatibleGlyphMetrics;
        }
    }
}