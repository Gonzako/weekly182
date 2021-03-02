
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MarbleCollisionSorter : MonoBehaviour
{
    private float oldVelocity = 0;


    public float TopThreshold = 6f;
    public float MiddleThreshold = 4f;
    public float BottomThreshold = 2f;

    public MarbleCollisionEvents OnHeavyHit;
    public MarbleCollisionEvents OnMiddleHit;
    public MarbleCollisionEvents OnSoftHit;
    public MarbleCollisionEvents OnAnyCollision;


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
        }
        else
        {
            OnHeavyHit.Invoke(collision);

            OnAnyCollision.Invoke(collision);
        }

    }


}

[System.Serializable]
public class MarbleCollisionEvents : UnityEvent<Collision> { }