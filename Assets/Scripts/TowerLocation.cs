using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLocation : MonoBehaviour
{
    public GameObject towerPrefab;

    void OnMouseUpAsButton()
    {
        GameObject newTower = (GameObject)Instantiate(towerPrefab);
        newTower.transform.position = transform.position + Vector3.up;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
