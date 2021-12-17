using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMove : MonoBehaviour
{
    // Start is called before the first frame update

    public float moveSpeed = 5f;

    float changeTimer = 1.5f;

    Vector3 direction = Vector3.up;
    public float timer = 0;



    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= changeTimer)
        {
            direction=ChangeDir();
        }
        transform.position += direction * moveSpeed * Time.deltaTime;
       
        if (!GetComponent<Renderer>().isVisible)
        {
            Shot();
        }
    }

    private Vector3 ChangeDir()
    {
        int randDir = Random.Range(0, 4);
        switch (randDir)
        {
            case 0:
                direction = Vector3.up;
                break;

            case 1:
                direction = Vector3.down;
                break;

            case 2:
                direction = Vector3.left;
                break;

            case 3:
                direction = Vector3.right;
                break;
        }
        return direction;
    }

    public void Shot()
    {
        DuckPool.Instance.AddToPool(gameObject);
    }
}
