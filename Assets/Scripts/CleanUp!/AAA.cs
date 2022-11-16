/*what you need to do
 * ตั้งค่าเลือดให้เสร็จ
 * สร้างอาวุธ
 * timer
 * decorate
 * collision stay -> sphere dragger
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AAA : MonoBehaviour
{
    [SerializeField] private float time;

    [SerializeField] private TMP_Text number;

    private void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {

        }

        number.text = time.ToString();
    }
}