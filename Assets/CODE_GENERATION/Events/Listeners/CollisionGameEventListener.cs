using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[AddComponentMenu(SOArchitecture_Utility.EVENT_LISTENER_SUBMENU + "CollisionGameEventListener")]
	public sealed class CollisionGameEventListener : BaseGameEventListener<Collision, CollisionGameEvent, CollisionUnityEvent>
	{
	}
}