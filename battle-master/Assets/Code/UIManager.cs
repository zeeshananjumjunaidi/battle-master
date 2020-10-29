using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Building UI")]
    public TextMeshProUGUI BuildingName;
    public TextMeshProUGUI BuildingCost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance!=null)
        {
            if (GameManager.Instance.SelectedBuilding!=null)
            {
                BuildingName.text = GameManager.Instance.SelectedBuilding.Name;
                BuildingCost.text = GameManager.Instance.SelectedBuilding.Cost.ToString();
            }
            else
            {
                BuildingName.text = "";
                BuildingCost.text = "";
            }
        }
    }
}
