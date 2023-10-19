using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DontDestroyOnLoad : MonoBehaviour
{
    //public static DontDestroyOnLoad Instance;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void HomeBtn()
    {
        SceneManager.LoadScene(0);
    }
    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevelBtn() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);   
    }
}
