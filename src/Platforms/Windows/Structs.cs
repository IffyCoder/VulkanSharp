/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;
using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
	unsafe public partial class Win32SurfaceCreateInfoKhr : MarshalledObject
	{
		public UInt32 Flags {
			get { return m->Flags; }
			set { m->Flags = value; }
		}

		public IntPtr Hinstance {
			get { return m->Hinstance; }
			set { m->Hinstance = value; }
		}

		public IntPtr Hwnd {
			get { return m->Hwnd; }
			set { m->Hwnd = value; }
		}
		internal Windows.Interop.Win32SurfaceCreateInfoKhr* m {

			get {
				return (Windows.Interop.Win32SurfaceCreateInfoKhr*)native.Handle;
			}
		}

		public Win32SurfaceCreateInfoKhr ()
		{
			native = Vulkan.Interop.Structure.Allocate (typeof (Windows.Interop.Win32SurfaceCreateInfoKhr));
			Initialize ();
		}

		internal Win32SurfaceCreateInfoKhr (NativePointer pointer)
		{
			native = pointer;
			Initialize ();
		}


		internal void Initialize ()
		{
			m->SType = StructureType.Win32SurfaceCreateInfoKhr;
		}

	}

	unsafe public partial class ImportMemoryWin32HandleInfoNv : MarshalledObject
	{
		public ExternalMemoryHandleTypeFlagsNv HandleType {
			get { return m->HandleType; }
			set { m->HandleType = value; }
		}

		public IntPtr Handle {
			get { return m->Handle; }
			set { m->Handle = value; }
		}
		internal Windows.Interop.ImportMemoryWin32HandleInfoNv* m {

			get {
				return (Windows.Interop.ImportMemoryWin32HandleInfoNv*)native.Handle;
			}
		}

		public ImportMemoryWin32HandleInfoNv ()
		{
			native = Vulkan.Interop.Structure.Allocate (typeof (Windows.Interop.ImportMemoryWin32HandleInfoNv));
			Initialize ();
		}

		internal ImportMemoryWin32HandleInfoNv (NativePointer pointer)
		{
			native = pointer;
			Initialize ();
		}


		internal void Initialize ()
		{
			m->SType = StructureType.ImportMemoryWin32HandleInfoNv;
		}

	}

	unsafe public partial class ExportMemoryWin32HandleInfoNv : MarshalledObject
	{
		public SecurityAttributes Attributes {
			get { return (SecurityAttributes)Vulkan.Interop.Structure.MarshalPointerToObject (m->Attributes, typeof (SecurityAttributes)); }
			set { m->Attributes = Vulkan.Interop.Structure.MarshalObjectToPointer (m->Attributes, value); }
		}

		public UInt32 DwAccess {
			get { return m->DwAccess; }
			set { m->DwAccess = value; }
		}
		internal Windows.Interop.ExportMemoryWin32HandleInfoNv* m {

			get {
				return (Windows.Interop.ExportMemoryWin32HandleInfoNv*)native.Handle;
			}
		}

		public ExportMemoryWin32HandleInfoNv ()
		{
			native = Vulkan.Interop.Structure.Allocate (typeof (Windows.Interop.ExportMemoryWin32HandleInfoNv));
			Initialize ();
		}

		internal ExportMemoryWin32HandleInfoNv (NativePointer pointer)
		{
			native = pointer;
			Initialize ();
		}


		internal void Initialize ()
		{
			m->SType = StructureType.ExportMemoryWin32HandleInfoNv;
		}

	}

	unsafe public partial class Win32KeyedMutexAcquireReleaseInfoNv : MarshalledObject
	{
		public UInt32 AcquireCount {
			get { return m->AcquireCount; }
			set { m->AcquireCount = value; }
		}

		NativeReference refAcquireSyncs;
		public DeviceMemory[] AcquireSyncs {
			get {
				if (m->AcquireCount == 0)
					return null;
				var values = new DeviceMemory [m->AcquireCount];
				unsafe
				{
					UInt64* ptr = (UInt64*)m->AcquireSyncs;
					for (int i = 0; i < values.Length; i++) {
						values [i] = new DeviceMemory ();
						values [i].m = ptr [i];
					}
				}
				return values;
			}

			set {
				if (value == null) {
					m->AcquireCount = 0;
					m->AcquireSyncs = IntPtr.Zero;
					return;
				}
				m->AcquireCount = (uint)value.Length;
				refAcquireSyncs = new NativeReference ((int)(sizeof(UInt64)*value.Length));
				m->AcquireSyncs = refAcquireSyncs.Handle;
				unsafe
				{
					UInt64* ptr = (UInt64*)m->AcquireSyncs;
					for (int i = 0; i < value.Length; i++)
						ptr [i] = value [i].m;
				}
			}
		}

		NativeReference refAcquireKeys;
		public UInt64[] AcquireKeys {
			get {
				if (m->AcquireCount == 0)
					return null;
				var values = new UInt64 [m->AcquireCount];
				unsafe
				{
					UInt64* ptr = (UInt64*)m->AcquireKeys;
					for (int i = 0; i < values.Length; i++) 
						values [i] = ptr [i];
				}
				return values;
			}

			set {
				if (value == null) {
					m->AcquireCount = 0;
					m->AcquireKeys = IntPtr.Zero;
					return;
				}
				m->AcquireCount = (uint)value.Length;
				refAcquireKeys = new NativeReference ((int)(sizeof(UInt64)*value.Length));
				m->AcquireKeys = refAcquireKeys.Handle;
				unsafe
				{
					UInt64* ptr = (UInt64*)m->AcquireKeys;
					for (int i = 0; i < value.Length; i++)
						ptr [i] = value [i];
				}
			}
		}

		NativeReference refAcquireTimeoutMilliseconds;
		public UInt32[] AcquireTimeoutMilliseconds {
			get {
				if (m->AcquireCount == 0)
					return null;
				var values = new UInt32 [m->AcquireCount];
				unsafe
				{
					UInt32* ptr = (UInt32*)m->AcquireTimeoutMilliseconds;
					for (int i = 0; i < values.Length; i++) 
						values [i] = ptr [i];
				}
				return values;
			}

			set {
				if (value == null) {
					m->AcquireCount = 0;
					m->AcquireTimeoutMilliseconds = IntPtr.Zero;
					return;
				}
				m->AcquireCount = (uint)value.Length;
				refAcquireTimeoutMilliseconds = new NativeReference ((int)(sizeof(UInt32)*value.Length));
				m->AcquireTimeoutMilliseconds = refAcquireTimeoutMilliseconds.Handle;
				unsafe
				{
					UInt32* ptr = (UInt32*)m->AcquireTimeoutMilliseconds;
					for (int i = 0; i < value.Length; i++)
						ptr [i] = value [i];
				}
			}
		}

		public UInt32 ReleaseCount {
			get { return m->ReleaseCount; }
			set { m->ReleaseCount = value; }
		}

		NativeReference refReleaseSyncs;
		public DeviceMemory[] ReleaseSyncs {
			get {
				if (m->ReleaseCount == 0)
					return null;
				var values = new DeviceMemory [m->ReleaseCount];
				unsafe
				{
					UInt64* ptr = (UInt64*)m->ReleaseSyncs;
					for (int i = 0; i < values.Length; i++) {
						values [i] = new DeviceMemory ();
						values [i].m = ptr [i];
					}
				}
				return values;
			}

			set {
				if (value == null) {
					m->ReleaseCount = 0;
					m->ReleaseSyncs = IntPtr.Zero;
					return;
				}
				m->ReleaseCount = (uint)value.Length;
				refReleaseSyncs = new NativeReference ((int)(sizeof(UInt64)*value.Length));
				m->ReleaseSyncs = refReleaseSyncs.Handle;
				unsafe
				{
					UInt64* ptr = (UInt64*)m->ReleaseSyncs;
					for (int i = 0; i < value.Length; i++)
						ptr [i] = value [i].m;
				}
			}
		}

		NativeReference refReleaseKeys;
		public UInt64[] ReleaseKeys {
			get {
				if (m->ReleaseCount == 0)
					return null;
				var values = new UInt64 [m->ReleaseCount];
				unsafe
				{
					UInt64* ptr = (UInt64*)m->ReleaseKeys;
					for (int i = 0; i < values.Length; i++) 
						values [i] = ptr [i];
				}
				return values;
			}

			set {
				if (value == null) {
					m->ReleaseCount = 0;
					m->ReleaseKeys = IntPtr.Zero;
					return;
				}
				m->ReleaseCount = (uint)value.Length;
				refReleaseKeys = new NativeReference ((int)(sizeof(UInt64)*value.Length));
				m->ReleaseKeys = refReleaseKeys.Handle;
				unsafe
				{
					UInt64* ptr = (UInt64*)m->ReleaseKeys;
					for (int i = 0; i < value.Length; i++)
						ptr [i] = value [i];
				}
			}
		}
		internal Windows.Interop.Win32KeyedMutexAcquireReleaseInfoNv* m {

			get {
				return (Windows.Interop.Win32KeyedMutexAcquireReleaseInfoNv*)native.Handle;
			}
		}

		public Win32KeyedMutexAcquireReleaseInfoNv ()
		{
			native = Vulkan.Interop.Structure.Allocate (typeof (Windows.Interop.Win32KeyedMutexAcquireReleaseInfoNv));
			Initialize ();
		}

		internal Win32KeyedMutexAcquireReleaseInfoNv (NativePointer pointer)
		{
			native = pointer;
			Initialize ();
		}

		override public void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			refAcquireSyncs.Release ();
			refAcquireSyncs = NativeReference.Empty;
			refAcquireKeys.Release ();
			refAcquireKeys = NativeReference.Empty;
			refAcquireTimeoutMilliseconds.Release ();
			refAcquireTimeoutMilliseconds = NativeReference.Empty;
			refReleaseSyncs.Release ();
			refReleaseSyncs = NativeReference.Empty;
			refReleaseKeys.Release ();
			refReleaseKeys = NativeReference.Empty;
		}

		internal void Initialize ()
		{
			m->SType = StructureType.Win32KeyedMutexAcquireReleaseInfoNv;
		}

	}
}
