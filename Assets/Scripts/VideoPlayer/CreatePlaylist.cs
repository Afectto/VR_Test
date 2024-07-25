using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CreatePlaylist : MonoBehaviour
{
    [SerializeField] private Preview previewPrefab;
    [SerializeField] private Transform content;

    private List<VideoObject> _videoObjects;

    private void Start()
    {
        _videoObjects = Resources.LoadAll<VideoObject>("ScriptableObject").ToList();

        for (int i = 0; i < _videoObjects.Count; i++)
        {
            
            var preview = Instantiate(previewPrefab, content);
            preview.Initialize(_videoObjects[i]);
            if (i == 0)
            {
                preview.ForceChangeVideo();
            }
        }
        
    }
    
    
}
