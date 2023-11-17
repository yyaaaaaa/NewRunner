using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    [SerializeField] private float maxScale;
    private float currScale = 1f;
    public Animator animator;
    public Material heromat;
    [SerializeField] Color colorchange;
    private Color black = new (0.5f, 0.4f, 0.1f);
    private Color defaultcolor = new (1.0f, 0.8f, 0.4f);
    private Camera mainCam;

    public void Initilize()
    {
        mainCam = Camera.main;
        gameObject.SetActive(true);
        Reset();
    }
    public void ChangeScale(Vector3 change)
    {
        if (currScale <= maxScale)
        {
            transform.localScale += change;
            currScale = transform.localScale.x;
            transform.position +=  new Vector3(0, change.x, 0);
            mainCam.GetComponent<FolowPlayer>().ChangeVector(change);
        }
        else
        {
            transform.localScale = new Vector3(maxScale,maxScale,maxScale);
            currScale = maxScale;
        }
        if (currScale <= 0f)
        {
            UIManager.instance.LoseLevel();
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
        animator.SetBool("isPlaying", false);
        heromat.color = defaultcolor;
        mainCam.GetComponent<FolowPlayer>().Reset();

    }

    public void ChangeColor(bool darker)
    {
        if (darker && heromat.color.r >= black.r)
        {
            heromat.color = new Color(heromat.color.r - colorchange.r, heromat.color.g - colorchange.g, heromat.color.b - colorchange.b);
        }
    }
}
