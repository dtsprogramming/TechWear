using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    private void Awake()
    {
        GameObject newPrefab = Instantiate(prefab, prefab.transform.position, Quaternion.identity);
    }
}
