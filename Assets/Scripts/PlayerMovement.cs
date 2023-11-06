using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 4f;
    
    private void Update()
    {
        if (UIManager.instance.isPlaying)
        {
            transform.position += new Vector3(0f, 0f, speed) * Time.deltaTime;
        }
    }
}
