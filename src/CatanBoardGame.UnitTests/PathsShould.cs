using FluentAssertions;
using Xunit;

namespace CatanBoardGame.UnitTests
{
    public class PathsShould : GroundShouldBase
    {
        [Fact]
        public void TopLeft()
        {
            _5.Limits.TopLeft.AddPath(new Core.Path(_teamRed));
            _5.Limits.TopLeft.Path.Should().Be(_1.Limits.RightDown.Path);
        }
        [Fact]
        public void TopRight()
        {
            _5.Limits.TopRight.AddPath(new Core.Path(_teamRed));

            _5.Limits.TopRight.Path.Should().Be(_2.Limits.LeftDown.Path);
        }

        [Fact]
        public void MiddleRight()
        {
            _5.Limits.MiddleRight.AddPath(new Core.Path(_teamRed));

            _5.Limits.MiddleRight.Path.Should().Be(_6.Limits.MiddleLeft.Path);
        }
        [Fact]
        public void RightDown()
        {
            _5.Limits.RightDown.AddPath(new Core.Path(_teamRed));

            _5.Limits.RightDown.Path.Should().Be(_10.Limits.TopLeft.Path);
        }
        [Fact]
        public void LeftDown()
        {
            _5.Limits.LeftDown.AddPath(new Core.Path(_teamRed));

            _5.Limits.LeftDown.Path.Should().Be(_9.Limits.TopRight.Path);
        }
        [Fact]
        public void MiddleLeft()
        {
            _5.Limits.MiddleLeft.AddPath(new Core.Path(_teamRed));

            _5.Limits.MiddleLeft.Path.Should().Be(_4.Limits.MiddleRight.Path);
        }
    }
}