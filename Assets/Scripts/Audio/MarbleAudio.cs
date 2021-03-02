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
    public float volume;
    private EventInstance rolling;
    private EventInstance collision;
    private SurfaceTypes surface;

    [SerializeField] private Rigidbody rb;

    private void Update()
    {
        speed = Mathf.Abs(rb.velocity.x * rb.velocity.magnitude);
        rolling.setParameterByName("Rolling Speed", speed);
        
    }

    private void Start()
    {
        rolling = RuntimeManager.CreateInstance(rollingEvent);
        collision = RuntimeManager.CreateInstance(collisionEvent);
        RuntimeManager.AttachInstanceToGameObject(collision, transform, rb);
        RuntimeManager.AttachInstanceToGameObject(rolling, transform, rb);
        rolling.start();
        rolling.getVolume(out volume);
        print(volume);
    }

    public void PlayCollisionEvent(Collision col)
    {
        Surface surface;
        if(col.gameObject.TryGetComponent(out surface))
        {
            Debug.Log(surface.GetSurface.ToString());
            int s = (int)surface.GetSurface;
            collision.setParameterByName("Surface", s);
        }
        collision.start();
 
    }

 

    

    private void OnCollisionEnter(Collision collision)
    {
        Surface temp;
        if (collision.gameObject.TryGetComponent(out temp))
        {
            if (temp.GetSurface != surface)
            {
                surface = temp.GetSurface;
                int s = (int)surface;
                rolling.setParameterByName("Surface", s);
                print("Touching");
                print(surface.ToString());
            }
        }
    }

}
