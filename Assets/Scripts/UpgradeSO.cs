using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/UpgradeType")]

public class UpgradeSO : ScriptableObject
{
    public string name;
    public float initialCost;
    public float costMultiplier;

    public float initialRevenue;
    public float initialProductivity;
    public float timer;

    public Sprite sprite;
}
