using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Button))]
public class Coin : MonoBehaviour
{
    // 功能
    // 1. 圖片狀態的顯示 : 選取 / 未選取 / 不可選取
    // 2. OnClick : 透過 MyToggleCtl.cs 控制
    // 3. Click() 用 switch 依 number 更換圖片

    [Header("Check")]
    [SerializeField] int _number;

    [Header("Resource")]
    [SerializeField] Sprite Sprite_On; // 選取
    [SerializeField] Sprite Sprite_Off; // 未選取, 不可選取時，直接調整 Button.Interactable 為 false 即可

    Image _image;
    Button _button;
    //public UnityAction<int> Click;

    void Awake()
    {
        _image = GetComponent<Image>();
        _button = GetComponent<Button>();

        // *** 卡關，面額 int 傳不出去
        // var a =_button.onClick;
        //a.Invoke();
    }


    /* for this.Button.OnClick */

    public void Click()
    {
        Debug.Log($"select {_number}");
        StaticData.CoinSelected = _number;
        //Click.Invoke(_number);
    }

    /*  for ChipCtl.cs */

    public void Init(bool isOn, int number)
    {
        _image.sprite = isOn ? Sprite_On : Sprite_Off;
        _number = number;
    }

    public void Switch()
    {
        _image.sprite = _number == StaticData.CoinSelected ? Sprite_On : Sprite_Off;
    }

    public void Interactable(bool interactable)
    {
        _button.interactable = interactable;
    }


}
