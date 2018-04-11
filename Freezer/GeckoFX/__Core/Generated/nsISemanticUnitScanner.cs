// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsISemanticUnitScanner.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// Provides a language independent way to break UNICODE
    /// text into meaningful semantic units (e.g. words).
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9f620be4-e535-11d6-b254-00039310a47a")]
	internal interface nsISemanticUnitScanner
	{
		
		/// <summary>
        /// start()
        ///
        /// Starts up the semantic unit scanner with an optional
        /// character set, which acts as a hint to optimize the heuristics
        /// used to determine the language(s) of the processed text.
        ///
        /// @param characterSet the character set the text was originally
        /// encoded in (can be NULL)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Start([MarshalAs(UnmanagedType.LPStr)] string characterSet);
		
		/// <summary>
        /// next()
        /// Get the begin / end offset of the next unit in the current text
        ///
        /// @param text the text to be scanned
        /// @param length the number of characters in the text to be processed
        /// @param pos the current position
        /// @param isLastBuffer, the buffer is the last one
        /// @param begin the begin offset of the next unit
        /// @param begin the end offset of the next unit
        /// @return has more unit in the current text
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string text, int length, int pos, [MarshalAs(UnmanagedType.U1)] bool isLastBuffer, ref int begin, ref int end);
	}
}