using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBlueprint : MonoBehaviour
{

    RaycastHit hit;
    Vector3 currentPos;
    public GameObject prefab;
    private bool CanPlace = true;
    private float offset = 0;
    public static BuildBuilding CurrentlySelected;

    private int increment = 45;
    // Start is called before the first frame update
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50000.0f, (1 << 8)))
        {
            transform.position = hit.point;
        }
        currentPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50000.0f, (1 << 8)))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y + offset
                , hit.point.z);
        }
        if (CanPlace && Input.GetMouseButton(0))
        {
            Instantiate(prefab, transform.position, transform.rotation);
            Destroy(gameObject);
            CurrentlySelected = null;
        }
        if (Input.GetMouseButton(1))
        {
            CurrentlySelected = null;
            Destroy(gameObject);
        }
        bool isShiftDown = false;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isShiftDown = true;
        }
        if (isShiftDown)
        {
            if (Input.GetKey(KeyCode.E))
            {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x,
                 Mathf.Round(transform.eulerAngles.y / increment) * increment, transform.eulerAngles.z);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                transform.eulerAngles = new Vector3(transform.eulerAngles.x,
               Mathf.Round(transform.eulerAngles.y / increment) * increment, transform.eulerAngles.z);
            }
        }
        else
        {

            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.up);
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(-Vector3.up);
            }

            }
    }

    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.layer);
        CanPlace = other.gameObject.layer != 9;
        if (other.gameObject.layer == 9)
        {
            print("overlap " + other.transform.localScale + " " + other.transform.lossyScale);
            offset = 0;// other.transform.localScale.y;       
        }
    }
    private void OnTriggerExit(Collider other)
    {

        print("off " + other.gameObject.layer);
        CanPlace = other.gameObject.layer == 9;
        if (other.gameObject.layer == 9)
        {
            print("no overlap");
            offset = 0;
        }
    }
}
