using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] private float maxScale;
    private float currScale = 1f;
    public void ChangeScale(Vector3 change)
    {
        if (currScale <= maxScale)
        {
            transform.localScale += change;
            currScale = transform.localScale.x;
            transform.position +=  new Vector3(0, change.x, 0);
        }
        else
        {
            transform.localScale = new Vector3(maxScale,maxScale,maxScale);
            currScale = maxScale;
        }
    }
    public float GetScale()
    {
        return currScale;
    }

    public void Reset()
    {
        transform.position = new Vector3 (0, 0.65f, 0);
        transform.localScale = Vector3.one;
    }
}
