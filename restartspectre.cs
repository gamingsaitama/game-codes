// Decompiled with JetBrains decompiler
// Type: restartspectre
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class restartspectre : MonoBehaviour
{
  private int sce;

  public void Start()
  {
    Scene activeScene = SceneManager.GetActiveScene();
    this.sce = ((Scene) ref activeScene).buildIndex;
  }

  public void restartspscript()
  {
    switch (this.sce)
    {
      case 4:
        SceneManager.LoadScene(2);
        break;
      case 7:
        SceneManager.LoadScene(5);
        break;
      case 10:
        SceneManager.LoadScene(8);
        break;
      default:
        SceneManager.LoadScene(1);
        break;
    }
    if ((double) Time.timeScale != 0.0 && (double) Time.timeScale != 1.0)
      return;
    Time.timeScale = 1f;
  }
}
