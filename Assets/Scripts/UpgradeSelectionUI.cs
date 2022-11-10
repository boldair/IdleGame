using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSelectionUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Transform btnTemplate = transform.Find("btnTemplate");
        btnTemplate.gameObject.SetActive(false);

        UpgradeListSO upgradeListSO = Resources.Load<UpgradeListSO>(typeof(UpgradeListSO).Name);

        foreach(var upgradeType in upgradeListSO.upgradeSOList)
        {
            Transform btnTransform = Instantiate(btnTemplate, transform);
            btnTransform.gameObject.SetActive(true);

            btnTransform.Find("image").GetComponent<Image>().sprite = upgradeType.sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
