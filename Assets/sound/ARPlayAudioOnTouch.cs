using UnityEngine;

public class ARPlayAudioOnTouch : MonoBehaviour
{
    public Camera arCamera;            // drag ARCamera dari hierarchy
    public AudioClip audioClip;        // audio narasi pulau ini

    private static AudioSource globalAudioSource; // audio player yang dipakai semua pulau

    void Start()
    {
        // buat audio source global kalau belum ada
        if (globalAudioSource == null)
        {
            GameObject audioPlayer = new GameObject("GlobalAudioSource");
            globalAudioSource = audioPlayer.AddComponent<AudioSource>();
            globalAudioSource.playOnAwake = false;
        }
    }

    void Update()
    {
        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            Ray ray = arCamera.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform)
                {
                    PlayAudio();
                }
            }
        }
    }

    void PlayAudio()
    {
        if (audioClip == null) return;

        // hentikan audio sebelumnya (jika ada)
        if (globalAudioSource.isPlaying)
        {
            globalAudioSource.Stop();
        }

        // mainkan audio baru
        globalAudioSource.clip = audioClip;
        globalAudioSource.Play();
    }
}
