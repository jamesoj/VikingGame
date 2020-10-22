using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public CharacterStats characterStats;
    public float currentHealth;
    public float maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        this.currentHealth = this.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
