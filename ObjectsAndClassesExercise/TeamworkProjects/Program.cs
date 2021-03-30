using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = input[0];
                string name = input[1];

                bool isTeamExist = teams.Select(x => x.Name).Contains(name);
                bool isCreatorExist = teams.Any(x => x.User == creator);

                if (!isTeamExist && !isCreatorExist)
                {
                    Team team = new Team(creator, name);
                    teams.Add(team);
                    Console.WriteLine($"Team {name} has been created by {creator}!");
                }
                else if (isCreatorExist)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else if (isTeamExist)
                {
                    Console.WriteLine($"Team {name} was already created!");
                }

            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] commands = command.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string participant = commands[0];
                string teamName = commands[1];

                bool isTeamExist = teams.Any(x => x.Name == teamName);
                bool isInAnotherTeam = teams.Any(x => x.Members.Contains(participant));
                bool isCreator = teams.Any(x => x.User == participant);

                if (isTeamExist && !isInAnotherTeam && !isCreator)
                {
                    int teamIndex = teams.FindIndex(x => x.Name == teamName);

                    teams[teamIndex].Members.Add(participant);
                }
                else if (!isTeamExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isInAnotherTeam || isCreator)
                {
                    Console.WriteLine($"Member {participant} cannot join team {teamName}!");
                }
            }

            List<Team> validTeams = teams.Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count).
                ThenBy(x => x.Name)
                .ToList();

            List<Team> invalidTeams = teams.Where(x => x.Members.Count == 0)
                .OrderBy(x => x.Name)
                .ToList();

            foreach (Team team in validTeams)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.User}");
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in invalidTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public string User { get; set; }

        public string Name { get; set; }

        public List<string> Members { get; set; }

        public Team(string user, string name)
        {
            this.User = user;
            this.Name = name;
            Members = new List<string>();
        }

    }
}
