using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class ButtonTextAnimation : MonoBehaviour
{
    [SerializeField] private GameObject _text;
    [SerializeField] private float _positionY;
    [SerializeField] private float _scale;
    [SerializeField] private float _seconds;

    private WaitForSeconds _sleep;

    private void OnEnable()
    {
        _sleep = new WaitForSeconds(_seconds);
    }

    public void Play()
    {
        StartCoroutine(SpawnText());
    }

    private IEnumerator SpawnText()
    {
        var item = Instantiate(_text, transform);
        item.transform.DOLocalMoveY(_positionY, _seconds);
        item.transform.DOScale(_scale, _seconds).SetEase(Ease.InCirc);

        yield return _sleep;

        Destroy(item);
    }
}
