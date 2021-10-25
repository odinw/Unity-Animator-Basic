using System.Collections.Generic;
using UnityEngine;

public class CoinPanelCtl : MonoBehaviour
{
    [SerializeField] CoinCtl CoinCtl;
    [SerializeField] List<GameObject> PlanelCoins;
    List<int> Coins = new List<int>();

    void OnEnable()
    {
        // 重置
        Coins = new List<int>();
        PlanelCoins.ForEach(c => c.SetActive(true));
    }

    public void Select(int number)
    {
        if (Coins.Count >= 4 )
            throw new System.Exception();

        // 許可選擇
        CheckType(number);
        Coins.Add(number);

        if (Coins.Count >= 4)
        {
            // 滿 4 個就自動關閉面版
            gameObject.SetActive(false);

            // 更先籌碼選單
            CoinCtl.ChangeCoin(Coins);
        }
    }

    void CheckType(int number)
    {
        switch (number)
        {
            case 100:
            case 500:
            case 2000:
            case 5000:
            case 10000:
            case 50000:
            case 100000:
            case 200000:
                break;

            default:
                throw new System.ArgumentOutOfRangeException();
        }
    }

}
