using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = FindObjectOfType<BlockSpawner>().Score.ToString("0");

    }
}
