using Singleton;

TableServers tableServers1 = TableServers.GetTableServers();
TableServers tableServers2 = TableServers.GetTableServers();

for (int i = 0; i < 8; i++)
{
    Console.WriteLine("The next server: " + tableServers1.GetNextServer());
    Console.WriteLine("The next server: " + tableServers2.GetNextServer());
}

Console.ReadLine();