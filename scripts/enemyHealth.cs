using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public int curHealth = 50;

    public float healthBarLength;

    // Use this for initialization
    void Start()
    {
        //healthBarLength = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        AdjustCurrentHealth(0);
    }

    void OnGUI()
    {
        //GUI.Box(new Rect(10, 40, healthBarLength, 20), curHealth + "/" + maxHealth);
    }

    public void AdjustCurrentHealth(int adj)
    {
        curHealth += adj;
        //print(curHealth);

        if (curHealth < 0)
            curHealth = 0;

        if (curHealth > maxHealth)
            curHealth = maxHealth;

        if (maxHealth < 1)
            maxHealth = 1;

        if(curHealth == 0)
        {
            Destroy(gameObject);
        }

        //healthBarLength = (Screen.width / 4) * (curHealth / (float)maxHealth);
    }
}
