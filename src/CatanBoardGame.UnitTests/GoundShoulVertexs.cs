using CatanBoardGame.Core;
using FluentAssertions;
using Xunit;

namespace CatanBoardGame.UnitTests
{
    public partial class VertextShould : GroundShouldBase
    {
        [Fact]
        public void Vertex1_Share_Vertexs()
        {
            _5.Limits.Vertexs.Vertex1.Should().Be(_4.Limits.Vertexs.Vertex3);
            _5.Limits.Vertexs.Vertex1.Should().Be(_1.Limits.Vertexs.Vertex5);
        }

        [Fact]
        public void Vertex2_Share_Vertexs()
        {
            _5.Limits.Vertexs.Vertex2.Should().Be(_1.Limits.Vertexs.Vertex4);
            _5.Limits.Vertexs.Vertex2.Should().Be(_2.Limits.Vertexs.Vertex6);
        }
        [Fact]
        public void Vertex3_Share_Vertexs()
        {
            _5.Limits.Vertexs.Vertex3.Should().Be(_2.Limits.Vertexs.Vertex5);
            _5.Limits.Vertexs.Vertex3.Should().Be(_6.Limits.Vertexs.Vertex1);
        }
        [Fact]
        public void Vertex4_Share_Vertexs()
        {
            _5.Limits.Vertexs.Vertex4.Should().Be(_6.Limits.Vertexs.Vertex6);
            _5.Limits.Vertexs.Vertex4.Should().Be(_10.Limits.Vertexs.Vertex2);
        }
        [Fact]
        public void Vertex5_Share_Vertexs()
        {
            _5.Limits.Vertexs.Vertex5.Should().Be(_10.Limits.Vertexs.Vertex1);
            _5.Limits.Vertexs.Vertex5.Should().Be(_9.Limits.Vertexs.Vertex3);
        }
        [Fact]
        public void Vertex6()
        {
            _5.Limits.Vertexs.Vertex6.Should().Be(_9.Limits.Vertexs.Vertex2);
            _5.Limits.Vertexs.Vertex6.Should().Be(_4.Limits.Vertexs.Vertex4);
        }
    }
}