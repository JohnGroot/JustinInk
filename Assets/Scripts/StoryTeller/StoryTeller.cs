using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTeller : MonoBehaviour
{
    [SerializeField]
    private StoryAsset storyAsset = default;

    [SerializeField]
    private StoryEventAsset continueEvent = default;

    private void Awake()
    {
        if (storyAsset != null)
        {
            storyAsset.Init();

            storyAsset.StoryInstance.onDidContinue += OnDidContinue;

            storyAsset.Continue();
        }
    }

    private void OnDestroy()
    {
        if (storyAsset != null)
        {
            storyAsset.StoryInstance.onDidContinue -= OnDidContinue;
        }
    }

    private void OnDidContinue()
    {
        continueEvent.Invoke(storyAsset);
    }
}
