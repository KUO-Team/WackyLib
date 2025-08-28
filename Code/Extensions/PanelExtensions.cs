namespace Sandbox.UI;

public static class PanelExtensions
{
	public static void Hide( this Panel panel )
	{
		panel.AddClass( "hidden" );
	}

	public static void Show( this Panel panel )
	{
		panel.RemoveClass( "hidden" );
	}
}

public static class PanelComponentExtensions
{
	public static void Hide( this PanelComponent component )
	{
		component.Panel.AddClass( "hidden" );
	}

	public static void Show( this PanelComponent component )
	{
		component.Panel.RemoveClass( "hidden" );
	}
}
