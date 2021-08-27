// Decompiled with JetBrains decompiler
// Type: collectstar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class collectstar : MonoBehaviour
{
  public AudioSource collectsound;

  private void OnTriggerEnter(Collider other)
  {
    this.collectsound.Play();
    ++scoringsystem.thescore;
    Object.Destroy((Object) ((Component) this).gameObject);
  }
}
