using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] bool goodItem = true;
    [SerializeField] float amount = 0.05f;
    [SerializeField] bool dark = false;
    [SerializeField] float rotationSpeed = 1f;
    private void OnTriggerEnter(Collider other)
    {
        PlayerLogic player = other.GetComponent<PlayerLogic>();
        ItemAction(player);
    }
    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
    }

    private void ItemAction(PlayerLogic player)
    {
        CheckScale(player);
        CheckColor(player);
        Destroy(gameObject);       
    }

    private void CheckScale(PlayerLogic player)
    {
        if (goodItem)
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