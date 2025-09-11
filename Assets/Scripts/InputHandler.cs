using UnityEngine;

public class InputHandler : MonoBehaviour
{

    private void Update()
    {
        Debug.Log(GetTouchDeltaPosition() + "Delta position");
    }

    public bool IsTouchOnScreen()
    {
        if (Input.touchCount > 0) return true;
        else return false;
    }

    public Vector2 GetTouchDeltaPosition()
    {
        if(Input.touchCount > 0)
        {
            return Input.GetTouch(0).deltaPosition;
        }
        return Vector2.zero;
    }
    
}
