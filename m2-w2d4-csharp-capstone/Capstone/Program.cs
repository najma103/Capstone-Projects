using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            // getting connection string from the App.Config file
            string connectionString = ConfigurationManager.ConnectionStrings["CapstoneDatabase"].ConnectionString;
            ProjectCLI CLI = new ProjectCLI(connectionString);
            CLI.RunCLI();
            
        }
    }
}
