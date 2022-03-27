using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _seconds;

    private Slider _slider;

    private void OnEnable()
    {
        _slider = GetComponent<Slider>();
    }

    public void UpdateValue()
    {
        _slider.DOValue(_player.Health, _seconds);
    }
}
