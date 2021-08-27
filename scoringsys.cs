// Decompiled with JetBrains decompiler
// Type: scoringsys
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class scoringsys : MonoBehaviour
{
  public AudioSource src;
  public GameObject scoretext;
  public int thescore;

  private void Start() => this.src = ((Component) this).GetComponent<AudioSource>();

  private void OnTriggerEnter(Collider other)
  {
    if (!Object.op_Implicit((Object) ((Component) other).GetComponent<coins>()))
      return;
    this.src.Play();
    ++this.thescore;
    this.scoretext.GetComponent<Text>().text = string.Concat((object) this.thescore);
    Object.Destroy((Object) ((Component) other).gameObject);
  }
}
