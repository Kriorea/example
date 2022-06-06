using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float _speed;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        PlayerMoving(); 
    }
    public void PlayerMoving()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * _speed);
            animator.SetFloat("InputLMB", 1);
            float h = Input.GetAxis("Mouse X");
            Vector3 offset = new Vector3(h, 0, 0) * _speed * Time.deltaTime;
            transform.Translate(offset);
        }
        else
        {
            animator.SetFloat("InputLMB", 0);
        }
    }
}
