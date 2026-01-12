using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public bool IsFinsh = false;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Finish"))
        {
            IsFinsh = true;
        }
    }
}