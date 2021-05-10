using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]

public class Plant : MonoBehaviour
{
    private CharacterController characterController;
    public float walkSpeed;
    private Vector3 movement;
    public float speed = 3f;
    public float power = 200f;
    public GameObject Seed;
    public Transform spawnPoint;
    public int shotcount;
    private enum State
    {
        Normal,
        ThrowingHook,
        FlyingPlayer
    }

    private void Start()
    {
        characterController = GetComponent<CharacterController>();

        state = State.Normal;
        hookShot.gameObject.SetActive(false);
        hookTargetMark.gameObject.SetActive(false);
    }


    public float hookRange = 100f;
    public Transform hookTargetMark;
    public Transform hookShot;
    private Vector3 hookPoint;
    private float hookShotSize;
    private State state;
    public GameObject Camera;
    private Vector3 moveDir = Vector3.zero;


    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            default:
            case State.Normal: // ノーマルモードの時
                HookStart();
                break;

            case State.ThrowingHook: // フック投げモードの時
                HookThrow();
                break;

            case State.FlyingPlayer: // プレーヤーが空中移動の時
                HookFlyingMovement();
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shotcount < 1) { return; }
               
            Shoot();
            shotcount -= 1;
        }
    }
    void Shoot()
    {
        GameObject newSeed =
            Instantiate(Seed, spawnPoint.position, Quaternion.identity) as GameObject;

        newSeed.GetComponent<Rigidbody>().AddForce(Vector3.up * power);
    }

    void HookStart()
    {
        // マウスの右ボタンを推した時
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.transform.position, Camera.transform.forward, out hit, hookRange))
            {
                // Rayで特定した位置にターゲットマーク(目印）を移動させる。
                hookTargetMark.position = hit.point;
                hookPoint = hit.point;

                state = State.ThrowingHook;
                hookShotSize = 0f;

                hookTargetMark.gameObject.SetActive(true);
                hookShot.gameObject.SetActive(true);
            }
        }
    }

    void HookFlyingMovement()
    {
        Vector3 moveDir = (hookPoint - transform.position).normalized;

        
        // 現在地と目的地の距離が遠いほど移動速度が早い（近くなるにつれて減速）
        float flyingSpeed = Vector3.Distance(transform.position, hookPoint) * 2f;

        characterController.Move(moveDir * flyingSpeed * Time.deltaTime);

        // 右クリックでスパイダーフックの解除
        if (Input.GetMouseButtonDown(1))
        {
            // ノーマルモードに移行する
            state = State.Normal;
            hookTargetMark.gameObject.SetActive(false);
            hookShot.gameObject.SetActive(false);
        }

        // 目標地点の近くまで来るとフックショットを自動的に隠す
        if (Vector3.Distance(transform.position, hookPoint) < 2f)
        {
            hookShot.gameObject.SetActive(false);
        }
    }

    void HookThrow()
    {
        hookShot.LookAt(hookPoint);

        float hookShotSpeed = 50f;
        hookShotSize += hookShotSpeed * Time.deltaTime;
        hookShot.localScale = new Vector3(1, 1, hookShotSize);

        if (hookShotSize >= Vector3.Distance(transform.position, hookPoint))
        {
            // 空中移動モードに移行（空中移動を開始する）
            state = State.FlyingPlayer;
        }
    }

}
