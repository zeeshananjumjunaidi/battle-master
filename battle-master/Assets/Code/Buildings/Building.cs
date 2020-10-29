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

    public bool Selected = false;
    public bool IsMine = false;
    Renderer rend;
    [Header("UI")]
    public GameObject SelectionUI;

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
        if (SelectionUI != null)
        {
            SelectionUI.SetActive(Selected);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Selected)
        {
            GameManager.Instance.SelectedBuilding = this;

        }
        else
        {
            if (GameManager.Instance.SelectedBuilding == this)
                GameManager.Instance.SelectedBuilding = null;

        }
    }

    private void OnMouseDrag()
    {

    }
    private void OnMouseDown()
    {
        if (GameManager.Instance.SelectedBuilding != null)
        {
            GameManager.Instance.SelectedBuilding.UnSelect();
        }
        Selected = !Selected;
        if (SelectionUI != null)
        {
            SelectionUI.SetActive(Selected);
        }

    }
    public void UnSelect()
    {
        Selected = false;
        if (SelectionUI != null)
        {
            SelectionUI.SetActive(Selected);
            GameManager.Instance.SelectedBuilding = null;
        }
    }

}
