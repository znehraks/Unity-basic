using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle02 : MonoBehaviour
{
    Vector3 target = new Vector3(3, 1, 0);
    void Start()
    {
        // int number = 4; //scala 
        // Vector3 vec = new Vector3(5, 5, 5); //vector
        // transform.Translate(vec);
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.anyKeyDown)
        // {
        //     Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        // }
        // if (Input.anyKey)
        // {
        //     Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        // }
        // if (Input.GetKeyDown(KeyCode.Return))
        // {
        //     Debug.Log("아이템을 구입하였습니다.");
        // }
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     Debug.Log("왼쪽으로 이동 중");
        // }
        // if (Input.GetKeyUp(KeyCode.RightArrow))
        // {
        //     Debug.Log("오른쪽 이동을 멈추었습니다.");
        // }


        //마우스 왼쪽: 0, 마우스 오른쪽: 1
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log("미사일 발사!");
        // }
        // if (Input.GetMouseButton(0))
        // {
        //     Debug.Log("미사일 모으는 중...");
        // }
        // if (Input.GetMouseButtonUp(0))
        // {
        //     Debug.Log("슈퍼 미사일 발사!!");
        // }

        //버튼 입력
        // if (Input.GetButton("Horizontal"))
        // {
        //     Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        // }
        // if (Input.GetButton("Vertical"))
        // {
        //     Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        // }

        //단순 이동
        // Vector3 vec = new Vector3(
        //     Input.GetAxisRaw("Horizontal"),
        // Input.GetAxisRaw("Vertical"), 0);
        // transform.Translate(vec);

        //MoveTowards
        // transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);

        // //SmoothDamp
        // Vector3 velo = Vector3.zero;
        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 1f);

        // //Lerp
        // transform.position = Vector3.Lerp(transform.position, target, 1f);

        // //Slerp
        // transform.position = Vector3.Slerp(transform.position, target, 0.05f);

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime
        );
        transform.Translate(vec);
    }
}
