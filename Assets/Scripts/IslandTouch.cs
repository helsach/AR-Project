using UnityEngine;

public class IslandTouch : MonoBehaviour
{
    [Header("Hit Areas (Collider Objects)")]
    public GameObject AreaSumatra;
    public GameObject AreaJawa;
    public GameObject AreaKalimantan;
    public GameObject AreaSulawesi;
    public GameObject AreaPapua;

    [Header("3D House Models")]
    public GameObject RumahSumatra;
    public GameObject RumahJawa;
    public GameObject RumahKalimantan;
    public GameObject RumahSulawesi;
    public GameObject RumahPapua;

    Camera cam;

    void Start()
    {
        cam = Camera.main;

        // matikan semua rumah diawal
        RumahSumatra.SetActive(false);
        RumahJawa.SetActive(false);
        RumahKalimantan.SetActive(false);
        RumahSulawesi.SetActive(false);
        RumahPapua.SetActive(false);
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = cam.ScreenPointToRay(Input.touches[0].position);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // SUMATRA
                if (hit.collider.gameObject == AreaSumatra)
                {
                    ShowOnly(RumahSumatra);
                }

                // JAWA
                else if (hit.collider.gameObject == AreaJawa)
                {
                    ShowOnly(RumahJawa);
                }

                // KALIMANTAN
                else if (hit.collider.gameObject == AreaKalimantan)
                {
                    ShowOnly(RumahKalimantan);
                }

                // SULAWESI
                else if (hit.collider.gameObject == AreaSulawesi)
                {
                    ShowOnly(RumahSulawesi);
                }

                // PAPUA
                else if (hit.collider.gameObject == AreaPapua)
                {
                    ShowOnly(RumahPapua);
                }
            }
        }
    }

    void ShowOnly(GameObject target)
    {
        RumahSumatra.SetActive(false);
        RumahJawa.SetActive(false);
        RumahKalimantan.SetActive(false);
        RumahSulawesi.SetActive(false);
        RumahPapua.SetActive(false);

        target.SetActive(true);
    }
}
