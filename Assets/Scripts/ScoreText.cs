using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI faithText;
    public ScoreCount scoreCount;
    private int currentFaith;

    void Update()
    {
        currentFaith = scoreCount.GetFaithScore();
        faithText.text = "HOPE: " + currentFaith.ToString();
    }
}
