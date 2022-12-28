using Godot;

namespace MultiplayerGodot4;

public partial class Client : Node
{
	public override void _Ready()
	{
		var multiplayerPeer = new ENetMultiplayerPeer();
		GetTree().GetMultiplayer(GetPath()).ConnectedToServer += OnConnectedToServer;
		multiplayerPeer.CreateClient("localhost", 25565);
		GetTree().GetMultiplayer(GetPath()).MultiplayerPeer = multiplayerPeer;
		GD.Print("GetTree().GetMultiplayer(GetPath()).IsServer(): ", GetTree().GetMultiplayer(GetPath()).IsServer());
	}

	private void OnConnectedToServer()
	{
		GD.Print("Connected!");
	}
}
