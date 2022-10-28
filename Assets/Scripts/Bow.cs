using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public Rigidbody arrowModel;

    //กำหนดแรงสูงสุด-กำลังที่ใช้ง้าง-ง้างเร็วแค่ไหน
    public float maxPower;
    public float chargePower;
    public float chargeSpeed;

    public bool isCharge;
    void Update()
    {
        //click
        if(Input.GetMouseButtonDown(0))
        {
            isCharge = true;
        }

        //stillClick
        if(isCharge && chargePower <= maxPower)
        {
            chargePower += chargeSpeed * Time.deltaTime;
        }
        //leave
        if(isCharge && Input.GetMouseButtonUp(0))
        {
            Rigidbody shotArrow = Instantiate(arrowModel, transform.position, transform.rotation) as Rigidbody;
            shotArrow.AddForce(transform.forward * chargePower, ForceMode.Impulse);

            chargePower = 0f;
            isCharge = false;
        }
    }
}
