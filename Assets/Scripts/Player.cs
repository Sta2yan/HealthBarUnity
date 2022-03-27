using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _healthChanged;

    private int _health = 100;
    private int _healCount = 10;
    private int _damage = 10;

    public int Health => _health;

    private void OnEnable()
    {
        _healthChanged?.Invoke();
    }

    public void Heal()
    {
        if (_health < 100)
        {
            _health += _healCount;
            _healthChanged?.Invoke();
        }
    }

    public void TakeDamage()
    {
        if (_health > 0)
        {
            _health -= _damage;
            _healthChanged?.Invoke();
        }
    }
}
