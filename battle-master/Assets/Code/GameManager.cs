using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    public Building SelectedBuilding { get; internal set; }

    public BuildingConstructor Constructor;
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.SelectedBuilding!=null)
        {
        }
    }
}
