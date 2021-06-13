using UnityEngine;
using UnityEditor.AssetImporters;
using System.IO;

namespace SmartAssistant
{
  [ScriptedImporter(0, "py")]
  public class PythonImporter : ScriptedImporter
  {
    public override void OnImportAsset(AssetImportContext ctx)
    {
      PythonAsset pythonAsset = new PythonAsset(ctx.assetPath, File.ReadAllText(ctx.assetPath));
      ctx.AddObjectToAsset("pythonAsset", pythonAsset, Resources.Load<Texture2D>("PythonLogo"));
      ctx.SetMainObject(pythonAsset);
    }
  }
}