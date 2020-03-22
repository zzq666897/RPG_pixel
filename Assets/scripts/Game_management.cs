using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_management : MonoBehaviour
{
    public static Game_management gamemanagement_instance;
   
    void Start()
    {
        if(gamemanagement_instance == null)
        {
            gamemanagement_instance = this;
        }else
        {
            Destroy(gameObject);
        }
    }

   
}
