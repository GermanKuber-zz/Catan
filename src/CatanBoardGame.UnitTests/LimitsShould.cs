using FluentAssertions;
using Xunit;

namespace CatanBoardGame.UnitTests
{

    public class LimitsShould : GroundShouldBase
    {
        [Fact]
        public void TopLeft()
        {
            _5.Limits.TopLeft.Should().Be(_1.Limits.RightDown);
        }
        [Fact]
        public void TopRight()
        {
            _5.Limits.TopRight.Should().Be(_2.Limits.LeftDown);
        }

        [Fact]
        public void MiddleRight()
        {
            _5.Limits.MiddleRight.Should().Be(_6.Limits.MiddleLeft);
        }
        [Fact]
        public void RightDown()
        {
            _5.Limits.RightDown.Should().Be(_10.Limits.TopLeft);
        }
        [Fact]
        public void LeftDown()
        {
            _5.Limits.LeftDown.Should().Be(_9.Limits.TopRight);
        }
        [Fact]
        public void MiddleLeft()
        {
            _5.Limits.MiddleLeft.Should().Be(_4.Limits.MiddleRight);
        }


    }
}