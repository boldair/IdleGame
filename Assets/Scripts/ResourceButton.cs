using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceButton : MonoBehaviour
{
    public void OnClickAddResource()
    {
        GlobaStats.Instance.AddResources(GlobaStats.Instance.ClickUpgradeNumber);
    }
}
