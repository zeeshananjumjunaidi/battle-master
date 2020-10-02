using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building : MonoBehaviour, IBuildingBlueprint
{
    public int Id;
    public string Name;
    public string Description;
    public decimal Cost; // in $
    public string Tooltip;
    public BuildingType BuildingType;
    public Sprite Image;


    Renderer rend;

    public void Construct()
    {
        throw new System.NotImplementedException();
    }

    public void Damage(int value)
    {
        throw new System.NotImplementedException();
    }

    public bool Destroy()
    {
        throw new System.NotImplementedException();
    }

    public void Heal(int value)
    {
        throw new System.NotImplementedException();
    }

    public bool IsDestroyable()
    {
        throw new System.NotImplementedException();
    }

    public bool IsPlaceable(Vector3 position, Vector3 rotation, Vector3 size)
    {
        throw new System.NotImplementedException();
    }

    public bool Place(Vector3 position, Vector3 rotation)
    {
        throw new System.NotImplementedException();
    }

    public bool ReadyToUse()
    {
        throw new System.NotImplementedException();
    }

    Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        rend = GetComponentInChildren<Renderer>();
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                targetPosition = new Vector3(hit.point.x, transform.position.y,
                    hit.point.z);
                transform.position = targetPosition;
            }
        }
    }

    private void OnMouseDrag()
    {
        rend.material.color -= Color.white * Time.deltaTime;
       
    }


}
