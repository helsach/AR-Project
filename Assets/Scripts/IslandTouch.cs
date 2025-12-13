using UnityEngine;

public class IslandTouch : MonoBehaviour
{
    [Header("Hit Areas")]
    public GameObject AreaSumatra;
    public GameObject AreaJawa;
    public GameObject AreaKalimantan;
    public GameObject AreaSulawesi;
    public GameObject AreaPapua;

    [Header("3D Rumah")]
    public GameObject RumahSumatra;
    public GameObject RumahJawa;
    public GameObject RumahKalimantan;
    public GameObject RumahSulawesi;
    public GameObject RumahPapua;

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        HideAll();
    }

    void Update()
    {
        // 🔒 BLOK TAP SAAT AUDIO MASIH MAIN
        AudioSource audio = FindObjectOfType<AudioSource>();
        if (audio != null && audio.isPlaying)
            return;

        if (Input.touchCount == 0)
            return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began)
            return;

        Ray ray = cam.ScreenPointToRay(touch.position);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.gameObject == AreaSumatra)
                ShowOnly(RumahSumatra);

            else if (hit.collider.gameObject == AreaJawa)
                ShowOnly(RumahJawa);

            else if (hit.collider.gameObject == AreaKalimantan)
                ShowOnly(RumahKalimantan);

            else if (hit.collider.gameObject == AreaSulawesi)
                ShowOnly(RumahSulawesi);

            else if (hit.collider.gameObject == AreaPapua)
                ShowOnly(RumahPapua);
        }
    }

    void HideAll()
    {
        RumahSumatra.SetActive(false);
        RumahJawa.SetActive(false);
        RumahKalimantan.SetActive(false);
        RumahSulawesi.SetActive(false);
        RumahPapua.SetActive(false);
    }

    void ShowOnly(GameObject target)
    {
        HideAll();
        target.SetActive(true);
    }
}
