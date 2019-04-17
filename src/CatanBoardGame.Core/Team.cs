namespace CatanBoardGame.Core
{
    public class Team
    {
        public TeamColorEnum TeamColor { get; set; }
        public string Name { get; set; }

        public Team(TeamColorEnum teamColor, string name)
        {
            TeamColor = teamColor;
            Name = name;
        }

    }
}