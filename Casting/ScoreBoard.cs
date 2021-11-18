using System;
using Raylib_cs;
using System.Collections.Generic;

namespace cse210_batter_csharp.Casting
{
    class ScoreBoard : Actor
    {   
        public ScoreBoard(Point point)
        {
            SetPosition(new Point(Constants.MAX_X+700,Constants.MAX_Y+558));
            _width = 0;
            _height = 0;
            
            UpdateText();
        }
    }
}