using System.Collections.Generic;

namespace CatanBoardGame.Core
{
    public class Vertexs
    {
        public Vertex Vertex1 { get; set; }
        public Vertex Vertex2 { get; set; }
        public Vertex Vertex3 { get; set; }
        public Vertex Vertex4 { get; set; }
        public Vertex Vertex5 { get; set; }
        public Vertex Vertex6 { get; set; }

        public Vertexs(List<Limit> limits)
        {
            Vertex1 = new Vertex(limits[5], limits[0], 1);
            Vertex2 = new Vertex(limits[0], limits[1], 2);
            Vertex3 = new Vertex(limits[1], limits[2], 3);
            Vertex4 = new Vertex(limits[2], limits[3], 4);
            Vertex5 = new Vertex(limits[3], limits[4], 5);
            Vertex6 = new Vertex(limits[4], limits[5], 6);
        }
    }
}