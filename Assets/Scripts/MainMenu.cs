using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject optionsmenu;
    public void play()
    {
        SceneManager.LoadScene("PingPong");
    }
    public void QuitButton()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    void Update()
    {
        Debug.Log("update:" + Time.deltaTime);
    }
    public void Activatepanal()
    {
        mainmenu.SetActive(false);
        optionsmenu.SetActive(true);
    }
    public void DeActivatepanal()
    {
        mainmenu.SetActive(true);
        optionsmenu.SetActive(false);
    }
    void LateUpdate()
    {
        Debug.Log("Late update:" + Time.deltaTime);
    }
}
