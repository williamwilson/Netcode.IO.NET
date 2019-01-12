using System;
using System.Diagnostics;
using Xunit;
using TestDefinitions = NetcodeIO.Core.Tests.Tests;

namespace Netcode.IO.Core.Tests
{
    public class UnitTest1
	{
		[Trait("Category", "Misc"), Fact]
		public void TestSequence()
		{
			TestDefinitions.TestSequence();
		}

		[Trait("Category", "Misc"), Fact]
		public void TestConnectToken()
		{
			TestDefinitions.TestConnectToken();
		}

		[Trait("Category", "Misc"), Fact]
		public void TestChallengeToken()
		{
			TestDefinitions.TestChallengeToken();
		}

		[Trait("Category", "Misc"), Fact]
		public void TestEncryptionManager()
		{
			TestDefinitions.TestEncryptionManager();
		}

		[Trait("Category", "Misc"), Fact]
		public void TestReplayProtection()
		{
			TestDefinitions.TestReplayProtection();
		}

		[Trait("Category", "Packets"), Fact]
		public void TestConnectionRequestPacket()
		{
			TestDefinitions.TestConnectionRequestPacket();
		}

		[Trait("Category", "Packets"), Fact]
		public void TestConnectionDeniedPacket()
		{
			TestDefinitions.TestConnectionDeniedPacket();
		}

		[Trait("Category", "Packets"), Fact]
		public void TestConnectionKeepAlivePacket()
		{
			TestDefinitions.TestConnectionKeepAlivePacket();
		}

		[Trait("Category", "Packets"), Fact]
		public void TestConnectionChallengePacket()
		{
			TestDefinitions.TestConnectionChallengePacket();
		}

		[Trait("Category", "Packets"), Fact]
		public void TestConnectionPayloadPacket()
		{
			TestDefinitions.TestConnectionPayloadPacket();
		}

		[Trait("Category", "Packets"), Fact]
		public void TestConnectionDisconnectPacket()
		{
			TestDefinitions.TestConnectionDisconnectPacket();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestClientServerConnection()
		{
			TestDefinitions.TestClientServerConnection();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestClientServerKeepAlive()
		{
			TestDefinitions.TestClientServerKeepAlive();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestClientServerMultipleClients()
		{
			TestDefinitions.TestClientServerMultipleClients();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestClientServerMultipleServers()
		{
			TestDefinitions.TestClientServerMultipleServers();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestConnectTokenExpired()
		{
			TestDefinitions.TestConnectTokenExpired();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestInvalidConnectToken()
		{
			TestDefinitions.TestClientInvalidConnectToken();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestConnectionTimeout()
		{
			TestDefinitions.TestConnectionTimeout();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestChallengeResponseTimeout()
		{
			TestDefinitions.TestChallengeResponseTimeout();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestConnectionRequestTimeout()
		{
			TestDefinitions.TestConnectionRequestTimeout();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestConnectionDenied()
		{
			TestDefinitions.TestConnectionDenied();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestClientSideDisconnect()
		{
			TestDefinitions.TestClientSideDisconnect();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestServerSideDisconnect()
		{
			TestDefinitions.TestServerSideDisconnect();
		}

		[Trait("Category", "Connection"), Fact]
		public void TestClientReconnect()
		{
			TestDefinitions.TestReconnect();
		}

		[Trait("Category", "SoakConnection"), Fact]
		public void SoakConnectionTests()
		{
			System.Diagnostics.Debugger.Launch();
			const int soakTime = 1000 * 60 * 10;

			Stopwatch sw = new Stopwatch();
			sw.Start();

			int iterations = 0;
			while (sw.ElapsedMilliseconds < soakTime)
			{
				Console.WriteLine("=== RUN " + iterations + " ===");

				TestDefinitions.TestClientServerConnection();
				TestDefinitions.TestClientServerKeepAlive();
				TestDefinitions.TestClientServerKeepAlive();
				TestDefinitions.TestClientServerMultipleClients();
				TestDefinitions.TestClientServerMultipleServers();
				TestDefinitions.TestConnectTokenExpired();
				TestDefinitions.TestClientInvalidConnectToken();
				TestDefinitions.TestConnectionTimeout();
				TestDefinitions.TestChallengeResponseTimeout();
				TestDefinitions.TestConnectionRequestTimeout();
				TestDefinitions.TestConnectionDenied();
				TestDefinitions.TestClientSideDisconnect();
				TestDefinitions.TestServerSideDisconnect();
				TestDefinitions.TestReconnect();

				iterations++;
			}

			sw.Stop();
		}

		[Trait("Category", "SoakConnection"), Fact]
		public void SoakClientServerRandomConnection()
		{
			TestDefinitions.SoakTestClientServerConnection(30);
		}
	}
}
