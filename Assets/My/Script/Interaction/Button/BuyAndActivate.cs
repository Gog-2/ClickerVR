using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BuyAndActivate : MonoBehaviour
{
    [SerializeField] private int _buyprice = 100;
    [SerializeField] private TextMeshPro _TextPrice;
    [SerializeField] private PlayerBalance _balance;
    [SerializeField] private GameObject _turnItem;
    private bool _buyAlvileble = true;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable interactable;

    void Awake()
    {
        interactable = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnPressed);
    }
    void Start()
    {
        _TextPrice.text = $"cost: {_buyprice}";
    }
    private void OnPressed(SelectEnterEventArgs args)
    {
        if (_balance.CheckPriceAndBuy(_buyprice) && _buyAlvileble)
        {
            _turnItem.SetActive(true);
            _TextPrice.color = Color.green;
        }
    }

}
