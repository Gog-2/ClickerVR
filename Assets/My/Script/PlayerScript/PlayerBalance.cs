using UnityEngine;
using TMPro;
using DG.Tweening;

public class PlayerBalance : MonoBehaviour
{
    [SerializeField] private int _money = 0;
    [SerializeField] private TextMeshPro _textMesh;

    void Start()
    {
        _textMesh.text = $"Balance: {_money}";
    }

    public void Addmoney(int amount)
    {
        _money += amount;
        Debug.Log($"Баланс игрока: {_money}");
        DOTween.To(() => _money, x =>
        {
            _money = x;
            _textMesh.text = $"Balnce: {_money}";
        }, _money, 0.5f).SetEase(Ease.OutCubic);
        
    }
    public bool CheckPriceAndBuy(int price)
    {
        if (_money >= price)
        {
            _money -= price;
            return true;
        }
        else
        {
        return false;
        }
    }
}
