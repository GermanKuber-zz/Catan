using CatanBoardGame.Core;
using FluentAssertions;
using Xunit;

namespace CatanBoardGame.UnitTests
{
    public class GroundShould : GroundShouldBase
    {


        public GroundShould()
        {
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
            _1.Limits.RightDown.Should().Be(_5.Limits.TopLeft);
        }
        [Fact]
        public void Has_Same_Top_Right_than_Down_Left()
        {
            _5.Limits.TopRight.Should().Be(_2.Limits.LeftDown);
        }

        [Fact]
        public void Return_Error_When_Add_Two_Path_In_Same_Limit()
        {
            _5.AddPath(new Path(_teamRed), _5.Limits.MiddleRight);
            _5.AddPath(new Path(_teamRed), _5.Limits.MiddleRight).SuccessResult.Should().Be(false);

        }
        [Fact]
        public void Return_Error_When_The_Limit_Does_Not_Exist()
        {
            _5.AddPath(new Path(_teamRed), _1.Limits.MiddleRight).SuccessResult.Should().Be(false); 
        }
    }
}
