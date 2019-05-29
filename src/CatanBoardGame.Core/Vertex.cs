using System;

namespace CatanBoardGame.Core
{
    public class Vertex
    {
        private Limit _leftLimit { get; set; }
        private Limit _rightLimit { get; set; }
        public Building Building { get; private set; }
        public int Id { get; }

        public Guid IDUnique { get; set; }
        public Vertex(Limit leftLimit, Limit rightLimit)
        {
            _leftLimit = leftLimit;
            _rightLimit = rightLimit;
        }
        public Vertex(Limit leftLimit, Limit rightLimit, int id)
        {
            _rightLimit = leftLimit;
            _rightLimit = rightLimit;
            Id = id;
            IDUnique = Guid.NewGuid();
        }

        public DomainResponse AddBuilding(Building building)
        {
            if (!CanAddBuilding(building) || HasBuilding())
                return DomainResponse.Error();

            Building = building;
            return DomainResponse.Ok();
        }

        public bool HasBuilding() =>
            Building != null;

        private bool CanAddBuilding(Building building) =>
            !((_leftLimit != null && _leftLimit.Path != null && _leftLimit.Path.IfFromTeam(building.Team))
             &&
             (_rightLimit != null && _rightLimit.Path != null && _rightLimit.Path.IfFromTeam(building.Team)));

    }

}