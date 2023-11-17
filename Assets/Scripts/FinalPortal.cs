using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPortal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UIManager.instance.CompleteLevel();
    }
}
