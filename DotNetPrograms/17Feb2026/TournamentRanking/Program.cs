using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Tournament tournament = new Tournament();
        Team teamA = new Team { Name = "Team Alpha", Points = 0 };
        Team teamB = new Team { Name = "Team Beta", Points = 0 };

        tournament.ScheduleMatch(new Match(teamA, teamB));
        tournament.RecordMatchResult(match, 3, 1); // Team A wins

        var rankings = tournament.GetRankings();
        Console.WriteLine(rankings[0].Name); // Should output: Team Alpha

        tournament.UndoLastMatch();
        Console.WriteLine(teamA.Points); 
    }
}