namespace CatanBoardGame.Core
{
    public  class Limi
    public class Ground
    {
        private readonly string _name;

        public Vertexs Vertexs { get; set; }

        public LimitManager Limits = new LimitManager();
        public Ground(string name)
        {
            _name = name;
            Vertexs = new Vertexs(Limits.Limits);
        }
        public Ground AddRight(Ground ground)
        {
            Limits.MiddleRight = ground.Limits.MiddleLeft;
            Vertexs.Vertex3 = ground.Vertexs.Vertex1;
            Vertexs.Vertex4 = ground.Vertexs.Vertex6;
            return this;
        }
        public Ground AddLeftDown(Ground ground)
        {
            Limits.LeftDown = ground.Limits.TopRight;
            Vertexs.Vertex5 = ground.Vertexs.Vertex3;
            Vertexs.Vertex6 = ground.Vertexs.Vertex2;
            return this;
        }
        public Ground AddRightDown(Ground ground)
        {
            Limits.DownRight = ground.Limits.TopLeft;
            Vertexs.Vertex4 = ground.Vertexs.Vertex2;
            Vertexs.Vertex5 = ground.Vertexs.Vertex1;
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