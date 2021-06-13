using UnityEngine;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

public class PythonTester : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    ScriptEngine pythonEngine = Python.CreateEngine();
    ScriptSource pythonScript = pythonEngine.CreateScriptSourceFromString("open('./file.txt', 'w').write('hello')");
    pythonScript.Execute();
  }

  // Update is called once per frame
  void Update()
  {
  }
}
