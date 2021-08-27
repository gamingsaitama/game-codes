// Decompiled with JetBrains decompiler
// Type: vathicoming
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class vathicoming : MonoBehaviour
{
  public void Playgame()
  {
    SceneManager.LoadScene(8);
    if ((double) Time.timeScale != 0.0 && (double) Time.timeScale != 1.0)
      return;
    Time.timeScale = 1f;
  }
}
