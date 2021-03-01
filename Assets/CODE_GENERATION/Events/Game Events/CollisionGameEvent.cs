using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	[CreateAssetMenu(
	    fileName = "CollisionGameEvent.asset",
	    menuName = SOArchitecture_Utility.GAME_EVENT + "Collision",
	    order = 120)]
	public sealed class CollisionGameEvent : GameEventBase<Collision>
	{
	}
}