using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] bool goodItem = true;
    [SerializeField] float amount = 0.05f;

    private void OnTriggerEnter(Collider other)
    {
        PlayerLogic player = other.GetComponent<PlayerLogic>();
        ItemAction(player);
    }
    private void ItemAction(PlayerLogic player)
    {
        if(goodItem )
        {
            player.ChangeScale(new Vector3 (amount, amount, amount));
        }
        else
        {
            player.ChangeScale(-new Vector3 (amount, amount, amount));
        }
        Destroy(gameObject);       
    }
}