// Decompiled with JetBrains decompiler
// Type: gamemanager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
  private bool gameended;
  public float restartdelay = 1f;
  public GameObject completelevelui;

  public void completelevel() => this.completelevelui.SetActive(true);

  public void endgame()
  {
    if (this.gameended)
      return;
    this.gameended = true;
    Debug.Log((object) "go");
    this.Invoke("restart", this.restartdelay);
  }

  private void restart()
  {
    Scene activeScene = SceneManager.GetActiveScene();
    SceneManager.LoadScene(((Scene) ref activeScene).name);
  }
}
