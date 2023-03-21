using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GuiTween : MonoBehaviour
{

    [Header("Main")]
    public RectTransform title;
    public RectTransform playBtn;
    public CanvasGroup fadeCanvas;
    public CanvasGroup darkBg;
    public CanvasGroup frameBg;

    public Vector2 titlePos, playBtnPos;

    // Start is called before the first frame update
    void Start()
    {
        fadeCanvas.alpha = 1f;
        StartCoroutine(Main_Tween());
    }

    IEnumerator Main_Tween()
    {
        fadeCanvas.DOFade(0, 4f);
        yield return new WaitForSeconds(1f);

       /* darkBg.DOFade(1, 2f);
        yield return new WaitForSeconds(1f);*/

        frameBg.DOFade(1, 2f);
        yield return new WaitForSeconds(1f);

        title.DOAnchorPos(titlePos, 2f);
        yield return new WaitForSeconds(2f);
      

        playBtn.DOAnchorPos(playBtnPos, 1f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1.5f);
        title.transform.DOMove(new Vector2(title.transform.position.x, title.transform.position.y - 20f), 3f).SetLoops(-1, LoopType.Yoyo);
    }
}
