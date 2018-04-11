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
// Generated by IDLImporter from file nsIMobileConnectionInfo.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this file,
    /// You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d5208e13-42dc-4dce-9427-2572fa252751")]
	internal interface nsIMobileConnectionInfo
	{
		
		/// <summary>
        /// State of the connection.
        ///
        /// Possible values: 'notSearching', 'searching', 'denied', 'registered' or
        /// null (unknown).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetStateAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aState);
		
		/// <summary>
        /// Indicates whether the connection is ready.
        ///
        /// Note: The meaning of "connection ready" for data and voice are different.
        /// - Data: the "default" data connection is established or not.
        /// - Voice: voice is registered to network or not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetConnectedAttribute();
		
		/// <summary>
        /// Indicates whether only emergency calls are possible.
        ///
        /// This flag is only relevant to voice connections and when 'connected' is
        /// false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetEmergencyCallsOnlyAttribute();
		
		/// <summary>
        /// Indicates whether the connection is going through a foreign operator
        /// (roaming) or not.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetRoamingAttribute();
		
		/// <summary>
        /// Network operator information.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMobileNetworkInfo GetNetworkAttribute();
		
		/// <summary>
        /// Type of connection.
        ///
        /// Possible values: 'gsm', 'gprs', 'edge', 'umts', 'hsdpa', 'hsupa', 'hspa',
        /// 'hspa+', 'is95a', 'is95b', '1xrtt', 'evdo0', 'evdoa',
        /// 'evdob', 'ehrpd', 'lte' or null (unknown).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aType);
		
		/// <summary>
        /// Signal strength in dBm, or null if no service is available.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetSignalStrengthAttribute();
		
		/// <summary>
        /// Signal strength, represented linearly as a number between 0 (weakest
        /// signal) and 100 (full signal).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetRelSignalStrengthAttribute();
		
		/// <summary>
        /// Cell location information.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIMobileCellInfo GetCellAttribute();
	}
}