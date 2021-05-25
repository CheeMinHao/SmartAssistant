using UnityEngine;
using SmartAssistant.Core;

public class GameManager : MonoBehaviour
{
  [ReadOnly]
  public string scenes;

  void Awake()
  {
    QualitySettings.vSyncCount = 1;
    Application.targetFrameRate = 60;
  }

  void Start()
  {
  }

  void Update()
  {
  }
}
