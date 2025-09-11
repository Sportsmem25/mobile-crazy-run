using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    public InputHandler iphan;
    [SerializeField] private float ballSpeed;

    void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if (iphan.IsTouchOnScreen())
        {
            Vector2 currentDeltaPos = iphan.GetTouchDeltaPosition();
            currentDeltaPos = currentDeltaPos * ballSpeed;
            Vector3 gravityVector = new Vector3(currentDeltaPos.x, Physics.gravity.y, currentDeltaPos.y);
            Physics.gravity = gravityVector;
        }
    }
}
