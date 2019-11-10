
using UnityEngine;

public class Rotate : MonoBehaviour {

    // Use this for initialization
    public float rotateSpeed;
    public bool x;
    public bool y;
    public bool z;

    // Update is called once per frame
    void Update()
    {
        if (x)
        {
            transform.Rotate(rotateSpeed, 0, 0);
        }
        if (y)
        {
            transform.Rotate(0, rotateSpeed, 0);
        }
        if (z)
        {
            transform.Rotate(0, 0, rotateSpeed);
        }
    }
}
