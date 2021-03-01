using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MarbleCollisionSorter : MonoBehaviour
{
    [EventRef] public string collisionEvent;
    [EventRef] public string rollingEvent;

    private EventInstance rolling;

    [SerializeField] private Rigidbody rb;

    private float oldVelocity = 0;


    public float TopThreshold = 6f;
    public float MiddleThreshold = 4f;
    public float BottomThreshold = 2f;

    public MarbleCollisionEvents OnHeavyHit;
    public MarbleCollisionEvents OnMiddleHit;
    public MarbleCollisionEvents OnSoftHit;
    public MarbleCollisionEvents OnAnyCollision;

    private void Start()
    {
        rolling = RuntimeManager.CreateInstance(rollingEvent);
    }
    private void OnCollisionEnter(Collision collision)
    {
        var relMagnitude = collision.relativeVelocity.magnitude;
        if ( relMagnitude < BottomThreshold)
        {
            OnAnyCollision.Invoke(collision);
        }
        else if (relMagnitude < MiddleThreshold)
        {
            OnSoftHit.Invoke(collision);

            OnAnyCollision.Invoke(collision);
        } 
        else if(relMagnitude < TopThreshold)
        {
            OnMiddleHit.Invoke(collision);

            OnAnyCollision.Invoke(collision);
            RuntimeManager.PlayOneShot(collisionEvent);
        }
        else
        {
            OnHeavyHit.Invoke(collision);

            OnAnyCollision.Invoke(collision);
        }

    }

    private void Update()
    {
         Debug.Log(rb.velocity.normalized.sqrMagnitude);
         rolling.setParameterByName("velocity", rb.velocity.normalized.sqrMagnitude);
         print(rb.velocity.normalized.magnitude);
    }


}

[System.Serializable]
public class MarbleCollisionEvents : UnityEvent<Collision> { }