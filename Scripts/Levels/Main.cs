using Godot;
using System;

public partial class Main : Node3D
{
    public override void _Ready()
    {
        GetTree().Paused = true;
    }
}
