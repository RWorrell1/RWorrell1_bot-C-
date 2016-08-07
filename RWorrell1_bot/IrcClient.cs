using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace RWorrell1_Bot
{
	class IrcClient
	{
		private string userName;
		private string channel;

		private TcpClient tcpClient;
		private StreamReader readerStream;
		private StreamWriter writerStream;

		#region Connect to IRC
		public IrcClient(string ip, int port, string userName, string password)
		{
			this.userName = userName;

			tcpClient = new TcpClient(ip, port);
			readerStream = new StreamReader(tcpClient.GetStream());
			writerStream = new StreamWriter(tcpClient.GetStream());

			writerStream.WriteLine("PASS " + password);
			writerStream.WriteLine("NICK " + userName);
			writerStream.WriteLine("USER " + userName + " 8 * :" + userName);
			writerStream.WriteLine("CAP REQ :twitch.tv/tags");
			writerStream.WriteLine("CAP REQ :twitch.tv/commands");
			writerStream.WriteLine("CAP REQ :twitch.tv/membership");
			writerStream.Flush();
		}
		#endregion
		#region Joins Channel
		public void joinRoom(string channel)
		{
			this.channel = channel;
			writerStream.WriteLine("JOIN #" + channel);
			writerStream.Flush();
		}
		#endregion
		#region Sends IRC server msg
		public void sendIrcMessage(string message)
		{
			writerStream.WriteLine(message);
			writerStream.Flush();
		}
		#endregion
		#region Sends The Channel a msg
		public void sendChatMessage(string message)
		{
			sendIrcMessage(":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + channel + " :" + message);
		}
		#endregion
		#region ReadMessage
		public string readMessage()
		{
			string message = readerStream.ReadLine();
			Console.WriteLine (message);
			return message;
		}
		#endregion

		public string getUser(){
			string User = readerStream.ReadLine ();
			User.Split ([:], 1);
			return getUser;
		}

	}
}
