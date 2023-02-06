using Godot;

namespace OverworldTravel.entities.characters.sorcerex;

public partial class PlayerBody : CharacterBody2D
{
	[Export]
	public float MovementSpeedBaseInPixelsPerSecond = 50f;
	
	
	
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		var movementVector = new Vector2(
			Input.GetActionStrength("character_right") - Input.GetActionStrength("character_left"),
			Input.GetActionStrength("character_down") - Input.GetActionStrength("character_up"));

		Velocity = movementVector * MovementSpeedBaseInPixelsPerSecond;
		MoveAndSlide();
	}
}
