
using System;

namespace Adapter
{
    class Program
    {
        public class ASPNETTeam : ITeam
        {
            public string ExecuteProject()
            {
                return "ASPnet team";
            }
        }
        public class SliverlightTeam
        {
            public string SliverlightTeamMembers()
            {
                return "SliverlightTeam";
            }
        }
        public class AdapterClass : SliverlightTeam, ITeam
        {
            public string ExecuteProject()
            {
                return SliverlightTeamMembers();
            }
        }
        static void Main(string[] args)
        {
            ITeam team = new ASPNETTeam();
            Console.WriteLine(team.ExecuteProject());
            Console.ReadLine();
        }
    }
}
