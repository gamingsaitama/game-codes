// Decompiled with JetBrains decompiler
// Type: chordsound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class chordsound : MonoBehaviour
{
  private static AudioSource audiosrc;
  public static AudioClip chords;

  private void Start()
  {
    chordsound.chords = Resources.Load<AudioClip>("low");
    chordsound.audiosrc = ((Component) this).GetComponent<AudioSource>();
  }

  public static void Playsound(string clip)
  {
    if (!(clip == "low"))
      return;
    chordsound.audiosrc.PlayOneShot(chordsound.chords);
  }
}
