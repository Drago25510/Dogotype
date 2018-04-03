using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeHelper : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void GetTap(int damage)
    {
        int health = Health - damage;
     
               if (health <= 0)
        {

            Health = MaxHealth;
            
        }

        Health = health;
        Debug.Log("Health - " + Health);

    }

}
