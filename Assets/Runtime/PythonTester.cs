using UnityEngine;
using System.Collections.Generic;
using System.IO;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

using SmartAssistant.Core.Inspector;
using SmartAssistant;

public class PythonTester : MonoBehaviour
{
  public PythonAsset pythonAsset;

  // Start is called before the first frame update
  [Button]
  public void TestPython()
  {
    ScriptEngine pythonEngine = Python.CreateEngine();
    pythonEngine.Runtime.LoadAssembly(typeof(GameObject).Assembly);
    ICollection<string> searchPaths = pythonEngine.GetSearchPaths();

    //Path to the Python standard library
    string[] libPaths = Directory.GetDirectories($"{Application.dataPath}/IronPython/Lib/");
    searchPaths.Add($"{Application.dataPath}/IronPython/Lib/");
    foreach (string path in libPaths) searchPaths.Add(path);

    //Path to the folder of main.py
    string[] mainPaths = Directory.GetDirectories($"{Application.dataPath}/Runtime/PythonFiles/");
    searchPaths.Add($"{Application.dataPath}/Runtime/PythonFiles/");
    foreach (string path in mainPaths) searchPaths.Add(path);
    pythonEngine.SetSearchPaths(searchPaths);

    ScriptScope scriptScope = pythonEngine.ExecuteFile(pythonAsset.filePath);
  }

  // Update is called once per frame
  void Update()
  {
  }
}
