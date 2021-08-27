// Decompiled with JetBrains decompiler
// Type: scoringsystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class scoringsystem : MonoBehaviour
{
  private Text text;
  public static int thescore;

  private void Start() => this.text = GameObject.Find("GameObject").GetComponent<Text>();

  private void Update() => this.text.text = scoringsystem.thescore.ToString();
}
