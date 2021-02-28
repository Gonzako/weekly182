using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class TeleporterAudio : MonoBehaviour
{
    [EventRef] public string portalEnter;

    public void PlayPortalEnter()
    {
        RuntimeManager.PlayOneShot(portalEnter);
    }
}
