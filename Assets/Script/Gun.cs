using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    private int lives=3;
    public Text life;
    public AudioSource pew;
    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        transform.position = mousePos;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("bang");

            Fire();
            pew.Play();

        }
        if (lives == 0)
        {
            SceneManager.LoadScene("Lose");

        }
    }
    void Fire()
    {
        DuckMove[] flock = FindObjectsOfType<DuckMove>();

        foreach (DuckMove duck in flock)
        {
            float aimAssist = Vector3.Distance(transform.position, duck.transform.position);

            if (aimAssist < 2)
            {
                Debug.Log("bang");
                ScoreText.Instance.AddScore(100);
                duck.Shot();
            }
            else
            {
                lives--;
                life.text = ""+lives;
            }
        }


    }

}
