// Decompiled with JetBrains decompiler
// Type: mainmenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;
using UnityEngine.UI;

public class mainmenu : MonoBehaviour
{
  public GameObject levelbuttonprefab;
  public GameObject levelbuttoncontainer;

  private void Start()
  {
    foreach (Sprite sprite in Resources.LoadAll<Sprite>("levels"))
      Object.Instantiate<GameObject>(this.levelbuttonprefab).GetComponent<Image>().sprite = sprite;
  }
}
