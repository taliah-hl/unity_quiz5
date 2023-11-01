using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageFade : MonoBehaviour
{
    private Image image;
    private void Awake() {
        image = GetComponent<Image>();
    }
    IEnumerator Fade(Color to, float duration, System.Action callback = null){
        // TODO: Lerp image alpha. This is a coroutine.
        yield return null; // ! You don't need to keep this line.
        // Hint
        // while(t < 1){
        //     image.color = Color.Lerp(from, to, t);
        //     yield return null;
        //     t = (Time.time - startTime) / duration;
        // }
    }
    public void SetColor(Color color){
        // TODO: Set image color.
    }
    public void StartFade(Color to, float duration, System.Action callback = null){
        // TODO: Restart fade coroutine.
    }
}
