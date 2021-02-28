using FMOD.Studio;
using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MarbleEvents : MonoBehaviour
{
    [EventRef] public string collisionEvent;
    [EventRef] public string rollingEvent;

    private EventInstance rolling;

    [SerializeField] private Rigidbody rb;

    private float oldVelocity = 0;

   

    private void Start()
    {
        rolling = RuntimeManager.CreateInstance(rollingEvent);
    }
    private void OnCollisionEnter(Collision collision)
    {
            if ( collision.relativeVelocity.magnitude > 4)
                RuntimeManager.PlayOneShot(collisionEvent);
    }

    private void Update()
    {
         Debug.Log(rb.velocity.normalized.sqrMagnitude);
         rolling.setParameterByName("velocity", rb.velocity.normalized.sqrMagnitude);
         print(rb.velocity.normalized.magnitude);
    }
}

