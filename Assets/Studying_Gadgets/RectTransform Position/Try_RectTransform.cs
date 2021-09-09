using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class Try_RectTransform : MonoBehaviour
{
    RectTransform _rectTransform;

    void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        Debug.Log($"{nameof(Try_RectTransform)} at ({ _rectTransform.anchoredPosition.x}, { _rectTransform.anchoredPosition.y})");
    }

    public void RandomPosition()
    {
        var x = Random.Range(-100, 100);
        var y = Random.Range(-100, 100);
        _rectTransform.anchoredPosition = Vector2.zero;
        _rectTransform.anchoredPosition = new Vector2(x, y);

        Debug.Log($"{nameof(Try_RectTransform)} at ({ _rectTransform.anchoredPosition.x}, { _rectTransform.anchoredPosition.y})");
    }
}
