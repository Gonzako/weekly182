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


public class mouseLocker : MonoBehaviour
{

    #region PublicFields
    public bool lockOnClick = true;
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
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && lockOnClick)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    #endregion

    #region PublicMethods


    public void lockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    #endregion


    #region PrivateMethods


    #endregion
}
