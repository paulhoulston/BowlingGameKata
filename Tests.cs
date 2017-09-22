using System;
using Xunit;

namespace Tests
{
    public class GIVEN_I_am_bowling_my_first_ball_in_my_first_frame
    {
        public class WHEN_I_do_not_knock_over_any_pins
        {
            [Fact]
            public void THEN_my_score_is_zero() 
            {
                var score = new Game().Score();
                Assert.Equal(0, score);
            }
        }
    }

    public class Game
    {
        public int Score()
        {
            return 0;
        }
    }
}
