using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleTestGroup
{
	public class PowerShellClass
	{
		PowerShell PSI = PowerShell.Create();
		public void RunPS()
		{
			WriteLine("Type input to run into powershell");
			string? input = ReadLine();
			if (string.IsNullOrEmpty(input))
				input = "powershell -ExecutionPolicy Bypass -Command Get-Help \".\\test.ps1\"";
			PSI.AddScript(input);
			Collection<PSObject> pSObjects = PSI.Invoke();
			

			if (PSI.Streams.Error.Count > 0)
			{
				foreach (ErrorRecord errorRecord in PSI.Streams.Error)
					Error.WriteLine("Error: {0}", errorRecord.ToString());
			}
			else
			{
                Console.WriteLine("OutPut:\n\n");
                foreach (PSObject result in pSObjects)
					WriteLine("{0}", result.ToString());
			}



		}
	}
}
