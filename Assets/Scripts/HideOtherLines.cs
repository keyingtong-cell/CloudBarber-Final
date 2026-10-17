using UnityEngine;

public class HideOtherLines : MonoBehaviour
{
    public GameObject line2; // 另外两条虚线,拖进来
    public GameObject line3;

    // 在 Button 的 OnClick 里调用这个方法
    public void OnLineClicked()
    {
        line2.SetActive(false);
        line3.SetActive(false);
    }
}
