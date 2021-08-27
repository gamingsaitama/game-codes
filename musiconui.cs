// Decompiled with JetBrains decompiler
// Type: musiconui
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class musiconui : MonoBehaviour
{
  private static musiconui instance;

  private void Awake()
  {
    Object.DontDestroyOnLoad((Object) this);
    if (Object.op_Equality((Object) musiconui.instance, (Object) null))
      musiconui.instance = this;
    else
      Object.Destroy((Object) ((Component) this).gameObject);
  }
}
