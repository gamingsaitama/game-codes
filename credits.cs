// Decompiled with JetBrains decompiler
// Type: credits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
  public void startgame()
  {
    Scene activeScene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(((Scene) ref activeScene).buildIndex + 1);
  }
}
