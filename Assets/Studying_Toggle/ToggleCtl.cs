using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ToggleGroup))]
public class ToggleCtl : MonoBehaviour
{
    [SerializeField] List<Toggle> Toggles;

    ToggleGroup _toggleGroup;

    private void Start()
    {
        _toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Who(int id)
    {
        Debug.Log(id);
        for (int i = 0; i < Toggles.Count; i++)
        {
            if (Toggles[i].isOn)
                Debug.Log($"isOn {i}");
        }
    }
}
