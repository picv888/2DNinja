using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour {
    public float moveVelocity;//移动速度
    public UnityEvent<float> onRun;//奔跑事件, 参数: float : 奔跑速度,
    public UnityEvent onIdle;//
                             // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        transform.LookAt(Vector3.Lerp(transform.forward, transform.position + new Vector3(h, 0, v), 0.1f));
        transform.position += Time.deltaTime * moveVelocity * new Vector3(h, 0, v);
    }
}
