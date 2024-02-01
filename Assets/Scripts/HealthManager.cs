using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

   

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.transform.localScale = new Vector3(healthAmount/100, 1, 1);
        //healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount)
    {
        healthAmount += healingAmount;
        healingAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.transform.localScale = new Vector3(healthAmount/100, 1, 1);
        //healthBar.fillAmount = healthAmount / 100f;
    }
}
// Heal to recover health, note for later code.