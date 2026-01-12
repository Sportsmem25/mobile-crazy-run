using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    public float timer = 60f;
    [SerializeField] private MovementHandler mh;
    [SerializeField] private Text timerText;
    private bool _paused = true;
    
    void Start()
    {
        StartCoroutine(StartTimer());
    }

    private void Update()
    {
        if (_paused == true)
            mh.gameObject.SetActive(true);
        else
            mh.gameObject.SetActive(false);
    }

    private IEnumerator StartTimer()
    {
        while (timer > 0)

        {
            if(_paused == true)
            {
                timer -= Time.deltaTime;
                UpdateTimerText();
            }
            yield return null;
        }        
    }

    private void UpdateTimerText()
    {
        if (timer < 0)
            timer = 0;

        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void IsPaused()
    {
        _paused = !_paused;
    }

    public void RestartTimer()
    {
        StopCoroutine(StartTimer());
    }
}
