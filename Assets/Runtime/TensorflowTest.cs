using UnityEngine;
using static Tensorflow.Binding;
using Tensorflow;
using Voxell.Inspector;

public class TensorflowTest : MonoBehaviour
{
  [Button]
  public void Test()
  {
    Tensor hello = tf.constant("Hello Tensorflow!");
    Debug.Log(hello);
  }
}
