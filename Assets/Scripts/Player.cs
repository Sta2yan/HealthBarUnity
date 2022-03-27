using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _healthChanged;

    private int _health = 100;
    private int _maximumHealth = 100;
    private int _minimumHealth = 0;
    private int _healCount = 10;
    private int _damage = 10;

    public int Health => _health;

    private void OnEnable()
    {
        _healthChanged?.Invoke();
    }

    public void Heal()
    {
        _health = Mathf.Clamp(_health, _minimumHealth, _maximumHealth) + _healCount;
        _healthChanged?.Invoke();
    }

    public void TakeDamage()
    {
         _health = Mathf.Clamp(_health, _minimumHealth, _maximumHealth) - _damage;
        _healthChanged?.Invoke();
    }
}
