using CatanBoardGame.Core;

namespace CatanBoardGame.UnitTests
{
    public class GroundShouldBase
    {
        protected Ground _1;
        protected Ground _2;
        protected Ground _3;
        protected Ground _4;
        protected Ground _5;
        protected Ground _6;
        protected Ground _7;
        protected Ground _8;
        protected Ground _9;
        protected Ground _10;
        protected Ground _11;
        protected Ground _12;
        protected Team _teamRed;
        protected Team _teamBlue;

        public GroundShouldBase()
        {
            _1 = new Ground("1");
            _2 = new Ground("2");
            _3 = new Ground("3");
            _4 = new Ground("4");
            _5 = new Ground("5");
            _6 = new Ground("6");
            _7 = new Ground("7");
            _8 = new Ground("8");
            _9 = new Ground("9");
            _10 = new Ground("10");
            _11 = new Ground("11");
            _12 = new Ground("12");
            MakeBoard();
        }

        protected virtual void MakeBoard()
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
    }
}