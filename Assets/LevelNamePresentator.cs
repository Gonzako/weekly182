using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
/// 
/// Copyright (c) 2021 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>


public class LevelNamePresentator : MonoBehaviour
{

    #region PublicFields

    #endregion

    #region PrivateFields
    [SerializeField]
    ScriptableObjectArchitecture.StringCollection levelNames;
    #endregion

    #region UnityCallBacks

    void Awake()
    {
        var i = SceneManager.GetActiveScene().buildIndex;
        GetComponent<TextMeshProUGUI>().text = levelNames[i];
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

    #endregion


    #region PrivateMethods


    #endregion
}
