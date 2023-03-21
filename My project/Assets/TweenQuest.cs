using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenQuest : MonoBehaviour
{
    public RectTransform coinRect, energyRect, nepalBtn, koreaBtn;
    public CanvasGroup fadeCanvas;
    public Vector2 coinPos, energyPos, nepalBtnPos, koreaBtnPos;

    // Start is called before the first frame update
    void Start()
    {
        fadeCanvas.alpha = 1f;
        StartCoroutine(Tween());
    }

    IEnumerator Tween()
    {
        fadeCanvas.DOFade(0, 3f);
        yield return new WaitForSeconds(1.5f);

        coinRect.DOAnchorPos(coinPos, 2f);
        energyRect.DOAnchorPos(energyPos, 2f);

        yield return new WaitForSeconds(1f);

        nepalBtn.DOAnchorPos(nepalBtnPos, 2f);
        koreaBtn.DOAnchorPos(koreaBtnPos, 2f);

    }
}
