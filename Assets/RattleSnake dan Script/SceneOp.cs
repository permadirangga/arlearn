using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneOp : MonoBehaviour
{
    public void GoToMainMenu()
    {
     	SceneManager.LoadScene("About");   
    }

    public void GoToARCamera()
    {
     	SceneManager.LoadScene("ARScan");   
    }

    public void GoToSceneTiga()
    {
	SceneManager.LoadScene("Pertolongan");
    }

    public void GoToSceneEmpat()
    {
   	SceneManager.LoadScene("Peta");
    }

    public void GoToSceneLima()
    {
	SceneManager.LoadScene("Perbedaan");
    }
    
     public void GoToScanUlar()
    {
	SceneManager.LoadScene("ScanUlar");
    }

     public void GoToCamera()
    {
     	SceneManager.LoadScene("TestAja");   
    }

}
