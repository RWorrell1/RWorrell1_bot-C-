using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace RWorrell1_Bot
{
	class Program
	{
		static void Main(string[] args)
		{
			IrcClient IrcClient = new IrcClient("irc.chat.twitch.tv", 6667, "rworrell1_bot", "oauth:");
			IrcClient.joinRoom("rworrell1");

			while(true)
			{
				string message = IrcClient.readMessage();
				if (message.Contains("PING :tmi.twitch.tv"))
				{
					IrcClient.sendIrcMessage("PONG :tmi.twitch.tv");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent Twitch A Pong");
					Console.ResetColor();
				}
				#region Commands
				if (message.Contains("!donate"))
				{
					IrcClient.sendChatMessage("You Can Donate here http://www.streamtip.com/t/rworrell1 Min: $3");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent The Command Donate");
					Console.ResetColor();
				}
				if (message.Contains("!crew"))
				{
					IrcClient.sendChatMessage("Join my crew at socialclub.rockstargames.com/crew/rworrell1");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent The Command Crew");
					Console.ResetColor();
				}
				if (message.Contains("!email"))
				{
					IrcClient.sendChatMessage("Email Me At rworrell1gaming@gmail.com");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent The Command Email");
					Console.ResetColor();
				}
				if (message.Contains("!psn"))
				{
					IrcClient.sendChatMessage("Add me on PSN at ryandude21");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent The Command PSN");
					Console.ResetColor();
				}
				if (message.Contains("!site"))
				{
					IrcClient.sendChatMessage("My site is rworrell1.weebly.com");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent The Command Site");
					Console.ResetColor();
				}
				if (message.Contains("!steam"))
				{
					IrcClient.sendChatMessage("Add me on steam at NightTimeKillers");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent The Command Steam");
					Console.ResetColor();
				}
				if (message.Contains("!twitter"))
				{
					IrcClient.sendChatMessage("Follow me on Twitter at @rworrell1gaming");
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine ("Sent The Command Twitter");
					Console.ResetColor();
				}
				#endregion
			}
		}
	}
}

