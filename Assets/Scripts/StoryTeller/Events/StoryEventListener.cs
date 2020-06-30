using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryEventListener : MonoBehaviour
{
    [SerializeField]
    private StoryEventAsset eventAsset;

    private void OnEnable()
    {
        eventAsset.RegisterListener(this);
    }

    private void OnDisable()
    {
        eventAsset.UnregisterListener(this);
    }

    public virtual void OnStoryEventInvoked(StoryAsset inStoryAsset) { }
}
