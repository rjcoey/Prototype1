using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
