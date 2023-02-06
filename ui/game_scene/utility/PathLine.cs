using Godot;

namespace OverworldTravel.ui.game_scene.utility;

[Tool]
public partial class PathLine : Line2D
{
	private Path2D parentPath;
	
	public override void _Ready()
	{
		parentPath = GetParent<Path2D>();
		parentPath.ItemRectChanged += OnChanged;
		OnChanged();
	}

	private void OnChanged()
	{
		Points = parentPath.Curve.GetBakedPoints();
	}
}