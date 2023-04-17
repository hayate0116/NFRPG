using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownManager : MonoBehaviour
{
    private void Start()
    {
        DialogTextManager.instance.SetScenarios(new string[] { "街についた。" });
    }
    public void OnToQuestButton()
    {
        SoundManager.Instance.PlaySE(0);
    }
}
