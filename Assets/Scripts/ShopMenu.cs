using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public static bool onMenu = false;
    public GameObject shopMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (onMenu)
            {
                offShop();
            }
            else
            {
                InShop();
            }
        }
    }

    void offShop()
    {
        shopMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        onMenu = false;
    }

    void InShop()
    {
        shopMenuUI.SetActive(true);
        Time.timeScale = 0.3f;
        onMenu = true;
    }
}
