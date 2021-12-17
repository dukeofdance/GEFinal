using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private int count;
    private Text text;

    public static ScoreText Instance { get; private set; }

    private void Awake()
    {
        text = GetComponent<Text>();
        Instance = this;
    }

    public void AddScore(int value)
    {
        count += value;
        text.text = count.ToString();
    }
}
