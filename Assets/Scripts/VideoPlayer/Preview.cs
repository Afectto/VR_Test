using RenderHeads.Media.AVProVideo;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Preview : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Image image;
    private MediaReference _mediaReference;
    private Button _button;

    public void Initialize(VideoObject stats)
    {
        _button = GetComponentInChildren<Button>();
        _button.onClick.AddListener(NeedChangeVideo);
        
        text.text = stats.NameVideo;
        image.sprite = stats.Image;
        _mediaReference = stats.Video;
        
    }
    
    private void NeedChangeVideo()
    {
        EventManager.Instance.OnChangeVideo?.Invoke(_mediaReference, text.text);
    }

    public void ForceChangeVideo()
    {
        EventManager.Instance.OnChangeVideo?.Invoke(_mediaReference, text.text);
    }
}
