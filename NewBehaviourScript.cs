using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //здоровье NPC
    public int health = 5;

    //уровень NPC
    public int level = 1;

    //скорость NPC
    public float speed = 1.2f;
    void Start()
    {
        health += level;
        print("Здоровье:" + health);
    }
       
    void Update()
    {
        
    }
}
