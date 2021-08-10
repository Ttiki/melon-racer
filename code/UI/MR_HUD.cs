using Sandbox;
using Sandbox.UI;

namespace Sandbox
{
	public partial class MR_HUD : HudEntity<RootPanel>
	{
		public MR_HUD()
		{
			if ( !IsClient ) return;

			RootPanel.AddChild<MR_Vitals>();
		}
	}
}
