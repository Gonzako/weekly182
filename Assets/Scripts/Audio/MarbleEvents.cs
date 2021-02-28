using FMODUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using FMOD;
using FMOD.Studio;

public class MarbleEvents : MonoBehaviour
{
    [EventRef] public string collisionEvent;
    [EventRef] public string rollingEvent;

    private EventInstance rolling;

    [SerializeField] private Rigidbody rb;

    private void Start()
    {
        rolling = RuntimeManager.CreateInstance(rollingEvent);
    }
    private void OnCollisionEnter(Collision collision)
    {
        RuntimeManager.PlayOneShot(collisionEvent);
    }

    private void Update()
    {
        rolling.setParameterByName("velocity", rb.velocity.normalized.magnitude);
        print(rb.velocity.normalized.magnitude);
    }
}

