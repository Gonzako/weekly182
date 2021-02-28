using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public abstract class BaseInteractable : MonoBehaviour
{
    [Header("Interaction Events")]
    [Tooltip("These events will be triggered if the 'ShouldPlayerTrigger' returns true")]
    public UnityEvent OnPlayerEnter;

    [Tooltip("These events will be triggered while the player remains in the trigger zone")]
    public UnityEvent OnPlayerStay;

    [Tooltip("These events will be triggered once the player exits the trigger zone")]
    public UnityEvent OnPlayerExit;

    protected virtual bool ShouldPlayerTrigger(Player player) => true;

    protected abstract void OnPlayerTriggerEnter(Player player);

    protected abstract void OnPlayerTriggerStay(Player player);

    protected abstract void OnPlayerTriggerExit(Player player);

    private void Start()
    {
        var collider = GetComponent<Collider>();
        if (collider == null)
            Debug.LogError("There must be a collider on all interactables", this);
        collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player && ShouldPlayerTrigger(player))
        {
            OnPlayerTriggerEnter(player);
            OnPlayerEnter?.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player && ShouldPlayerTrigger(player))
        {
            OnPlayerTriggerStay(player);
            OnPlayerStay?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player && ShouldPlayerTrigger(player))
        {
            OnPlayerTriggerExit(player);
            OnPlayerExit?.Invoke();
        }
    }
}