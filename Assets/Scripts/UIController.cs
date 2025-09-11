using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private TimerController timerCon;
    [SerializeField] private FinishTrigger ft;

    void Update()
    {
        if(timerCon.timer <= 0)
        {
            pauseButton.SetActive(false);
            timerCon.IsPaused();
            losePanel.SetActive(true);
        }
        if (ft._isFinsh == true)
        {
            timerCon.IsPaused();
            pauseButton.SetActive(false);
            winPanel.SetActive(true);
        }
    }
}
