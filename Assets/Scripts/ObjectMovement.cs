using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed = 0;
    public Vector3 direction;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
	}
}
