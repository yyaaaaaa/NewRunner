using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUnits : MonoBehaviour
{
    public List<Knight> knights = new List<Knight>();
    private void OnTriggerEnter(Collider other)
    {
        foreach (Knight knight in knights)
        {
            knight.Enable(other.transform);
        }
    }
}
