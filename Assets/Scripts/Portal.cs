using System;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] bool goodPortal = true;
    private Vector3 change = new Vector3(0.1f, 0.1f, 0.1f);

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(TagManager.PLAYER_TAG))
        {
            GameObject player = other.gameObject;
            if (goodPortal)
            {
                GoodPortalAction(player);
            }
            else
            {
                BadPortalAction(player);
            }
        }
    }

    private void BadPortalAction(GameObject player)
    {
        player.transform.localScale -= change;
    }

    private void GoodPortalAction(GameObject player)
    {
        player.transform.localScale += change;
    }
}
