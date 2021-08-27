// Decompiled with JetBrains decompiler
// Type: camfollow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class camfollow : MonoBehaviour
{
  public Transform player;
  public Vector3 offset;

  private void Update() => ((Component) this).transform.position = Vector3.op_Addition(this.player.position, this.offset);
}
