using RenderHeads.Media.AVProVideo;
using TMPro;
using UnityEngine;

public class ChangeVideo : MonoBehaviour
{
    [SerializeField] private MediaPlayer mediaPlayer;
    [SerializeField] private MediaPlayer mediaPlayerHoverThumbnail;
    [SerializeField] private TextMeshProUGUI text;

    private void Awake()
    {
        EventManager.Instance.OnChangeVideo += Change;
    }

    private void Change(MediaReference reference, string nameVideo)
    {        
        text.text = nameVideo;    
        if(mediaPlayer.MediaReference == reference) return;
        
        mediaPlayer.OpenMedia(reference);
        mediaPlayer.AutoOpen = false;
        mediaPlayer.AutoStart = false;
        mediaPlayer.Stop();
        mediaPlayerHoverThumbnail.OpenMedia(reference);
        mediaPlayerHoverThumbnail.AutoOpen = false;
        mediaPlayerHoverThumbnail.AutoStart = false;
        mediaPlayerHoverThumbnail.Stop();
    }

    private void OnDestroy()
    {
        EventManager.Instance.OnChangeVideo -= Change;
    }
}
