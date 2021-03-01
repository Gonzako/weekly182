using UnityEngine;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class CollisionReference : BaseReference<Collision, CollisionVariable>
	{
	    public CollisionReference() : base() { }
	    public CollisionReference(Collision value) : base(value) { }
	}
}