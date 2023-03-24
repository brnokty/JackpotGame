using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SlotColumn : MonoBehaviour
{
    public List<SlotObject> slotObjects = new List<SlotObject>();

    public void Spin(int spinCount)
    {
        StartCoroutine(SpinCoroutine(spinCount));
    }


    private IEnumerator SpinCoroutine(int spinCount)
    {
        for (int i = 0; i < spinCount; i++)
        {
            var randNumber = Random.Range(3, transform.childCount);
            var randomSlot = slotObjects[randNumber];
            slotObjects.RemoveAt(randNumber);
            slotObjects.Insert(0, randomSlot);
            randomSlot.transform.localPosition = new Vector3(0, 420);

            for (int j = 0; j < slotObjects.Count; j++)
            {
                slotObjects[j].transform.DOLocalMoveY(210 + (j * -210), JackpotGame.turnTime).SetEase(Ease.Linear);
            }

            yield return new WaitForSeconds(JackpotGame.waitTime + JackpotGame.turnTime);
        }
    }
}