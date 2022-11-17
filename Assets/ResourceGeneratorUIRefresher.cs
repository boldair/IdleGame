using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceGeneratorUIRefresher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<ResourceGenerator>().OnCostChanged += ResourceGeneratorUIRefresher_OnCostChanged; ;
    }

    private void ResourceGeneratorUIRefresher_OnCostChanged(object sender, ResourceGenerator.OnCostChangedEventArgs e)
    {
        this.transform.Find("Cost").GetComponent<TextMeshProUGUI>().text = "Cost : " + e.costArgs.ToString("F0");

    }
}
                                                                                                                                                        