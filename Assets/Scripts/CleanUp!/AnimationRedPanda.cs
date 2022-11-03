using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRedPanda : MonoBehaviour
{
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            _anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _anim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            _anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            _anim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            _anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            _anim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _anim.SetBool("Walk", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            _anim.SetBool("Walk", false);
        }
    }
}
