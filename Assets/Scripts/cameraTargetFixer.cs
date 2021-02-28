using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraTargetFixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CinemachineTargetGroup group = GetComponent<CinemachineTargetGroup>();
        Transform player = PlayerReferenceFixer.instance.PlayerLogic;
        Transform momentumTarget = PlayerReferenceFixer.instance.PlayerLogic.GetComponentInChildren<momentumSetter>().transform;
        group.AddMember(player, 1, 0);
        group.AddMember(momentumTarget, 0.02f, 0);

    }

    void Update()
    {
        
    }
}
