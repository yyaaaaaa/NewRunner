using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] bool goodPortal = true;
    [SerializeField] float amount = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        PlayerLogic player = other.GetComponent<PlayerLogic>();
        PortalAction(player);      
    }
    private void PortalAction(PlayerLogic player)
    {
        if (goodPortal)
        {
            player.ChangeScale(new Vector3(amount, amount, amount));
        }
        else
        {
            player.ChangeScale(-new Vector3(amount, amount, amount));
        }
        Destroy(transform.parent.gameObject);
    }
}
