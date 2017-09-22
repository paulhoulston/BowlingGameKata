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
                var game = new Game();
                game.Roll(0);
                Assert.Equal(0, game.Score());
            }
        }

        public class WHEN_I_knock_over_one_pin
        {
            [Fact]
            public void THEN_my_score_is_one()
            {
                var game = new Game();
                game.Roll(1);
                Assert.Equal(1, game.Score());
            }
        }
    }

    public class GIVEN_I_bowl_10_frames
    {
        public class WHEN_I_do_not_knock_over_any_pins
        {
            [Fact]
            public void THEN_my_score_is_zero()
            {
                var game = new Game();
                for (var i = 0; i < 20; i++)
                    game.Roll(0);
                Assert.Equal(0, game.Score());

            }
        }
    }

    public class Game
    {
        private int _score;

        public int Score()
        {
            return _score;
        }

        public void Roll(int numberOfPinsKnockedOver)
        {
            _score += numberOfPinsKnockedOver;
        }
    }
}
