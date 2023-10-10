using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitItems : MonoBehaviour
{
    [SerializeField] private List<GameObject> items = null;

    [SerializeField] private UnitDistanceJoin unitDistancer = null;

    private void Awake()
    {
        unitDistancer = GetComponent<UnitDistanceJoin>();        
    }

    private void Start()
    {
        for(int i = 1; i < transform.childCount; i++)
        {
            GameObject item = transform.GetChild(i).gameObject;
            items.Add(item);     
        }   
    }


    private void Update()
    {
        if(unitDistancer.GetDistanceToTarget() <= unitDistancer.joinRadius)
        {
            ActivateItems();
        }
    }


    private void ActivateItems()
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].SetActive(true);
        }        
    }
}
