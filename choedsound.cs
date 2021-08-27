// Decompiled with JetBrains decompiler
// Type: choedsound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class choedsound : MonoBehaviour
{
  private static AudioSource audiosrc;
  public static AudioClip chords;

  private void Start()
  {
    choedsound.chords = Resources.Load<AudioClip>("high");
    choedsound.audiosrc = ((Component) this).GetComponent<AudioSource>();
  }

  public static void Playsound(string clip)
  {
    if (!(clip == "high"))
      return;
    choedsound.audiosrc.PlayOneShot(choedsound.chords);
  }
}
