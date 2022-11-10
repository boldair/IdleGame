using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/UpgradesList")]

public class UpgradeListSO : ScriptableObject
{
    public List<UpgradeSO> upgradeSOList;
}
