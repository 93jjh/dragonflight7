using UnityEngine;

public class Player : MonoBehaviour
{


    //스피드
    public float moveSpeed = 3;

    void Start()
    {
        
    }

    void Update()
    {
        //x 값만 설정 vector 방향 * 시간 * 스피드 (공식 외우기)
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //x쪽 이동 설정
        transform.Translate(distanceX, 0, 0);

    }
}
