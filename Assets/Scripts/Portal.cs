using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] bool goodPortal = true;
    [SerializeField] float amount = 0.1f;
    [SerializeField] bool dark = false; 
    private void OnTriggerEnter(Collider other)
    {
        PlayerLogic player = other.GetComponent<PlayerLogic>();
        PortalAction(player);      
    }
    private void PortalAction(PlayerLogic player)
    {
        CheckScale(player);
        CheckColor(player);
        Destroy(transform.parent.gameObject);
    }
    private void CheckScale(PlayerLogic player)
    {
        if (goodPortal)
        {
            player.ChangeScale(new Vector3(amount, amount, amount));
        }
        else
        {
            player.ChangeScale(-new Vector3(amount, amount, amount));
        }
    }

    private void CheckColor(PlayerLogic player)
    {
        player.ChangeColor(dark);
    }
}
