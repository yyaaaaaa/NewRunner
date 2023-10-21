using System;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    private void Update()
    {
        transform.position += new Vector3(0f, 0f, speed) * Time.deltaTime;

        if(Input.touchCount != 0) 
        {
            HandleMovement();
        }
    }

    private void HandleMovement()
    {
        var touchDeltaPoistion = Input.GetTouch(0).deltaPosition.x;
        var offset = transform.position;

        offset.x += touchDeltaPoistion * Time.deltaTime;
        offset.x = Mathf.Clamp(offset.x, -2f, 2f);

        transform.position = offset;
    }
}
