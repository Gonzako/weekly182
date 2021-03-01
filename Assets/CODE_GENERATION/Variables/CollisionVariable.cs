using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public class CollisionEvent : UnityEvent<Collision> { }

	[CreateAssetMenu(
	    fileName = "CollisionVariable.asset",
	    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "Collision",
	    order = 120)]
	public class CollisionVariable : BaseVariable<Collision, CollisionEvent>
	{
	}
}