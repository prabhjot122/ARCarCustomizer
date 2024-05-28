using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    private Vector2 startTouchPosition, endTouchPosition;
    private bool stopTouch = false;

    public float swipeRange = 50f; // Minimum swipe distance to be considered a swipe
    public float rotationSpeed = 1.0f; // Speed of rotation

    void Update()
    {
        Swipe();
    }

    void Swipe()
    {
        if (Input.touchCount > 0 && !stopTouch)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startTouchPosition = touch.position;
                    break;

                case TouchPhase.Moved:
                    endTouchPosition = touch.position;
                    break;

                case TouchPhase.Ended:
                    endTouchPosition = touch.position;

                    if (Mathf.Abs(endTouchPosition.x - startTouchPosition.x) > swipeRange)
                    {
                        if (endTouchPosition.x < startTouchPosition.x)
                        {
                            RotateModel(-1); // Swipe left
                        }
                        else if (endTouchPosition.x > startTouchPosition.x)
                        {
                            RotateModel(1); // Swipe right
                        }
                    }
                    stopTouch = true;
                    break;
            }
        }

        if (Input.touchCount == 0)
        {
            stopTouch = false;
        }
    }

    void RotateModel(int direction)
    {
        // Assuming your car model is attached to this script
        transform.Rotate(Vector3.up, direction * rotationSpeed * Time.deltaTime);
    }
}
