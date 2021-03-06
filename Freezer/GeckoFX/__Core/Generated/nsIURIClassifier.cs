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
// Generated by IDLImporter from file nsIURIClassifier.idl
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
    /// Callback function for nsIURIClassifier lookups.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8face46e-0c96-470f-af40-0037dcd797bd")]
	internal interface nsIURIClassifierCallback
	{
		
		/// <summary>
        /// Called by the URI classifier service when it is done checking a URI.
        ///
        /// Clients are responsible for associating callback objects with classify()
        /// calls.
        ///
        /// @param aErrorCode
        /// The error code with which the channel should be cancelled, or
        /// NS_OK if the load should continue normally.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnClassifyComplete(int aErrorCode);
	}
	
	/// <summary>
    /// The URI classifier service checks a URI against lists of phishing
    /// and malware sites.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("596620cc-76e3-4133-9d90-360e59a794cf")]
	internal interface nsIURIClassifier
	{
		
		/// <summary>
        /// Classify a Principal using its URI.
        ///
        /// @param aPrincipal
        /// The principal that should be checked by the URI classifier.
        /// @param aTrackingProtectionEnabled
        /// Whether or not to classify the given URI against tracking
        /// protection lists
        ///
        /// @param aCallback
        /// The URI classifier will call this callback when the URI has been
        /// classified.
        ///
        /// @return <code>false</code> if classification is not necessary.  The
        /// callback will not be called.
        /// <code>true</code> if classification will be performed.  The
        /// callback will be called.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Classify([MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, [MarshalAs(UnmanagedType.U1)] bool aTrackingProtectionEnabled, [MarshalAs(UnmanagedType.Interface)] nsIURIClassifierCallback aCallback);
		
		/// <summary>
        /// Synchronously classify a URI with a comma-separated string
        /// containing the given tables. This does not make network requests.
        /// The result is a comma-separated string of tables that match.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ClassifyLocalWithTables([MarshalAs(UnmanagedType.Interface)] nsIURI aURI, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aTables, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
	}
}
