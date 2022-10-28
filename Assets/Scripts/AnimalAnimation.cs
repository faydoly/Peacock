using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalAnimation : MonoBehaviour
{
    private Animator _anim;

    void Awake()
    {
        _anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _anim.SetBool("isWalk", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            _anim.SetBool("isWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            _anim.SetBool("isFly", true);
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            _anim.SetBool("isFly", false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _anim.SetBool("isRoll", true);
        }

        if (Input.GetKeyUp(KeyCode.R))
        {
            _anim.SetBool("isRoll", false);
        }
    }
}
