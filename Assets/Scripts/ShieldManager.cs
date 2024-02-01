using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour
{
    public Image shieldBar;
    public float shieldAmount = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(20);
        }
    }



    public void TakeDamage(float damage)
    {
        shieldAmount -= damage;
        shieldBar.transform.localScale = new Vector3(shieldAmount / 100, 1, 1);
        //shieldBar.fillAmount = shieldAmount / 100f;
    }

    public void Recharge(float healingAmount)
    {
        shieldAmount += healingAmount;
        healingAmount = Mathf.Clamp(shieldAmount, 0, 100);
        shieldBar.transform.localScale = new Vector3(shieldAmount / 100, 1, 1);
        //shieldBar.fillAmount = shieldAmount / 100f;
    }
}
// Recharge to recover shields, note for later code.