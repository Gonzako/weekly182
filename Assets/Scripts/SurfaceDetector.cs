using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SurfaceDetector : MonoBehaviour
{
    public SurfaceEvent onWalkingSurfaceChanged;
    private SurfaceTypes surface;

    private void OnCollisionEnter(Collision collision)
    {
        SurfaceTypes temp;
        if(collision.gameObject.TryGetComponent(out temp))
        {
            if (temp != surface)
            {
                surface = temp;
                onWalkingSurfaceChanged?.Invoke(surface);
            }
        }
    }
}

[System.Serializable]
public class SurfaceEvent : UnityEvent<SurfaceTypes>
{

}
