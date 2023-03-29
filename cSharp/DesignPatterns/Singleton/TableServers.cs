using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class TableServers
	{
		private static TableServers? _instance;
		private List<string> servers = new List<string>();
		private int nextServer = 0;

		public static TableServers GetTableServers()
		{
			if (_instance is null)
				_instance = new TableServers();
			return _instance;
		}
		private TableServers() // setting to private won't allow new instane
		{
			servers.Add("Tim");
			servers.Add("Sue");
			servers.Add("Mary");
			servers.Add("Bob");
			servers.Add("Timmy");
			servers.Add("Sassy");
			servers.Add("Maryo");
			servers.Add("Bobby");
		}

		public string GetNextServer()
		{
			nextServer++;

			if (nextServer >= servers.Count) 
				nextServer = 0;

			return servers[nextServer];
		}
	}
}
