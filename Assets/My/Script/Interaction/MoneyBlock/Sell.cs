using UnityEngine;

public class Sell : MonoBehaviour
{
    [SerializeField] private PlayerBalance _playerbalance;
    [SerializeField] private VRSpawnButton _spawnButton;
    private void OnTriggerEnter(Collider other)
    {
        Price item = other.GetComponent<Price>();
        if (item != null)
        {
            PlayerBalance wallet = _playerbalance;
            wallet.Addmoney(item.price);
            _spawnButton.spawned -= 1;
            Destroy(other.gameObject);
        }
    }
}
