using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace Sandbox
{
	public partial class MR_Vitals : Panel
	{
		
		private Panel HealthBar;

		public MR_Vitals()
		{
			StyleSheet.Load( "/ui/Vitals.scss" );

			Panel healthBack = Add.Panel( "healthBack" );

	
			HealthBar = healthBack.Add.Panel( "healthBar" );
		}

		public override void Tick()
		{
			base.Tick();

			var player = Local.Pawn;
			if ( player == null ) return;

			HealthBar.Style.Dirty();
			HealthBar.Style.Width = Length.Percent( player.Health );
			if ( player.Health <= 50 && player.Health > 25)
			{
				HealthBar.Style.BackgroundColor = new Color( 255, 240, 0 );
				
			}else if( player.Health <= 25 )
			{
				HealthBar.Style.BackgroundColor = new Color( 255, 0, 0 );
			}
			else
			{
				HealthBar.Style.BackgroundColor = new Color( 0, 255, 0 );
			}

				
		}
	}
}
