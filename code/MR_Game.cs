using Sandbox;


namespace Sandbox
{
	public partial class MR_Game : Game
	{
		MR_HUD MRHUD;

		public MR_Game()
		{
			if ( IsClient ) MRHUD = new MR_HUD();
		}

		[Event.Hotload]
		public void HotLoadUpdate()
		{
			if ( !IsClient || MRHUD == null ) return;
			MRHUD?.Delete();
			MRHUD = new MR_HUD();
		}

		public override void ClientJoined( Client client )
		{
			base.ClientJoined( client );

			// Create a pawn and assign it to the client.
			var player = new MR_Player();
			client.Pawn = player;

			player.Respawn();
		}
	}
}


