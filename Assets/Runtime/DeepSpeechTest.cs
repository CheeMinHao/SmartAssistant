using UnityEngine;
using DeepSpeechClient;
using DeepSpeechClient.Interfaces;
using DeepSpeechClient.Models;
using Voxell.Inspector;

public class DeepSpeechTest : MonoBehaviour
{
  public string modelpath;

  [Button]
  void Start()
  {
    IDeepSpeech sttClient = new DeepSpeech(modelpath);
    sttClient.Dispose();
  }

  void Update()
  {
  }
}
