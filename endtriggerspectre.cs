// Decompiled with JetBrains decompiler
// Type: endtriggerspectre
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class endtriggerspectre : MonoBehaviour
{
  private void OnTriggerEnter(Collider other) => SceneManager.LoadScene(7);
}
