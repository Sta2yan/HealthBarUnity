using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private SliderChanger _slider;

    public int _health = 100;
    private int _healCount = 10;
    private int _damage = 10;

    public int Health => _health;
    public int HealCount => _healCount;
    public int Damage => _damage;

    private void OnEnable()
    {
        _slider.UpdateValue(_health);
    }

    public void Heal()
    {
        if (_health < 100)
        {
            _health += _healCount;
            _slider.UpdateValue(_health);
        }
    }

    public void TakeDamage()
    {
        if (_health > 0)
        {
            _health -= _damage;
            _slider.UpdateValue(_health);
        }
    }
}
