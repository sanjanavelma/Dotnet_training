using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Team : IComparable<Team>
{
    public string Name { get; set; }
    public int Points { get; set; }
    
    public int CompareTo(Team other)
    {
        // TODO: Compare by points descending, then by name
        int result = other.Points.CompareTo(this.Points);
        if(result == 0)
        {
            result = this.Name.CompareTo(other.name);
        }
        return result;
    }
}public class Match
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }

    public int PrevPoints1 { get; set; }
    public int PrevPoints2 { get; set; }

    public Match(Team t1, Team t2)
    {
        Team1 = t1;
        Team2 = t2;
    }

    // Clone match state for undo
    public Match Clone()
    {
        return new Match(Team1, Team2)
        {
            PrevPoints1 = Team1.Points,
            PrevPoints2 = Team2.Points
        };
    }
}

public class Tournament
{
    private SortedList<int, Team> _rankings = new SortedList<int, Team>();
    private LinkedList<Match> _schedule = new LinkedList<Match>();
    private Stack<Match> _undoStack = new Stack<Match>();
    
    // Add match to schedule
    public void ScheduleMatch(Match match)
    {
        // TODO: Add to linked list
        _schedule.AddLast(match);
        if (!_teams.Contains(match.Team1)) _teams.Add(match.Team1);
        if (!_teams.Contains(match.Team2)) _teams.Add(match.Team2);
    }
    
    // Record match result and update rankings
    public void RecordMatchResult(Match match, int team1Score, int team2Score)
    {
        _undoStack.Push(match.Clone());
        // TODO: Update team points and re-sort rankings
        if (team1Score > team2Score)
            match.Team1.Points += 3;
        else if (team2Score > team1Score)
            match.Team2.Points += 3;
        else
        {
            match.Team1.Points += 1;
            match.Team2.Points += 1;
        }
    }
    
    // Undo last match
    public void UndoLastMatch()
    {
        // TODO: Use stack to revert last match
        if (_undoStack.Count == 0)
            return;

        Match last = _undoStack.Pop();

        last.Team1.Points = last.PrevPoints1;
        last.Team2.Points = last.PrevPoints2;
    }
    
    // Get ranking position using binary search
   public List<Team> GetRankings()
    {
        return _teams.OrderBy(t => t).ToList();
    }

    // Binary search ranking
    public int GetTeamRanking(Team team)
    {
        var rankings = GetRankings();
        return rankings.BinarySearch(team);
    }
}