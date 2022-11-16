using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearEnemy : MonoBehaviour
{
    [SerializeField] private FearBar fearbar;
    [SerializeField] float fearMax;
    private float fear;
    private float lessFear = 0;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Weapon")
        {
            fear += 1 * Time.deltaTime;
        }
    }

    private void Update()
    {
        fearbar.SetFearvalue(fear);

        if (fear >= fearMax)
        {
            fearbar.SetFearvalue(fearMax);
        }
    }

    private void Start()
    {
        fear = lessFear;
        fearbar.SetFearvalue(lessFear);
    }
}
