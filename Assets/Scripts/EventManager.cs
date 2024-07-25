using System;
using RenderHeads.Media.AVProVideo;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public Action<MediaReference, string> OnChangeVideo;
    
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
    }
}
