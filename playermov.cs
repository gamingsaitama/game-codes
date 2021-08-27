// Decompiled with JetBrains decompiler
// Type: playermov
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2DFB5B82-5439-4013-8FD2-02F143230AAE
// Assembly location: D:\games\beatbox\Assembly-CSharp.dll

using UnityEngine;

public class playermov : MonoBehaviour
{
  public Rigidbody rb;
  public float ff = 1000f;
  public float sf = 500f;
  private Touch touch;
  private float speedModifier;

  private void Start()
  {
    ((Component) this.rb).GetComponent<Rigidbody>();
    this.speedModifier = 0.1f;
  }

  private void Update() => ((Component) this).transform.position = new Vector3(Mathf.Clamp((float) ((Component) this).transform.position.x, -6.5f, 6.5f), 1f, (float) ((Component) this).transform.position.z);

  private void FixedUpdate()
  {
    this.rb.AddForce(0.0f, 0.0f, this.ff * Time.deltaTime);
    if (Input.touchCount > 0)
    {
      this.touch = Input.GetTouch(0);
      if (((Touch) ref this.touch).phase == 1)
        ((Component) this).transform.position = new Vector3((float) (((Component) this).transform.position.x + ((Touch) ref this.touch).deltaPosition.x * (double) this.speedModifier), (float) ((Component) this).transform.position.y, (float) ((Component) this).transform.position.z);
    }
    if (this.rb.position.y >= -1.0)
      return;
    Object.FindObjectOfType<gamemanager>().endgame();
  }
}
