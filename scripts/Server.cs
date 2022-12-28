using Godot;

namespace MultiplayerGodot4;

public partial class Server : Node
{
	public async override void _Ready()
	{
		var multiplayerPeer = new ENetMultiplayerPeer();
		multiplayerPeer.CreateServer(25565, 32);
		GetTree().GetMultiplayer(GetPath()).MultiplayerPeer = multiplayerPeer;
		GD.Print("SERVER: GetTree().GetMultiplayer(GetPath()).IsServer(): ", GetTree().GetMultiplayer(GetPath()).IsServer());

		await ToSignal(GetTree().CreateTimer(2f), "timeout");
		GD.Print("SERVER: GetTree().GetMultiplayer(GetPath()).IsServer(): ", GetTree().GetMultiplayer(GetPath()).IsServer());
	}
}
