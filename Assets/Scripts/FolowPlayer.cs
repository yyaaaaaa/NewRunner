using UnityEngine;

public class FolowPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, player.position.y + 3.5f, player.position.z - 10f);
    }
}
