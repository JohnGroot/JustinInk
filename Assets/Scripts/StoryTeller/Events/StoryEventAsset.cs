using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EventData", menuName = "StoryTeller/Event Asset")]
public class StoryEventAsset : ScriptableObject
{
    private List<StoryEventListener> listeners = new List<StoryEventListener>();

    public void Invoke(StoryAsset inStoryAsset)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnStoryEventInvoked(inStoryAsset);
        }
    }

    public void RegisterListener(StoryEventListener inListener)
    {
        listeners.Add(inListener);
    }

    public void UnregisterListener(StoryEventListener inListener)
    {
        listeners.Remove(inListener);
    }
}