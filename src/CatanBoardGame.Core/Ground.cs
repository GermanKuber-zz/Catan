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

        public void AddPath(Path path, Limit limit)
        {
            if (Limits.Contain(limit) && !limit.HasPath())
                limit.AddPath(path);
        }
        public void AddBuilding(Vertex vertex, Building building)
        {
            if (!vertex.HasBuilding())
                vertex.AddBuilding(building);
        }
    }
}