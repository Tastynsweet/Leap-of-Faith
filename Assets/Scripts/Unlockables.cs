using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[System.Serializable]
public class Upgrades
{
    public GameObject gameobj;
    [HideInInspector] public GameObject instance;
    public bool isUnlocked = false;
    public int faithPoints;
    public float passiveRate;
    public float faithRequired;

    public void Initialize(Transform parent = null)
    {
        if (gameobj != null)
        {
            instance = Object.Instantiate(gameobj, parent);
            instance.SetActive(false);
        }
    }

    public void Appear()
    {
        if (instance != null)
        {
            instance.SetActive(true);
        }
    }
}

public class Unlockables : MonoBehaviour
{
    public Upgrades[] upgradeLists;
    private int currentFaith;
    public ScoreCount scoreCount;

    void Start()
    {
        for (int i = 0 ; i < upgradeLists.Length; i++)
        {
            upgradeLists[i].Initialize();
        }
    }

    void Update()
    {
        currentFaith = scoreCount.GetFaithScore();
        for (int i = 0; i < upgradeLists.Length; i++)
        {
            if (!upgradeLists[i].isUnlocked && currentFaith >= upgradeLists[i].faithRequired)
            {
                upgradeLists[i].isUnlocked = true;
                upgradeLists[i].Appear();

                FaithProducer faithProducer = upgradeLists[i].instance.AddComponent<FaithProducer>();
                faithProducer.unlocks = upgradeLists[i];
                faithProducer.scoreCount = scoreCount;
            }
        }
    }
}
