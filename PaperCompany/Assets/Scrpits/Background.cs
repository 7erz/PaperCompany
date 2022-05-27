using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed;
    //스크롤링
    public int startIndex; //위가 스타트
    public int endIndex; //아래가 엔드
    public Transform[] sprites;   
    
    float viewWidth;

    private void Awake()
    {
        viewWidth =Camera.main.orthographicSize * 2;   //2를 곱해서 실제 높이를 구한 것임, 카메라 사이즈 2배
    }

    void Update()
    {
        Move();
        Scrolling();
    }
    void Move()
    {
        Vector3 curpos = transform.position;
        Vector3 nextpos = Vector3.down * speed * Time.deltaTime;
        transform.position = curpos + nextpos;
    }
    void Scrolling()
    {
        if(sprites[endIndex].position.x < viewWidth*(-1))
        {
            Vector3 backSpritePos = sprites[startIndex].localPosition;
            Vector3 forntSpritePos = sprites[endIndex].localPosition;
            sprites[endIndex].transform.localPosition = backSpritePos +Vector3.right*10;

            int startIndexSave = startIndex;    //위치가 바뀐것을 저장 하기
            startIndex = endIndex;
            endIndex = (startIndexSave-1 == -1) ? sprites.Length-1 : startIndexSave - 1;
        }
    }
}

}
