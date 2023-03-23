using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotMachine : MonoBehaviour
{
    [SerializeField] private float slotDelayTime = 0.3f;
    [SerializeField] private List<SlotColumn> slotColumns = new List<SlotColumn>();

    private Coroutine spinCoroutine;

    public void Spin()
    {
        if (spinCoroutine != null)
            StopCoroutine(spinCoroutine);
        spinCoroutine = StartCoroutine(SpinCoroutine());
    }


    private IEnumerator SpinCoroutine()
    {
        for (int i = 0; i < slotColumns.Count; i++)
        {
            slotColumns[i].Spin();
            yield return new WaitForSeconds(slotDelayTime);
        }
    }
}