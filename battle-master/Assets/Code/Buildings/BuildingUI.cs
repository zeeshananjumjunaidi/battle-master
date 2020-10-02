using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingUI : MonoBehaviour
{
    public Building BuildingPrefab;

    public TextMeshProUGUI BuildingName;
    public TextMeshProUGUI BuildingDescription;
    public TextMeshProUGUI BuildingCost;
    public Image Image;
    // Start is called before the first frame update
    void Start()
    {
        if (BuildingPrefab != null)
        {
            if (BuildingName != null)
            {
                BuildingName.text = BuildingPrefab.Name;
            }
            if (Image != null)
            {
                Image.sprite = BuildingPrefab.Image;
            }
            if (BuildingDescription != null)
            {
                BuildingDescription.text = BuildingPrefab.Description;
            }
            if (BuildingCost != null)
            {
                BuildingCost.text = Beautify.GetAmountWithCurrency(BuildingPrefab.Cost);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowDetails()
    {
        if (BuildingName != null)
        {
            BuildingName.gameObject.SetActive(true);
            Invoke("HideDetails",3);
            GameManager.Instance.Constructor.SelectedBuildingBlueprint = this;
        }
    }
    void HideDetails()
    {
        BuildingName.gameObject.SetActive(false);
    }
}
