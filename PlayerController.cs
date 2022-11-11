// 在圓圈的世界
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 在圓圈的世界
public class PlayerController : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 15;
    private Vector3 moveDir;
    // 在圓圈的世界
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // 在圓圈的世界
    void Update()
    {
        moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
    }
    // 在圓圈的世界
    private void FixedUpdate()
    {
        transform.GetComponent<Rigidbody>().MovePosition(transform.GetComponent<Rigidbody>().position +
                                                        transform.TransformDirection(moveDir) * moveSpeed * Time.deltaTime);
    }
}
