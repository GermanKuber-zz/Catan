using CatanBoardGame.Core;
using Xunit;

namespace CatanBoardGame.UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

            var _1 = new Ground();
            var _2 = new Ground();
            var _3 = new Ground();

            var _4 = new Ground();
            var _5 = new Ground();
            var _6 = new Ground();
            var _7 = new Ground();

            var _8 = new Ground();
            var _9 = new Ground();
            var _10 = new Ground();
            var _11 = new Ground();
            var _12 = new Ground();

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

            var teamRed = new Team(TeamColorEnum.Red, "German");

            var path1 = new Path(teamRed);
            var path2 = new Path(teamRed);
            var building = new Building(teamRed);
            var building2 = new Building(teamRed);
            _1.AddPath(path1, _1.Limits.MiddleRight);
            _1.AddPath(path2, _1.Limits.DownRight);

            _1.AddBuilding(_1.Vertexs.Vertex4, building);

            _1.AddBuilding(_1.Vertexs.Vertex6, building2);

        }
    }
}
