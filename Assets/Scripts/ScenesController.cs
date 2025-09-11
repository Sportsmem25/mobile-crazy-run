using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesController : MonoBehaviour
{
    [SerializeField] private int numberScene;

    /// <summary>
    /// Метод загружающий уровень
    /// </summary>
    public void LoadScene()
    {
        SceneManager.LoadScene(numberScene);
    }

    /// <summary>
    /// Метод загружающий стартовую сцену
    /// </summary>
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }

    /// <summary>
    /// Метод загружающий следующую сцену
    /// </summary>
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1 );
    }

    /// <summary>
    /// Метод перезагрузки сцены
    /// </summary>
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
