using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Tombol Keluar Aplikasi
    public void ExitButton()
    {
        Debug.Log("Game Closed");
        Application.Quit();
    }

    // Tombol OPEN → masuk ke scene AR
    public void OpenAR()
    {
        SceneManager.LoadScene("AR");
    }

    // Tombol QUIZ → masuk ke scene Quiz
    public void OpenQuiz()
    {
        SceneManager.LoadScene("Quiz");
    }

    // Fungsi fleksibel (opsional)
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
