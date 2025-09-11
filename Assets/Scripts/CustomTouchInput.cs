using UnityEngine;

public class CustomTouchInput : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public int PageNumber;
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private Vector2 initialTouchPosition1;
    private Vector2 initialTouchPosition2;

    void Update()
    {


        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPosition = Input.GetTouch(0).position;
        }

        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if (endTouchPosition.x > startTouchPosition.x + 200 && endTouchPosition.y > startTouchPosition.y + 40)
                Debug.Log("Swipe right");
            if (endTouchPosition.x < startTouchPosition.x - 200 && endTouchPosition.y > startTouchPosition.y - 40)
                Debug.Log("Swipe left");
        }

        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);
            initialTouchPosition1 = touch1.position - touch1.deltaPosition;
            initialTouchPosition2 = touch2.position - touch2.deltaPosition;

            float distanceDelta = (initialTouchPosition1 - initialTouchPosition2).magnitude;
            float currentDistance = (touch1.position - touch2.position).magnitude;
                if (currentDistance > distanceDelta)
                    Debug.Log("Gesture increase");
                else if (currentDistance < distanceDelta)
                Debug.Log("Gesture decrease");
        }
    }
}
