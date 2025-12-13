using UnityEngine;
using UnityEngine.SceneManagement;

public class BackHandler : MonoBehaviour
{
    void Update()
    {
        // Deteksi tombol back Android
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            HandleBack();
        }
    }

    public void HandleBack()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == "MainMenu")
        {
            // Back di Main Menu → keluar aplikasi
            Application.Quit();
        }
        else
        {
            // Back di scene lain → kembali ke Main Menu
            SceneManager.LoadScene("MainMenu");
        }
    }
}
