// Decompiled with JetBrains decompiler
// Type: coins
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class coins : MonoBehaviour
{
  public AudioSource impact;
  public GameObject scoretext;
  public int thescore;

  private void Start() => this.impact = ((Component) this).GetComponent<AudioSource>();

  private void OnCollisionEnter(Collision collision)
  {
    if (!(collision.gameObject.tag == "Player"))
      return;
    this.impact.Play();
    ++this.thescore;
    this.scoretext.GetComponent<Text>().text = string.Concat((object) this.thescore);
    Object.Destroy((Object) ((Component) this).gameObject);
  }
}
