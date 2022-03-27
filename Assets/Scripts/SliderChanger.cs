using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private float _seconds;

    private Slider _slider;

    private void OnEnable()
    {
        _slider = GetComponent<Slider>();
    }

    public void UpdateValue(int value)
    {
        _slider.DOValue(value, _seconds);
    }
}
