using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Uirefresh : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUI;

    void Update()
    {
        textUI.text = "Resources " + GlobaStats.Instance.NbResources.ToString("F0");
    }
}
