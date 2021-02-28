using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public abstract class BaseInteractable<T> : MonoBehaviour where T : MonoBehaviour
{
    [Header("Interaction Events")]
    [Tooltip("These events will be triggered if the 'ShouldPlayerTrigger' returns true")]
    public UnityEvent<T> OnPlayerEnter;

    [Tooltip("These events will be triggered while the player remains in the trigger zone")]
    public UnityEvent<T> OnPlayerStay;

    [Tooltip("These events will be triggered once the player exits the trigger zone")]
    public UnityEvent<T> OnPlayerExit;

    protected virtual bool ShouldPlayerTrigger(T other) => true;

    protected abstract void OnPlayerTriggerEnter(T other);

    protected abstract void OnPlayerTriggerStay(T other);

    protected abstract void OnPlayerTriggerExit(T other);

    private void Start()
    {
        var collider = GetComponent<Collider>();
        if (collider == null)
            Debug.LogError("There must be a collider on all interactables", this);
    }

    private void OnTriggerEnter(Collider other)
    {
        OnEnter(other);
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnEnter(collision.collider);
    }

    private void OnEnter(Collider other)
    {
        var obj = other.GetComponent<T>();
        if (CanTrigger(obj))
        {
            Debug.Log($"{obj.name} has entered {gameObject.name} collider");
            OnPlayerTriggerEnter(obj);
            OnPlayerEnter?.Invoke(obj);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        OnStay(other);
    }

    private void OnCollisionStay(Collision collision)
    {
        OnStay(collision.collider);
    }

    private void OnStay(Collider other)
    {
        var obj = other.GetComponent<T>();
        if (CanTrigger(obj))
        {
            OnPlayerTriggerStay(obj);
            OnPlayerStay?.Invoke(obj);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        OnExit(other);
    }

    private void OnCollisionExit(Collision collision)
    {
        OnExit(collision.collider);
    }

    private void OnExit(Collider other)
    {
        var obj = other.GetComponent<T>();
        if (CanTrigger(obj))
        {
            Debug.Log($"{obj.name} has exit {gameObject.name} collider");
            OnPlayerTriggerExit(obj);
            OnPlayerExit?.Invoke(obj);
        }
    }

    private bool CanTrigger(T obj)
    {
        return obj != null && ShouldPlayerTrigger(obj);
    }
}