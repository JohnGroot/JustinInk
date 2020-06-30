using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StoryTextDisplay : StoryEventListener
{
    [SerializeField]
    TextMeshProUGUI textMesh = default;

    public override void OnStoryEventInvoked(StoryAsset inStoryAsset)
    {
        textMesh.SetText(inStoryAsset.StoryInstance.currentText);
    }
}
