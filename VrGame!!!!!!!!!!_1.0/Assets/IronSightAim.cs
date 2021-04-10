using UnityEngine;

public class IronSightAim : MonoBehaviour
{
    public Vector3 IronSight;
    public Vector3 HipFire;
    public float aimSpeed = 5;
    public GameObject Crosshair;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition,IronSight, aimSpeed * Time.deltaTime);
            Crosshair.SetActive(false);
        }
        if (Input.GetMouseButtonUp(1))
        {
            transform.localPosition = HipFire;
            Crosshair.SetActive(true);
        }
    }   

}
