using UnityEngine;

public class ChangePrefab : MonoBehaviour
{
    [SerializeField] private GameObject _prefabChanged;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnedPrefab1"))
        {
            Vector3 pos = other.transform.position;
            Quaternion rot = other.transform.rotation;
            Instantiate(_prefabChanged, pos, rot);
            Destroy(other.gameObject);
        }
    }
}

