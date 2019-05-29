namespace CatanBoardGame.Core
{
    public class Ground
    {
        private readonly string _name;

        public LimitManager Limits = new LimitManager();
        public Ground(string name)
        {
            _name = name;
        }
        public Ground AddRight(Ground ground)
        {
            Limits.AddRight(ground);
            return this;
        }
        public Ground AddLeftDown(Ground ground)
        {
            Limits.AddLeftDown(ground);
            return this;
        }
        public Ground AddRightDown(Ground ground)
        {
            Limits.AddRightDown(ground);
            return this;
        }

        public DomainResponse AddPath(Path path, Limit limit)
        {
            var enableToAddPaht = Limits.Contain(limit) && !limit.HasPath();
            if (!enableToAddPaht)
                return DomainResponse.Error();

            limit.AddPath(path);
            return DomainResponse.Ok();
        }
        public DomainResponse AddBuilding(Vertex vertex, Building building)
        {
            if (vertex.HasBuilding())
                return DomainResponse.Error();

            vertex.AddBuilding(building);
            return DomainResponse.Ok();
        }
    }
}