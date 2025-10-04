using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaithProducer : MonoBehaviour
{
    public Upgrades unlocks;
    public ScoreCount scoreCount;
    private float timer = 0;

    void Update()
    {
        if (!unlocks.isUnlocked) return;

        timer += Time.deltaTime;

        if (timer >= unlocks.passiveRate)
        {
            scoreCount.AddFaith(unlocks.faithPoints);
            timer = 0;
        }
    }
}