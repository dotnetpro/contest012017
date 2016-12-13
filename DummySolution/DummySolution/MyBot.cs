using System;
using OQF.Bot.Contracts;
using OQF.Bot.Contracts.Coordination;
using OQF.Bot.Contracts.GameElements;
using OQF.Bot.Contracts.Moves;

namespace DummySolution
{
	public class MyBot : IQuoridorBot
    {
		public event Action<Move> NextMoveAvailable;
		public event Action<string> DebugMessageAvailable;

		public void Init(PlayerType yourStartPosition, GameConstraints gameConstraints)
	    {		    
	    }

	    public void DoMove(BoardState currentState)
	    {
		   NextMoveAvailable?.Invoke(new Capitulation());
	    }	    
    }
}
