using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject winPanel;
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private TimerController timerCon;
    [SerializeField] private FinishTrigger finishTrigger;

    void Update()
    {
        if(timerCon.timer <= 0)
        {
            pauseButton.SetActive(false);
            timerCon.IsPaused();
            losePanel.SetActive(true);
        }
        if (finishTrigger.IsFinsh == true)
        {
            timerCon.IsPaused();
            pauseButton.SetActive(false);
            winPanel.SetActive(true);
        }
    }
}
