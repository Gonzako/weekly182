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


public class UIPositionReseter : MonoBehaviour
{

    #region PublicFields
    public Transform positionToPutOn;
    #endregion

    #region PrivateFields

    #endregion

    #region UnityCallBacks

    void Awake()
    {

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

    private void OnTriggerEnter(Collider other)
    {
        other.attachedRigidbody.velocity = Vector3.zero;
        other.transform.position = positionToPutOn.position;
    }

    #endregion

    #region PublicMethods

    #endregion


    #region PrivateMethods


    #endregion
}
