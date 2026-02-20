using UnityEngine;

public class WindmillBlades : MonoBehaviour
{
    public float speed;
    public float x;
    public float y;

    void Update()
    {
        transform.Rotate(x,y,speed);
    }
}