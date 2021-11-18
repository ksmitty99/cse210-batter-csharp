using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;
using System;

namespace cse210_batter_csharp.Scripting
{
    /// <summary>
    /// An action to appropriately handle any collisions in the game.
    /// </summary>
    public class HandleOffScreenAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();
        Random rnd = new Random();
        public HandleOffScreenAction(PhysicsService physicsService, AudioService audioService)
        {
            _physicsService = physicsService;
            _audioService = audioService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor ball = cast["balls"][0];
            if(ball.GetLeftEdge() <= 0)
            {
                ball.ChangeDX();
                _audioService.PlaySound(Constants.SOUND_BOUNCE);
            }
            if(ball.GetRightEdge() >= Constants.MAX_X)
            {
                ball.ChangeDX();
                _audioService.PlaySound(Constants.SOUND_BOUNCE);
            }
            if(ball.GetTopEdge() <= 0)
            {
                ball.ChangeDY();
                _audioService.PlaySound(Constants.SOUND_BOUNCE);
            }
            if(ball.GetBottomEdge() >= Constants.MAX_Y)
            {
                _audioService.PlaySound(Constants.SOUND_OVER);
                Director._keepPlaying = false;
            }
            
        }

    }
}