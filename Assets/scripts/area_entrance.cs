using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area_entrance : MonoBehaviour
{
    public string TransitionName;
    void Start()
    {
        if(TransitionName == Player_controller.instance.areaTrasitionName)
        {
            Player_controller.instance.transform.position = transform.position;
        }
    }

}
