using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class MarbleAudio : MonoBehaviour
{
    [EventRef] public string collisionEvent;
    [EventRef] public string rollingEvent;

    public float speed;
    private EventInstance rolling;
    private EventInstance collision;

    [SerializeField] private Rigidbody rb;

    private void Update()
    {
        speed = rb.velocity.x;
        Debug.Log(rb.velocity.normalized.sqrMagnitude);
        rolling.setParameterByName("Rolling Speed", speed);
        print(rb.velocity.normalized.magnitude);
    }

    private void Start()
    {
        rolling = RuntimeManager.CreateInstance(rollingEvent);
        collision = RuntimeManager.CreateInstance(collisionEvent);
        rolling.start();
    }

    public void PlayCollisionEvent(SurfaceTypes surface)
    {
        collision.setParameterByName("Surface", surface);
    }
}
