using UnityEngine;

public class BackgroundSize : MonoBehaviour
{
    public Vector2 Size { get; private set; }

    void Awake()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Size = sr.bounds.size;   // <- skuteèná velikost v Unity jednotkách
    }
}