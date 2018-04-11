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
// Generated by IDLImporter from file nsIRadioInterfaceLayer.idl
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
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("3bc96351-53b0-47a1-a888-c74c64b60f25")]
	internal interface nsIRilSendWorkerMessageCallback
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandleResponse(ref Gecko.JsVal response);
	}
	
	/// <summary>nsIRadioInterface </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1a3ef88a-e4d1-11e4-8512-176220f2b32b")]
	internal interface nsIRadioInterface
	{
		
		/// <summary>
        /// PDP APIs
        ///
        /// @param networkType
        /// Mobile network type, that is, nsINetworkInterface.NETWORK_TYPE_MOBILE
        /// or one of the nsINetworkInterface.NETWORK_TYPE_MOBILE_* values.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetupDataCallByType(int networkType);
		
		/// <summary>Member DeactivateDataCallByType </summary>
		/// <param name='networkType'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void DeactivateDataCallByType(int networkType);
		
		/// <summary>Member GetDataCallStateByType </summary>
		/// <param name='networkType'> </param>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetDataCallStateByType(int networkType);
		
		/// <summary>Member UpdateRILNetworkInterface </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateRILNetworkInterface();
		
		/// <summary>Member SendWorkerMessage </summary>
		/// <param name='type'> </param>
		/// <param name='message'> </param>
		/// <param name='callback'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SendWorkerMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase type, ref Gecko.JsVal message, [MarshalAs(UnmanagedType.Interface)] nsIRilSendWorkerMessageCallback callback);
	}
	
	/// <summary>nsIRadioInterfaceLayer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("78b65e8c-68e7-4510-9a05-65bba12b283e")]
	internal interface nsIRadioInterfaceLayer
	{
		
		/// <summary>Member GetNumRadioInterfacesAttribute </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetNumRadioInterfacesAttribute();
		
		/// <summary>Member GetRadioInterface </summary>
		/// <param name='clientId'> </param>
		/// <returns>A nsIRadioInterface</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIRadioInterface GetRadioInterface(uint clientId);
		
		/// <summary>
        /// Select a proper client for dialing emergency call.
        ///
        /// @return clientId or -1 if none of the clients are avaialble.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetClientIdForEmergencyCall();
		
		/// <summary>Member SetMicrophoneMuted </summary>
		/// <param name='muted'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetMicrophoneMuted([MarshalAs(UnmanagedType.U1)] bool muted);
	}
}