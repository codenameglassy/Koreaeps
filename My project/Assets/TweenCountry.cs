using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenCountry : MonoBehaviour
{

    public RectTransform title, playBtn;
    public Vector2 titlePos;
    public Vector2 playBtnPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Tween());
    }

    IEnumerator Tween()
    {

        yield return new WaitForSeconds(1f);
        title.DOAnchorPos(titlePos, 1f).SetEase(Ease.OutBack);

        yield return new WaitForSeconds(3.5f);
        playBtn.DOAnchorPos(playBtnPos, 1f).SetEase(Ease.OutBack);
    }
}
