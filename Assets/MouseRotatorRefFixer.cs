using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotatorRefFixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var mouseRotator = GetComponent<mouseRotator>();
        mouseRotator.playerRef = PlayerReferenceFixer.instance.PlayerLogic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
