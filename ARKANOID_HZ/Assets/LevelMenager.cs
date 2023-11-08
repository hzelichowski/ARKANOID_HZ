using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class LevelMenager : MonoBehaviour
{
    
    void Start()
    {
        
    }
    
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(1);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Lose");
            
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
   
    void Update()
    {
        
        

    }
}
