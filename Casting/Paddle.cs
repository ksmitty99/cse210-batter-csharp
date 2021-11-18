using System;
using Raylib_cs;
using System.Collections.Generic;

namespace cse210_batter_csharp.Casting
{
    public class Paddle : Actor
    {
        string paddle = Constants.IMAGE_PADDLE;
        int _paddleWidth = Constants.PADDLE_WIDTH;
        int _paddleHeight = Constants.PADDLE_HEIGHT;

        public Paddle(Point position, int width, int height)
        {
            SetPosition(position);
            SetWidth(_paddleWidth);
            SetHeight(_paddleHeight);
        }
    }
}