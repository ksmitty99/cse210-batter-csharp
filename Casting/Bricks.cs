using System;
using Raylib_cs;
using System.Collections.Generic;

namespace cse210_batter_csharp.Casting
{
    public class Brick : Actor
    {
        private List<Actor> _bricks = new List<Actor>();
        
        public Brick(int x, int y, string image) 
        {
            SetPosition(new Point(x,y));
            SetWidth(Constants.BRICK_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetImage(image);
        }
    }
}