/*
This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software Foundation,
Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.

The Original Code is Copyright (C) 2020 Voxell Technologies and Contributors.
All rights reserved.
*/

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
