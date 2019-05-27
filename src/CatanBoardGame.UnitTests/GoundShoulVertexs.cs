using CatanBoardGame.Core;
using FluentAssertions;
using Xunit;

namespace CatanBoardGame.UnitTests
{
    public class GoundShoulVertexs : GroundShouldBase
    {
        public GoundShoulVertexs()
        {

        }
        [Fact]
        public void Add_1_MiddleRight_With_2_MiddleLeft()
        {
            _1.AddRight(_2);
            _1.Limits.MiddleRight.Should().Be(_2.Limits.MiddleLeft);
            _1.Vertexs.Vertex3.Should().Be(_2.Vertexs.Vertex1);
            _1.Vertexs.Vertex4.Should().Be(_2.Vertexs.Vertex6);
        }

        [Fact]
        public void Add_1_RightDown_With_5_TopLeft()
        {
            _1.AddRight(_2);
            _2.AddLeftDown(_5);
            _1.AddRightDown(_5);
            _1.Limits.DownRight.Should().Be(_5.Limits.TopLeft);
            _1.Vertexs.Vertex4.Should().Be(_5.Vertexs.Vertex2);
            _1.Vertexs.Vertex5.Should().Be(_5.Vertexs.Vertex1);
            _2.Vertexs.Vertex6.Should().Be(_5.Vertexs.Vertex2);
        }
        [Fact]
        public void Add_1_LeftDown_With_4_TopRight()
        {
            _1.AddLeftDown(_4);
            _4.AddRight(_5);
            _1.AddRightDown(_5);

            _1.Limits.LeftDown.Should().Be(_4.Limits.TopRight);
            _1.Vertexs.Vertex6.Should().Be(_4.Vertexs.Vertex2);
            _1.Vertexs.Vertex5.Should().Be(_4.Vertexs.Vertex3);
            _5.Vertexs.Vertex1.Should().Be(_4.Vertexs.Vertex3);
            _5.Vertexs.Vertex1.Should().Be(_1.Vertexs.Vertex5);
        }

        [Fact]
        public void Add_Path_LeftDown_And_TopRight()
        {
            _1.AddLeftDown(_4);
            _4.AddRight(_5);
            _1.AddRightDown(_5);
            _4.AddPath(new Path(_teamRed), _4.Limits.TopRight);
            _1.Limits.LeftDown.Path.Should().Be(_4.Limits.TopRight.Path);
        }

        [Fact]
        public void Add_Path_MiddleRight_And_MiddleLeft()
        {
            _1.AddLeftDown(_4);
            _4.AddRight(_5);
            _1.AddRightDown(_5);
            _4.AddPath(new Path(_teamRed), _4.Limits.MiddleRight);
            _4.Limits.MiddleRight.Path.Should().Be(_5.Limits.MiddleLeft.Path);
        }
        [Fact]
        public void Add_Building_Vertex4_And_Vertex2()
        {
            _1.AddLeftDown(_4);
            _4.AddRight(_5);
            _1.AddRightDown(_5);

            _4.AddPath(new Path(_teamRed), _4.Limits.TopRight);
            _4.AddPath(new Path(_teamRed), _4.Limits.MiddleRight);

            _4.AddBuilding(_4.Vertexs.Vertex4, new Building(_teamRed));

            _4.Vertexs.Vertex4.Should().Be(_5.Vertexs.Vertex6);
            _4.Vertexs.Vertex4.Building.Should().Be(_5.Vertexs.Vertex6.Building);
        }

        [Fact]
        public void Add_Building_Vertex5_And_Vertex3_And_Vertex2()
        {
            _1.AddLeftDown(_4);
            _4.AddRight(_5);
            _1.AddRightDown(_5);

            _4.AddPath(new Path(_teamRed), _4.Limits.TopRight);
            _4.AddPath(new Path(_teamRed), _4.Limits.MiddleRight);

            _4.AddBuilding(_4.Vertexs.Vertex3, new Building(_teamRed));

            _4.Vertexs.Vertex3.Should().Be(_5.Vertexs.Vertex1);
            _1.Vertexs.Vertex5.Should().Be(_5.Vertexs.Vertex1);

            _4.Vertexs.Vertex3.Building.Should().Be(_5.Vertexs.Vertex1.Building);
            _1.Vertexs.Vertex5.Building.Should().Be(_4.Vertexs.Vertex3.Building);
        }
    }
}