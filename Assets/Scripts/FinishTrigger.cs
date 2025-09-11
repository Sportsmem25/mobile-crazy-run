using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public bool _isFinsh = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            _isFinsh = true;
        }
    }
}
