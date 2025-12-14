using UnityEngine;
using UnityEngine.UIElements;

public class ItemSpawner : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject customerPrefab;
    public GameObject boosterPrefab;
    public SpriteRenderer background; // objekt se SpriteRendererem
    Vector2 bgSize;

    void Start()
    {
        bgSize = background.GetComponent<BackgroundSize>().Size;
        SpawnNew();
    }


    private void Spawn(Vector2 min, Vector2 max, GameObject obj)
    {
        float x = Random.Range(min.x, max.x);
        float y = Random.Range(min.y, max.y);

        Instantiate(obj, new Vector3(x, y, 0), Quaternion.identity);
    }

    public void SpawnNew()
    {
        // Získáme world space hranice sprite pozadí
        var min = background.bounds.min;
        var max = background.bounds.max;

        Spawn(min, max, itemPrefab);
        Spawn(min, max, customerPrefab);
        Spawn(min, max, boosterPrefab);
    }
}