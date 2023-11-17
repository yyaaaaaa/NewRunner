using UnityEngine;
public class PlayerInput : MonoBehaviour
{

    private void Update()
    {
        if (UIManager.instance.isPlaying)
        {
             if (Input.touchCount != 0)
            {
                HandleMovement();
            }
        }        
    }

    private void HandleMovement()
    {
        var touchDeltaPoistion = Input.GetTouch(0).deltaPosition.x;
        var offset = transform.position;

        offset.x += touchDeltaPoistion * Time.deltaTime * 0.3f;
        offset.x = Mathf.Clamp(offset.x, -2f, 2f);

        transform.position = offset;
    }
}
