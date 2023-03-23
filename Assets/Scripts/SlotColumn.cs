using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotColumn : MonoBehaviour
{
    [SerializeField] private float waitTime = 0.05f;
    [SerializeField] private List<SlotObject> slotObjects = new List<SlotObject>();

    public void Spin()
    {
        StartCoroutine(SpinCoroutine());
    }


    private IEnumerator SpinCoroutine()
    {
        for (int i = 0; i < 21; i++)
        {
            // slotObjects[slotObjects.Count-1].transform.SetSiblingIndex(0);
            transform.GetChild(transform.childCount - 1).transform.SetSiblingIndex(0);
            yield return new WaitForSeconds(waitTime);
        }
    }
}