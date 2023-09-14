using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Checker
{
    public static bool isLoadedToStratScens = false;
}
public class SceneChecker : MonoBehaviour
{
    public bool startScene = false;
    private void Awake()
    {
        if(startScene == true)
        {
            Checker.isLoadedToStratScens = true;
        }
        if (Checker.isLoadedToStratScens == false)
        {
            SceneManager.LoadScene((int)SceneIndex.mainScene);
        }
    }

}
