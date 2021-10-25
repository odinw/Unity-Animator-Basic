using System.Collections.Generic;
using UnityEngine;

public class Test_CoinCtl : MonoBehaviour
{
    [SerializeField] CoinCtl CoinCtl;
    [SerializeField] List<int> CoinSetting;

    public void ChangeCoin()
    {
        CoinCtl.ChangeCoin(CoinSetting);
    }

    public void Interactable(bool isOn)
    {
        CoinCtl.Interactable(isOn);
    }
}
