using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timeDuration = 3f * 60f;

    private float timer;

    private TextMeshProUGUI firstMinute;
    private TextMeshProUGUI secondMinute;
    private TextMeshProUGUI separator;
    private TextMeshProUGUI firstSecond;
    private TextMeshProUGUI secondSecond;
}
