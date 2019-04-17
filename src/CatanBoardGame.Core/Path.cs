namespace CatanBoardGame.Core
{
    public class Path
    {
        public Team Team;

        public Path(Team team)
        {
            Team = team;
        }

        public bool IfFromTeam(Team team) =>
            team == Team;
    }
}