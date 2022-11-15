using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils : MonoBehaviour
{
    public static Utils Instance{ get; private set; }

    public bool CanBuy(double cost)
    {
        return GlobaStats.Instance.NbResources >= cost;
    }


}
