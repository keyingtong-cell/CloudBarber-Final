using UnityEngine;

public class BobUpDown : MonoBehaviour
{
    public float amplitude = 0.2f;  // 抖动幅度（上下各 0.2 米）
    public float speed = 2f;        // 抖动速度

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * speed) * amplitude;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}
