using System.Collections.Generic;

namespace CatanBoardGame.UnitTests
{
    public class Vertexs
    {
        private readonly List<Limit> _limits;
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public Vertex Vertex3 { get; set; }
        public Vertex Vertex4 { get; set; }
        public Vertex Vertex5 { get; set; }
        public Vertex Vertex6 { get; set; }

        public Vertexs(List<Limit> limits)
        {
            _limits = limits;
            Vertex1 = new Vertex(_limits[5], _limits[0]);
            Vertex2 = new Vertex(_limits[0], _limits[1]);
            Vertex3 = new Vertex(_limits[1], _limits[2]);
            Vertex4 = new Vertex(_limits[2], _limits[3]);
            Vertex5 = new Vertex(_limits[3], _limits[4]);
            Vertex6 = new Vertex(_limits[4], _limits[5]);
        }
    }
}