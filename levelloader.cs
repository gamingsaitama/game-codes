// Decompiled with JetBrains decompiler
// Type: levelloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
  public Animator transition;
  public float transtime = 1f;

  private void Update()
  {
    if (!Input.GetMouseButtonDown(0))
      return;
    this.LoadNextLevel();
  }

  public void LoadNextLevel()
  {
    Scene activeScene = SceneManager.GetActiveScene();
    this.StartCoroutine(this.Loadlevel(((Scene) ref activeScene).buildIndex + 1));
  }

  private IEnumerator Loadlevel(int levelIndex)
  {
    this.transition.SetTrigger("start");
    yield return (object) new WaitForSeconds(this.transtime);
    SceneManager.LoadScene(levelIndex);
  }
}
