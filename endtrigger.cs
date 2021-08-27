// Decompiled with JetBrains decompiler
// Type: endtrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class endtrigger : MonoBehaviour
{
  private int s;

  public void Start()
  {
    Scene activeScene = SceneManager.GetActiveScene();
    this.s = ((Scene) ref activeScene).buildIndex;
  }

  private void OnTriggerEnter(Collider other)
  {
    switch (this.s)
    {
      case 2:
        SceneManager.LoadScene(4);
        break;
      case 8:
        SceneManager.LoadScene(10);
        break;
      default:
        SceneManager.LoadScene(1);
        break;
    }
  }
}
