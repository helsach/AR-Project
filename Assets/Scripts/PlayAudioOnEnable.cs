using UnityEngine;

public class PlayAudioOnEnable : MonoBehaviour
{
    public AudioClip audioClip;
    private static AudioSource globalAudio;

    void Awake()
    {
        if (globalAudio == null)
        {
            GameObject go = new GameObject("GlobalAudioSource");
            globalAudio = go.AddComponent<AudioSource>();
            globalAudio.playOnAwake = false;
        }
    }

    void OnEnable()
    {
        if (audioClip == null) return;

        globalAudio.Stop();
        globalAudio.clip = audioClip;
        globalAudio.Play();
    }
}
