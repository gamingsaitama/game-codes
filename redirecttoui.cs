// Decompiled with JetBrains decompiler
// Type: redirecttoui
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class redirecttoui : MonoBehaviour
{
  public AudioSource impact;
  private int scene;

  public void Start()
  {
    this.impact = ((Component) this).GetComponent<AudioSource>();
    Scene activeScene = SceneManager.GetActiveScene();
    this.scene = ((Scene) ref activeScene).buildIndex;
  }

  private IEnumerator waitforsceneload()
  {
    yield return (object) new WaitForSeconds(2f);
    switch (this.scene)
    {
      case 2:
        SceneManager.LoadScene(3);
        break;
      case 5:
        SceneManager.LoadScene(6);
        break;
      case 8:
        SceneManager.LoadScene(9);
        break;
      default:
        SceneManager.LoadScene(1);
        break;
    }
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (!(collision.gameObject.tag == "Player"))
      return;
    this.impact.Play();
    this.StartCoroutine(this.waitforsceneload());
  }
}
