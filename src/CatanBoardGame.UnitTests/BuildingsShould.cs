using FluentAssertions;
using Xunit;

namespace CatanBoardGame.UnitTests
{
    public class BuildingsShould : GroundShouldBase
    {
        [Fact]
        public void Vertex1_Share_Building()
        {
            _5.Limits.LeftDown.AddPath(new Core.Path(_teamRed));
            _5.Limits.MiddleLeft.AddPath(new Core.Path(_teamRed));
            _5.Limits.Vertexs.Vertex1.AddBuilding(new Core.Building(_teamRed));

            _5.Limits.Vertexs.Vertex1.Building.Should().Be(_4.Limits.Vertexs.Vertex3.Building);
            _5.Limits.Vertexs.Vertex1.Building.Should().Be(_1.Limits.Vertexs.Vertex5.Building);
        }

        [Fact]
        public void Vertex2_Share_Building()
        {
            _5.Limits.MiddleLeft.AddPath(new Core.Path(_teamRed));
            _5.Limits.TopLeft.AddPath(new Core.Path(_teamRed));
            _5.Limits.Vertexs.Vertex2.AddBuilding(new Core.Building(_teamRed));

            _5.Limits.Vertexs.Vertex2.Building.Should().Be(_1.Limits.Vertexs.Vertex4.Building);
            _5.Limits.Vertexs.Vertex2.Building.Should().Be(_2.Limits.Vertexs.Vertex6.Building);
        }
        [Fact]
        public void Vertex3_Share_Building()
        {
            _5.Limits.TopLeft.AddPath(new Core.Path(_teamRed));
            _5.Limits.TopRight.AddPath(new Core.Path(_teamRed));
            _5.Limits.Vertexs.Vertex3.AddBuilding(new Core.Building(_teamRed));

            _5.Limits.Vertexs.Vertex3.Building.Should().Be(_2.Limits.Vertexs.Vertex5.Building);
            _5.Limits.Vertexs.Vertex3.Building.Should().Be(_6.Limits.Vertexs.Vertex1.Building);
        }
        [Fact]
        public void Vertex4_Share_Building()
        {
            _5.Limits.TopRight.AddPath(new Core.Path(_teamRed));
            _5.Limits.MiddleRight.AddPath(new Core.Path(_teamRed));
            _5.Limits.Vertexs.Vertex4.AddBuilding(new Core.Building(_teamRed));

            _5.Limits.Vertexs.Vertex4.Building.Should().Be(_6.Limits.Vertexs.Vertex6.Building);
            _5.Limits.Vertexs.Vertex4.Building.Should().Be(_10.Limits.Vertexs.Vertex2.Building);
        }
        [Fact]
        public void Vertex5_Share_Building()
        {
            _5.Limits.MiddleRight.AddPath(new Core.Path(_teamRed));
            _5.Limits.RightDown.AddPath(new Core.Path(_teamRed));
            _5.Limits.Vertexs.Vertex5.AddBuilding(new Core.Building(_teamRed));

            _5.Limits.Vertexs.Vertex5.Building.Should().Be(_10.Limits.Vertexs.Vertex1.Building);
            _5.Limits.Vertexs.Vertex5.Building.Should().Be(_9.Limits.Vertexs.Vertex3.Building);
        }
        [Fact]
        public void Vertex6_Share_Building()
        {
            _5.Limits.RightDown.AddPath(new Core.Path(_teamRed));
            _5.Limits.LeftDown.AddPath(new Core.Path(_teamRed));
            _5.Limits.Vertexs.Vertex6.AddBuilding(new Core.Building(_teamRed));

            _5.Limits.Vertexs.Vertex6.Should().Be(_9.Limits.Vertexs.Vertex2);
            _5.Limits.Vertexs.Vertex6.Should().Be(_4.Limits.Vertexs.Vertex4);
        }

    }
}