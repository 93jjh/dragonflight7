using UnityEngine;

public class BackGround : MonoBehaviour
{

    //스크롤이 되는 백그라운드
    public float scrollSpeed = 1f;
    private Material myMaterial;


    void Start()
    {
        //머터리얼 가지고 오기
        myMaterial = GetComponent<Renderer>().material;


    }


 
    void Update()
    {
        // 오프셋 머터리얼에서 가져오기
        Vector2 newOffset = myMaterial.mainTextureOffset;

        //새롭에 offset바꿔주기
        //y부분값을속도에 프레임 보정해서 더해주기
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));

        //머터리얼에 오프셋 값을 넣어준다.
        myMaterial.mainTextureOffset = newOffset;
    }
}
