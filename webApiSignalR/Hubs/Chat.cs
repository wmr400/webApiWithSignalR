﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace webApiSignalR.Hubs
{
	public class Chat : Hub
	{
		public Task Send(string message)
		{
			return Clients.All.InvokeAsync("Send", message);
		}
	}
}
