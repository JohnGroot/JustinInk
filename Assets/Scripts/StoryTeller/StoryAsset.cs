using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;

[CreateAssetMenu(fileName = "StoryData", menuName = "StoryTeller/Story Asset")]
public class StoryAsset : ScriptableObject
{
    [SerializeField]
    private TextAsset inkAsset = default;

    private Story storyInstance = default;
    public Story StoryInstance { get { return storyInstance; } }

    public void Init()
    {
        if (inkAsset)
        {
            storyInstance = new Story(inkAsset.text);
        }
        else
        {
            Debug.LogError("No Ink Asset assigned to story asset!");
        }
    }

    public void Continue()
    {
        storyInstance.Continue();
    }
}
