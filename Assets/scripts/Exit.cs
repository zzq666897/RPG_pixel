using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    [SerializeField] string areaToLoad;

    public string areaTransitionName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Player_controller.instance.areaTrasitionName = areaTransitionName;

            SceneManager.LoadScene(areaToLoad);

           
        }
    }
}
