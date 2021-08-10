using Sandbox;

namespace Sandbox
{
	
	public partial class MR_Player : Player
	{
	
		public override void Respawn()
		{
			base.Respawn();
			SetModel( "models/sbox_props/watermelon/watermelon.vmdl" );

			Camera = new SpectateRagdollCamera();

			Controller = new MR_RollController();

			MoveType = MoveType.Physics;
			UsePhysicsCollision = true;
			EnableAllCollisions = true;
			CollisionGroup = CollisionGroup.Prop;
			EnableHitboxes = true;
			SurroundingBoundsMode = SurroundingBoundsType.Physics;
			RenderColorAndAlpha = RenderColorAndAlpha;
			EnableDrawing = true;

			SetInteractsAs( CollisionLayer.PhysicsProp );
			SetInteractsWith( CollisionLayer.WORLD_GEOMETRY );
			SetInteractsExclude( CollisionLayer.Debris );

			SetupPhysicsFromModel( PhysicsMotionType.Dynamic );
			
		}

		public override void Simulate( Client cl )
		{
			base.Simulate( cl );
			
		}
	}
}

