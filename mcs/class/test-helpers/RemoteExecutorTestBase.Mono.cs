// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.IO;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Base class used for all tests that need to spawn a remote process.</summary>
	public abstract partial class RemoteExecutorTestBase : FileCleanupTestBase
	{
		// protected static readonly string HostRunnerName = "mono";
		protected static readonly string HostRunner = Process.GetCurrentProcess().MainModule.FileName;

		// Should be ../lib/$(PROFILE)/RemoteExecutorConsoleApp.exe
		static readonly string ExtraParameter = "--debug " + Environment.GetEnvironmentVariable ("REMOTE_EXECUTOR");
	}
}
