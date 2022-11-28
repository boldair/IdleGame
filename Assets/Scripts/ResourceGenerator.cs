using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceGenerator : MonoBehaviour
{
    private UpgradeSO upgradeSO;

    private float timer;
    private float timerMax;

    public event EventHandler<OnCostChangedEventArgs> OnCostChanged;

    public class OnCostChangedEventArgs : EventArgs
    {
        public double costArgs;
    }

    private float costMultiplier;
    private float costBase;
    private double cost;
    private float initialRevenue;
    private float initialProductivity;

    private float totalRevenue;

    public float TimerMax { get => timerMax; set => timerMax = value; }
    public float CostBase { get => costBase; set => costBase = value; }
    public float InitialRevenue { get => initialRevenue; set => initialRevenue = value; }
    public float InitialProductivity { get => initialProductivity; set => initialProductivity = value; }
    public UpgradeSO UpgradeSO { get => upgradeSO; set => upgradeSO = value; }
    public float CostMultiplier { get => costMultiplier; set => costMultiplier = value; }

    private void Start()
    {
        totalRevenue = 0;
        ChangeCost();
    }

    private void ChangeCost()
    {
        cost = CostBase * System.Math.Pow(CostMultiplier, GlobaStats.Instance.UpgradeNumberDictionary[UpgradeSO]);
        OnCostChanged?.Invoke(this, new OnCostChangedEventArgs { costArgs = cost });  ;
    }
    public void UpdateCostAndProduction()
    {

        if (Utils.Instance.CanBuy(cost))
        {
            GlobaStats.Instance.BuyUpgrade(UpgradeSO, cost);
            totalRevenue = (InitialProductivity * GlobaStats.Instance.UpgradeNumberDictionary[UpgradeSO]) * InitialRevenue;
            ChangeCost();
        }
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            GlobaStats.Instance.AddResources(totalRevenue);
            timer += TimerMax;
        }
    }
}
