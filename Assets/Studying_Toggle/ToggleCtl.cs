using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(ToggleGroup))]
public class ToggleCtl : MonoBehaviour
{
    ToggleGroup _toggleGroup;

    private void Start()
    {
        _toggleGroup = GetComponent<ToggleGroup>();
    }

    public void Who(int id)
    {
        Debug.Log(id);
    }
}
