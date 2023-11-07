using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPortal : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UIManager.instance.CompleteLevel();
    }
}
