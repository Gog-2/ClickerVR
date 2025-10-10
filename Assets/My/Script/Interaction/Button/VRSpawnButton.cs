using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRSpawnButton : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private int _blockLimit = 10;
    public int spawned = 0;
    private float _timer;
    [SerializeField] private int coldown = 1;
    private int queue = 0;

    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnPressed);
    }

    private void OnPressed(SelectEnterEventArgs args)
    {
        if (spawned <= _blockLimit)
        {
            spawned += 1;
            queue++;
        }
    }
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= coldown && queue > 0)
        {
            Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
            queue--;
        }
    }
}
