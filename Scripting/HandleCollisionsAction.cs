using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;
using System;

namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to appropriately handle any collisions in the game.
    /// </summary>
    public class HandleCollisionsAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService audioService = new AudioService();
        Random rnd = new Random();
        public HandleCollisionsAction(PhysicsService physicsService)
        {
            _physicsService = physicsService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor paddle = cast["paddle"][0];
            Actor ball = cast["balls"][0];
            List<Actor> bricks = cast["bricks"];
            Actor scoreBoard = cast["scoreBoard"][0];
            if(_physicsService.IsCollision(paddle,ball))
            {
                ball.ChangeDY();
                audioService.PlaySound(Constants.SOUND_BOUNCE);
            }
            List<Actor> bricksToRemove = new List<Actor>();
            foreach(Actor actor in bricks)
            {
                Brick brick = (Brick)actor;
                if(_physicsService.IsCollision(ball,brick))
                {
                    ball.ChangeDY();
                    scoreBoard.AddPoints(5);
                    scoreBoard.UpdateText();
                    bricksToRemove.Add(brick);
                }
            }
            foreach(Actor brick in bricksToRemove)
            {
                cast["bricks"].Remove(brick);
            }
        }

    }
}