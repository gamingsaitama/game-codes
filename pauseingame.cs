// Decompiled with JetBrains decompiler
// Type: pauseingame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class pauseingame : MonoBehaviour
{
  public static bool gameispaused;
  public AudioSource audio;

  public void Pause()
  {
    if ((double) Time.timeScale != 1.0 && (double) Time.timeScale != 0.0)
      return;
    Time.timeScale = 0.0f;
    this.audio.Pause();
  }

  public void resume()
  {
    if ((double) Time.timeScale != 0.0)
      return;
    Time.timeScale = 1f;
    this.audio.Play();
  }
}
