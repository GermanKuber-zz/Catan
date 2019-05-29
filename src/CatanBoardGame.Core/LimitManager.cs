using System.Collections.Generic;
using System.Linq;

namespace CatanBoardGame.Core
{
    public class LimitManager
    {
        public Vertexs Vertexs { get; set; }

        public List<Limit> Limits;
        public Limit TopLeft
        {
            get => Limits[0];
            set => Limits[0] = value;
        }
        public Limit TopRight
        {
            get => Limits[1];
            set => Limits[1] = value;
        }
        public Limit MiddleLeft
        {
            get => Limits[5];
            set => Limits[5] = value;
        }
        public Limit MiddleRight
        {
            get => Limits[2];
            set => Limits[2] = value;
        }
        public Limit LeftDown
        {
            get => Limits[4];
            set => Limits[4] = value;
        }
        public Limit DownRight
        {
            get => Limits[3];
            set => Limits[3] = value;
        }

        public LimitManager()
        {
            Limits = Enumerable.Range(0, 6)
                .Select(x => new Limit())
                .ToList();
        }

        public void AddRight(Ground ground)
        {
            MiddleRight = ground.Limits.MiddleLeft;
            Vertexs.Vertex3 = Vertexs.Vertex1;
            Vertexs.Vertex4 = Vertexs.Vertex6;
        }
        public void AddLeftDown(Ground ground)
        {
            LeftDown = ground.Limits.TopRight;
            Vertexs.Vertex5 = Vertexs.Vertex3;
            Vertexs.Vertex6 = Vertexs.Vertex2;
        }
        public void AddRightDown(Ground ground)
        {
            DownRight = ground.Limits.TopLeft;
            Vertexs.Vertex4 = Vertexs.Vertex2;
            Vertexs.Vertex5 = Vertexs.Vertex1;
        }

        public bool Contain(Limit limit) =>
            Limits.Any(limitToCompare => limitToCompare == limit);
    }
}