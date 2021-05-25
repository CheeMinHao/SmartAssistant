using UnityEngine;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

public class PythonTester : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    ScriptEngine pythonEngine = Python.CreateEngine();
    ScriptSource pythonScript = pythonEngine.CreateScriptSourceFromString("print('Hello from Python!')");
    pythonScript.Execute();
  }

  // Update is called once per frame
  void Update()
  {
  }
}
