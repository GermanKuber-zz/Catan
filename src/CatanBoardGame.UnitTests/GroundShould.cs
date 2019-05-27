using CatanBoardGame.Core;
using FluentAssertions;
using Xunit;

namespace CatanBoardGame.UnitTests
{
    public class GroundShould : GroundShouldBase
    {


        public GroundShould()
        {
            SetUpBoard();
            _teamRed = new Team(TeamColorEnum.Red, "German");
            _teamBlue = new Team(TeamColorEnum.Blue, "Other");

        }

        [Fact]
        public void Has_Same_MiddleRight_than_MiddleLeft()
        {
            _1.Limits.MiddleRight.Should().Be(_2.Limits.MiddleLeft);
        }

        [Fact]
        public void Has_Same_Middle_Right_that_Middle_Left()
        {
            _4.Limits.MiddleRight.Should().Be(_5.Limits.MiddleLeft);
        }

        [Fact]
        public void Has_Same_Down_Right_that_Top_Left()
        {
            _1.Limits.DownRight.Should().Be(_5.Limits.TopLeft);
        }
        [Fact]
        public void Has_Same_Top_Right_than_Down_Left()
        {
            _5.Limits.TopRight.Should().Be(_2.Limits.LeftDown);
        }

        private void SetUpBoard()
        {

            _1.AddRight(_2.AddRight(_3));
            _1.AddLeftDown(_4);
            _1.AddRightDown(_5);
            _2.AddLeftDown(_5);
            _2.AddRightDown(_6);
            _3.AddLeftDown(_6);
            _3.AddRightDown(_7);
            _4.AddRight(_5.AddRight(_6.AddRight(_7)));
            _4.AddLeftDown(_8);
            _4.AddRightDown(_9);
            _5.AddLeftDown(_9);
            _5.AddRightDown(_10);
            _6.AddLeftDown(_10);
            _6.AddRightDown(_11);
            _7.AddLeftDown(_11);
            _7.AddRightDown(_12);
        }


        [Fact]
        public void Be_Same_Building_Same_Vertex_Different_Ground()
        {
            var newBuilding = new Building(_teamRed);
            var path1 = new Path(_teamRed);
            var path2 = new Path(_teamRed);
            _1.AddPath(path1, _1.Limits.MiddleRight);
            _1.AddPath(path2, _1.Limits.DownRight);

            _1.AddBuilding(_1.Vertexs.Vertex5, newBuilding);
            _1.Vertexs.Vertex5.Building.Should().Be(newBuilding);
            _5.Vertexs.Vertex1.Building.Should().Be(newBuilding);
        }
    }
}
