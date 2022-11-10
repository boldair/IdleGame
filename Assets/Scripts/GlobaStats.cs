using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobaStats : MonoBehaviour
{

    public static GlobaStats Instance { get; private set; }
    public float NbResources { get => nbResources; set => nbResources = value; }
    public Dictionary<UpgradeSO, float> UpgradeNumberDictionary { get => upgradeNumberDictionary; set => upgradeNumberDictionary = value; }
    public int ClickUpgradeNumber { get => clickUpgradeNumber; set => clickUpgradeNumber = value; }

    private float nbResources;

    private Dictionary<UpgradeSO, float> upgradeNumberDictionary;
    private int clickUpgradeNumber;

    void Awake()
    {
        Instance = this;
        UpgradeNumberDictionary = new Dictionary<UpgradeSO, float>();

        UpgradeListSO upgradeTypeList = Resources.Load<UpgradeListSO>("ListOfUpgrades");

        clickUpgradeNumber = 1;

        foreach (UpgradeSO upgrade in upgradeTypeList.upgradeSOList)
        {
            UpgradeNumberDictionary[upgrade] = 0;
        }
    }


    public void AddResources(float resources)
    {
        NbResources += resources;
    }
}
