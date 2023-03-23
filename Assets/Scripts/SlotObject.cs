using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SlotObject : MonoBehaviour
{
    public int slotObjectValue = 1;
    [SerializeField] private Image back;
    [SerializeField] private TextMeshProUGUI textMesh;

    private void Awake()
    {
        back.color = JackpotGame.GetColor(slotObjectValue);
        textMesh.text = slotObjectValue.ToString();
    }
}