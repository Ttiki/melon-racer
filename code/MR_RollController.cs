using Sandbox;

namespace Sandbox
{
	class MR_RollController : BasePlayerController
	{
		public override void FrameSimulate()
		{
			base.FrameSimulate();

			EyeRot = Input.Rotation;
		}

		public override void Simulate()
		{

			// Create a direction vector from the input from the client
			var direction = new Vector3( Input.Forward, Input.Left, 0 );

			// Rotate the vector so forward is the way we're facing
			direction *= Input.Rotation; 

			// Normalize it and multiply by speed
			direction = direction.Normal * 500;

			// Apply the move
			Velocity += direction * Time.Delta;

			//
			// True if the button is down, but wasn't last tick
			//
			if ( Input.Pressed( InputButton.Jump ) )
			{
				//DoJump()
			}
		}
	}
}

