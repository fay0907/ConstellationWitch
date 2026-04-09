using Godot;
using System;

public partial class CaracterControls : CharacterBody2D
{
    [Export]

    public float speed = 2000f;

    public override void _PhysicsProcess(double delta)
    {
        Vector2 direction = Vector2.Zero;

        direction.X = Input.GetActionStrength("ui_right") - Input.GetActionStrength("ui_left");
        direction.Y = Input.GetActionStrength("ui_down") - Input.GetActionStrength("ui_up");

        Velocity = direction.Normalized() * speed;
        MoveAndSlide();
    }

}