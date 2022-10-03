using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class columngenerator : MonoBehaviour
{
    public int columnAmount = 5;
    private GameObject[] cols;
    public GameObject fab;
    private Vector2 position = new Vector2(-15f, -25f);
    private float spawn;
    public float rate = 4f;
    public float min = -1f;
    public float max = 3.5f;
    private float place = 10f;
    private int current = 0;


    
    void Start()
    {
        cols = new GameObject[columnAmount];
        for (int i = 0; i < columnAmount; i++)
        {
            cols[i] = (GameObject)Instantiate(fab, position, Quaternion.identity);
        }
    }

    
    void Update()
    {
        spawn += Time.deltaTime;

        if(PenguinConfig.inst.end == false && spawn >= rate)
        {
            spawn = 0;
            float placee = Random.Range(min, max);
            cols[current].transform.position = new Vector2(place, placee);
            current++;
            if (current >= columnAmount)
            {
                current = 0;
            }
        }
    }
}
