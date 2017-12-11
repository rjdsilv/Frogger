using UnityEngine;

public class FrogMovement : MonoBehaviour
{
    // Public attributes.
    public float movementSize = 0;
    public float speed = 0;

    // Constants.
    const float MAX_X = 8.64f;
    const float MAX_Y = 4.1f;
    const float MIN_X = -8.64f;
    const float MIN_Y = -4.54f;

    // Private attributes.
    private float rotationAngle = 180;
    private Vector3 newPos;
    private Animator animator;

    // Use this for initialization
    private void Start ()
    {
        newPos = transform.position;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update ()
    {
		if (IsRight())
        {
            rotationAngle = 90;
            newPos = new Vector3(Mathf.Clamp(newPos.x + movementSize, MIN_X, MAX_X), newPos.y, 0);
            animator.SetTrigger("ButtonPressed");
        }
        else if (IsLeft())
        {
            newPos = new Vector3(Mathf.Clamp(newPos.x - movementSize, MIN_X, MAX_X), newPos.y, 0);
            rotationAngle = -90;
            animator.SetTrigger("ButtonPressed");
        }
        else if (IsUp())
        {
            newPos = new Vector3(newPos.x, Mathf.Clamp(newPos.y + movementSize, MIN_Y, MAX_Y), 0);
            rotationAngle = 180;
            animator.SetTrigger("ButtonPressed");
        }
        else if (IsDown())
        {
            newPos = new Vector3(newPos.x, Mathf.Clamp(newPos.y - movementSize, MIN_Y, MAX_Y), 0);
            rotationAngle = 0;
            animator.SetTrigger("ButtonPressed");
        }

        transform.position = Vector3.MoveTowards(transform.position, newPos, speed);
        transform.eulerAngles = new Vector3(0, 0, rotationAngle);
    }

    private bool IsRight()
    {
        return Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
    }

    private bool IsLeft()
    {
        return Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
    }

    private bool IsUp()
    {
        return Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);
    }

    private bool IsDown()
    {
        return Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow);
    }
}
