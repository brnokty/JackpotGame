using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


[Serializable]
public class MatrisColumn
{
    public SlotObject[] rows = new SlotObject[3];
}


public class SlotMachine : MonoBehaviour
{
    [SerializeField] private float slotDelayTime = 0.3f;
    [SerializeField] private List<SlotColumn> slotColumns = new List<SlotColumn>();
    public MatrisColumn[] matris = new MatrisColumn[5];

    private Coroutine spinCoroutine;

    public void Spin()
    {
        if (spinCoroutine != null)
            StopCoroutine(spinCoroutine);
        spinCoroutine = StartCoroutine(SpinCoroutine());
    }


    private IEnumerator SpinCoroutine()
    {
        int spinCount = JackpotGame.minRandomValue;
        for (int i = 0; i < slotColumns.Count; i++)
        {
            spinCount = Random.Range(spinCount, spinCount + JackpotGame.maxRandomDistanceValue);
            slotColumns[i].Spin(spinCount);
            yield return new WaitForSeconds(slotDelayTime);
        }
    }

    public void GetMatris()
    {
        for (int i = 0; i < slotColumns.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matris[i].rows[j] = slotColumns[i].slotObjects[j];
            }
        }
    }
}