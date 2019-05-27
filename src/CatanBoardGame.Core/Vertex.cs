using System;

namespace CatanBoardGame.Core
{
    public class Vertex
    {
        public Vertex(Limit leftLimit, Limit rightLimit)
        {
            LeftLimit = leftLimit;
            RightLimit = rightLimit;
        }

        public Limit LeftLimit { get; set; }
        public Limit RightLimit { get; set; }
        public Building Building { get; private set; }

        public DomainResponse AddBuilding(Building building)
        {
            if (!CanAddBuilding(building))
                return DomainResponse.Error();

            Building = building;
            return DomainResponse.Ok();
        }

        public bool HasBuilding() =>
            Building != null;

        private bool CanAddBuilding(Building building) =>
            !((LeftLimit != null && LeftLimit.Path != null && LeftLimit.Path.IfFromTeam(building.Team))
             &&
             (RightLimit != null && RightLimit.Path != null && RightLimit.Path.IfFromTeam(building.Team)));

    }

}