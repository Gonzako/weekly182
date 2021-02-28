using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class GameEventAudioManager : MonoBehaviour
{
    [EventRef] public string onLevelComplete;
    [EventRef] public string onLevelFailed;

    public void PlayLevelComplete(){
        RuntimeManager.PlayOneShot(onLevelComplete);
    }

    public void PlayLevelFail()
    {
        RuntimeManager.PlayOneShot(onLevelFailed);
    }
}
