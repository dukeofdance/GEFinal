using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigator : MonoBehaviour
{
    bool levelFailed = false;
    bool levelEnd = false;
    bool mainMenu = false;

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            mainMenu = true;
        }

        if (SceneManager.GetActiveScene().name == "Lose")
        {
            levelFailed = true;
        }

        if (SceneManager.GetActiveScene().name == "Win")
        {
            levelEnd = true;
        }

        if (mainMenu && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }

        if (levelEnd && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }

        if (levelFailed && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Game");
        }

    }
}