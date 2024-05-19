using Godot;
using System;

[Tool]
public partial class Square : ColorRect
{
	// Called when the node enters the scene tree for the first time.
	private bool _dark;
    [Export]
    public bool Dark
	{
		get
		{
			return _dark;
		}
		set
		{
			_dark = value;
			Color = _dark ? Colors.Black : Colors.White;
		}
	}

	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}

