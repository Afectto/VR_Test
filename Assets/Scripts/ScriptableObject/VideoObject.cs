using RenderHeads.Media.AVProVideo;
using UnityEngine;

[CreateAssetMenu(fileName = "VideoObject", menuName = "VideoInfo/New VideoObject")]
public class VideoObject : ScriptableObject
{
    [SerializeField] private MediaReference video;
    [SerializeField] private Sprite image;
    [SerializeField] private string nameVideo;

    public MediaReference Video => video;
    public Sprite Image => image;
    public string NameVideo => nameVideo;
}
