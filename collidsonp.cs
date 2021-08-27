// Decompiled with JetBrains decompiler
// Type: collidsonp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class collidsonp : MonoBehaviour
{
  public playermov pm;
  public camshake camerashake;
  public GameObject enemydestroyeffect;

  private void OnCollisionEnter(Collision collinfo)
  {
    if (!(((Component) collinfo.collider).tag == "Obstacle"))
      return;
    ((Behaviour) this.pm).enabled = false;
    this.StartCoroutine(this.camerashake.shake(0.15f, 0.4f));
    Object.Instantiate<GameObject>(this.enemydestroyeffect, ((Component) this).transform.position, Quaternion.identity);
    Object.Destroy((Object) ((Component) this).gameObject);
  }
}
