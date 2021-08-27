// Decompiled with JetBrains decompiler
// Type: settingsmenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.Audio;

public class settingsmenu : MonoBehaviour
{
  public AudioMixer audiomixer;

  public void Setvolume(float volume) => this.audiomixer.SetFloat(nameof (volume), volume);

  public void SetQuality(int qualityindex) => QualitySettings.SetQualityLevel(qualityindex);
}
