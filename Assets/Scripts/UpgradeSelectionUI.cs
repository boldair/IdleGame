using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeSelectionUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

        Transform btnTemplate = transform.Find("btnTemplate");
        btnTemplate.gameObject.SetActive(false);

        Debug.Log(Resources.Load<UpgradeListSO>(typeof(UpgradeListSO).Name));
        UpgradeListSO upgradeListSO = Resources.Load<UpgradeListSO>(typeof(UpgradeListSO).Name);

        int index = 0;
        foreach(UpgradeSO upgradeType in upgradeListSO.upgradeSOList)
        {
            Transform btnTransform = Instantiate(btnTemplate, transform);
            btnTransform.gameObject.SetActive(true);

            //value affectation for the generator
            btnTransform.GetComponent<ResourceGenerator>().TimerMax = upgradeType.timer;
            btnTransform.GetComponent<ResourceGenerator>().CostBase = upgradeType.initialCost;
            btnTransform.GetComponent<ResourceGenerator>().InitialRevenue = upgradeType.initialRevenue;
            btnTransform.GetComponent<ResourceGenerator>().InitialProductivity = upgradeType.initialProductivity;
            btnTransform.GetComponent<ResourceGenerator>().CostMultiplier = upgradeType.costMultiplier;
            btnTransform.GetComponent<ResourceGenerator>().UpgradeSO = upgradeType;

            btnTransform.Find("image").GetComponent<Image>().sprite = upgradeType.sprite;

            float offsetAmount = -150f;
            btnTransform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, offsetAmount * index);
            btnTransform.Find("Name").GetComponent<TextMeshProUGUI>().text = upgradeType.name;
            btnTransform.Find("Cost").GetComponent<TextMeshProUGUI>().text = "Cost : " + upgradeType.initialCost;



            //button action listener 
            btnTransform.GetComponent<Button>().onClick.AddListener(() =>
            {
                btnTransform.GetComponent<ResourceGenerator>().UpdateCostAndProduction();
            });



            index++;
        }
    }


}
