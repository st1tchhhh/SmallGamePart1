using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, 0f, v).normalized;
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
    }
}
