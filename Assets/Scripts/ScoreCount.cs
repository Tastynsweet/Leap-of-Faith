using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    [SerializeField] private int faithCount;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            faithCount++;
        }
    }

    public int GetFaithScore()
    {
        return faithCount;
    }

    public void AddFaith(int faith)
    {
        faithCount = faith + faithCount;
    }
}
