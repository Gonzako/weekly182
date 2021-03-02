using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// 
/// Copyright (c) 2020 All Rights Reserved
///
/// <author>Gonzako</author>
/// <co-authors>... </co-author>
/// <summary> Monobeavior class that does something </summary>


public class LoadNextScene : MonoBehaviour
{


    #region PublicFields

    #endregion

    #region PrivateFields

    AsyncOperation preppedScene;

    #endregion

    #region UnityCallBacks
    private void OnEnable()
    {

    }

    #endregion

    #region PublicMethods

    public void loadNextScene(float delay)
    {

        StartCoroutine(loadNext(delay));

    }

    #endregion


    #region PrivateMethods

    private IEnumerator loadNext(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        if (preppedScene  != null)
        {
            preppedScene.allowSceneActivation = true;
            
            yield return null;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1,
            LoadSceneMode.Single);
        }


    }

    public void prepareNextScene()
    {
        preppedScene = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
        preppedScene.allowSceneActivation = false;
        
    }
    #endregion
}
