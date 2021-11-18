using System;
using Raylib_cs;
using System.Collections.Generic;

namespace cse210_batter_csharp.Casting
{
    public class Ball : Actor
    {
        private List<Actor> _bricks = new List<Actor>();
        string ball = Constants.IMAGE_BALL;
        public int _ballWidth = Constants.BALL_WIDTH;
        public int _ballHeight = Constants.BALL_HEIGHT;
        public int _ballDX = Constants.BALL_DX;
        public int _ballDY = Constants.BALL_DY;
        public Ball(Point position, Point velocity, int width, int height) 
        {
            SetPosition(position);
            SetVelocity(velocity);
            SetWidth(_ballWidth);
            SetHeight(_ballHeight);
            SetImage(ball);
        }
    }
}