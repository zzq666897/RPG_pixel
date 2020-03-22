using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    private Rigidbody2D m_RGB;
    private Animator m_anim;

    public static Player_controller instance;

    public string areaTrasitionName;

    [SerializeField] float Speed;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
      
        DontDestroyOnLoad(gameObject);
        
        m_RGB = GetComponent<Rigidbody2D>();
        m_anim = GetComponentInChildren<Animator>();
    }

   
    void Update()
    {

        movement();
    }


    private void movement()
    {
        float moveInput_H = Input.GetAxisRaw("Horizontal");

        float moveInput_V = Input.GetAxisRaw("Vertical");

        m_RGB.velocity = new Vector2(moveInput_H * Speed, moveInput_V * Speed);

        m_anim.SetFloat("move_x", moveInput_V);
        m_anim.SetFloat("move_y", moveInput_H);


        if (moveInput_H == 1 || moveInput_V == -1 || moveInput_V == 1 || moveInput_H == -1)
        {
            m_anim.SetFloat("lastmove_x", moveInput_V);
            m_anim.SetFloat("lastmove_y", moveInput_H);
        }
    }
}
