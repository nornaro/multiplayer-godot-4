using System;
using System.Linq;
using Godot;

namespace MultiplayerGodot4;

public partial class Main : Node
{
	public override void _Ready()
	{
		if (OS.GetCmdlineArgs().Contains("--integratedserver"))
		{
			// Load server
			AddChild(GD.Load<PackedScene>("res://scenes/server.tscn").Instantiate());

			// Create client instance
			OS.CreateInstance(new[] { "" });
		}
		else if (OS.GetCmdlineArgs().Contains("--server"))
		{
			AddChild(GD.Load<PackedScene>("res://scenes/server.tscn").Instantiate());
		}
		else
		{
			AddChild(GD.Load<PackedScene>("res://scenes/client.tscn").Instantiate());
		}
	}
}
