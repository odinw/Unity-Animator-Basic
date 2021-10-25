using System.Collections.Generic;
using UnityEngine;

public class CoinCtl : MonoBehaviour
{
    [SerializeField] List<Coin> Coins;

    List<int> CoinSetting = new List<int>();

    void Start()
    {
        // 依分區修改預設值
        CoinSetting = new List<int>
        {
            100, 500, 2000, 5000
        };

        for (int i = 0; i < Coins.Count; i++)
        {
            if (i == 0)
                Coins[i].Init(true, CoinSetting[i]);
            else
                Coins[i].Init(false, CoinSetting[i]);
        }
    }


    public void ChangeCoin(List<int> numbers)
    {
        CoinSetting = numbers;

        numbers.Sort();
        // chk
        numbers.ForEach(n => Debug.Log(n));

        for (int i = 0; i < Coins.Count; i++)
        {
            if (i == 0)
                Coins[i].Init(true, CoinSetting[i]);
            else
                Coins[i].Init(false, CoinSetting[i]);
        }
    }

    /* for Chip.cs */
    public void Select()
    {
        //Chips.ForEach(chip => chip.Interactable(false));
        Coins.ForEach(chip => chip.Switch());
    }

    /* for test */
    public void Interactable(bool interactable)
    {
        Coins.ForEach(chip => chip.Interactable(interactable));
    }
}