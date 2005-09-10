//
// System.Web.Hosting.ISAPIRuntime.cs
//
// Author:
//   Bob Smith <bob@thestuff.net>
//   Gonzalo Paniagua (gonzalo@ximian.com)
//
// (C) Bob Smith
// (c) 2002 Ximian, Inc. (http://www.ximian.com)
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System.Security.Permissions;

namespace System.Web.Hosting {

#if NET_2_0
        public sealed class ISAPIRuntime : MarshalByRefObject, IISAPIRuntime, IRegisteredObject {
#else
	// CAS - no InheritanceDemand here as the class is sealed
	[AspNetHostingPermission (SecurityAction.LinkDemand, Level = AspNetHostingPermissionLevel.Minimal)]
        public sealed class ISAPIRuntime : IISAPIRuntime {
#endif

#if NET_2_0
		[AspNetHostingPermission (SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
#endif
		[SecurityPermission (SecurityAction.Demand, UnmanagedCode = true)]
                public ISAPIRuntime ()
		{
		}
		
		[MonoTODO]
                public void DoGCCollect ()
		{
			throw new NotImplementedException ();
		}
		
		[MonoTODO]
                public int ProcessRequest (IntPtr ecb, int iWRType)
		{
			throw new NotImplementedException ();
		}
		
		[MonoTODO]
                public void StartProcessing ()
		{
			throw new NotImplementedException ();
		}
		
		[MonoTODO]
#if NET_2_0
		[SecurityPermission (SecurityAction.Demand, UnmanagedCode = true)]
#endif
                public void StopProcessing ()
		{
			throw new NotImplementedException ();
		}

#if NET_2_0
		[MonoTODO]
		public override object InitializeLifetimeService ()
		{
			throw new NotImplementedException ();
		}

		[MonoTODO]
		void IRegisteredObject.Stop (bool immediate)
		{
			throw new NotImplementedException ();
		}
#endif
        }
}
