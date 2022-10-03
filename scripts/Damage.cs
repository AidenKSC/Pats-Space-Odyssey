
using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{
  public int maxHealth = 5;
  public int curHealth = 5;

  public float healthBarLength;

  // Use this for initialization
  void Start()
  {
  healthBarLength = Screen.width / 2;
  }

  // Update is called once per frame
  void Update()
  {
  AddjustCurrentHealth(0);
  }

  void OnGUI()
  {
  GUI.Box(new Rect(10, 40, healthBarLength, 20), curHealth + "/" + maxHealth);
  }

  public void AddjustCurrentHealth(int adj)
  {
  curHealth += adj;

  if (curHealth < 0)
  curHealth = 0;

  if (curHealth > maxHealth)
  curHealth = maxHealth;

  if (maxHealth < 1)
  maxHealth = 1;

  healthBarLength = (Screen.width / 4) * (curHealth / (float)maxHealth);
  }

  public  void Die()
  {
      if (curHealth == 0) {
          gameObject.SetActive(false);
      }

  }


}
