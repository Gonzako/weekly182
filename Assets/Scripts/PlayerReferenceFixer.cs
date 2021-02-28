using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReferenceFixer : MonoBehaviour
{

    public static PlayerReferenceFixer instance;

    [SerializeField]
    Transform playerLogic;
    [SerializeField]
    Transform playerVisuals;

    public Transform PlayerLogic { get { return playerLogic; } }
    public Transform PlayerVisuals { get { return playerVisuals; } }



    private void Awake()
    {
        PlayerReferenceFixer.instance = this;
    }

    private void OnDestroy()
    {
        PlayerReferenceFixer.instance = null;
    }
}
