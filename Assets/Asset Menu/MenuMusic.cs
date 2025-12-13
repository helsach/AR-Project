using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        if (!audio.isPlaying)
            audio.Play();
    }
}
