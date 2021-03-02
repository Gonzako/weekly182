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


public class FallTimerReset : MonoBehaviour
{

    #region PublicFields

    public UnityEngine.Events.UnityEvent OnResetPlayerDueToStuck;
    public float currentTime = 0;
    #endregion

    #region PrivateFields
    
    [SerializeField, Range(2f, 10f)]
        float maxTime = 4f;
    Rigidbody rb;

    #endregion

    #region UnityCallBacks

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        currentTime += Time.fixedDeltaTime;
        if(currentTime > maxTime)
        {
            transform.localPosition = Vector3.zero;
            rb.velocity = Vector3.zero;
            currentTime = 0;
            OnResetPlayerDueToStuck.Invoke();
        }
    }

    void OnEnable()
    {

    }


    private void OnDisable()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        currentTime = 0;
    }

    #endregion

    #region PublicMethods
    public void resetTimer()
    {
        currentTime = 0;
    }
    #endregion


    #region PrivateMethods


    #endregion
}
