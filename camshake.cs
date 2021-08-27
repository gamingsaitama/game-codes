// Decompiled with JetBrains decompiler
// Type: camshake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;

public class camshake : MonoBehaviour
{
  public IEnumerator shake(float duration, float magnitude)
  {
    camshake camshake = this;
    Vector3 originalpos = ((Component) camshake).transform.localPosition;
    float elapsed = 0.0f;
    while ((double) elapsed < (double) duration)
    {
      float num = Random.Range(-0.5f, 0.5f) * magnitude;
      ((Component) camshake).transform.localPosition = new Vector3(num, (float) originalpos.y, (float) originalpos.z);
      elapsed += Time.deltaTime;
      yield return (object) null;
    }
    ((Component) camshake).transform.localPosition = originalpos;
  }
}
