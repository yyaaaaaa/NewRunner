using UnityEngine;

public class FolowPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    private Vector3 vector3 = new Vector3(0f, 7f,  10f);
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        transform.position = new Vector3(vector3.x, player.position.y + vector3.y, player.position.z - vector3.z);
    }

    public void ChangeVector(Vector3 change)
    {
        vector3 += new Vector3(0f, change.y, change.z);
    }

    public void Reset()
    {
        vector3 = new Vector3(0f, 7f, 10f);
    }
}
