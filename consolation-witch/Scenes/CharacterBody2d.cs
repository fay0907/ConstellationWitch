using Godot;
using System;

public partial class CharacterBody2d : CharacterBody2D
{
	
	[Export]
	public float Speed = 300f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		velocity.X = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
		velocity.Y = Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up");

		Velocity = velocity.Normalized() * Speed;

		MoveAndSlide();
	}


}
