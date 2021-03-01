using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// 
/// Copyright (c) 2021 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>


public class StageFallBack : MonoBehaviour
{

    #region PublicFields

    #endregion

    #region PrivateFields

    private Vector3 startPos;
    private Quaternion startRotation;
    #endregion

    #region UnityCallBacks

    void Awake()
    {
        startPos = transform.position;
        startRotation = transform.rotation;
    }

    void FixedUpdate()
    {

    }

    void OnEnable()
    {

    }


    private void OnDisable()
    {

    }


    #endregion

    #region PublicMethods

    public void resetPosition()
    {
        transform.position = startPos;
        transform.rotation = startRotation;
    }
    #endregion


    #region PrivateMethods


    #endregion
}
