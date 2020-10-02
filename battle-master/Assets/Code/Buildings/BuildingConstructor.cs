using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildingConstructor : MonoBehaviour
{
    BuildingUI _SelectedBuildingBlueprint;
    public BuildingUI SelectedBuildingBlueprint
    {
        get { return _SelectedBuildingBlueprint; }
        internal set
        {
            _SelectedBuildingBlueprint = value;
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        if (BuildingNameUI != null)
        {
            BuildingNameUI.text = SelectedBuildingBlueprint.BuildingPrefab.Name;
        }
        if (BuildingNameCost != null)
        {
            BuildingNameCost.text = Beautify.GetAmountWithCurrency(SelectedBuildingBlueprint.BuildingPrefab.Cost);
        }
    }
    private void ClearUI()
    {
        if (BuildingNameUI != null)
        {
            BuildingNameUI.text ="";
        }
        if (BuildingNameCost != null)
        {
            BuildingNameCost.text = "";
        }
    }

    [Header("UI")]
    public TextMeshProUGUI BuildingNameUI;
    public TextMeshProUGUI BuildingNameCost;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
