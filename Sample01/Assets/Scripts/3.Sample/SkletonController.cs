using UnityEngine;
//버튼의 Onclick에 등록할 기능

/*(버튼 작업)
OnClick은 버튼이 가지고 있는 이벤트 기능으로
클릭을 했을 때, 실행할 명령을 작성하는 위치
-버튼의 onClick에 기능을 전달합니다.
-왼쪽 이동
-오른쪽 이동
*/
//    과제 버튼을 눌렀을 때 방향에 맞게
//    움직이도록 코드를 수정해주세요.

//    이미지 꾸미기는 자유(에셋 스토어 활용)

//    점수에 관련된 스크립트를 작성해서
//    시간이 지날때마다 점수가 오르도록 설계하고
//    화면에서 출력될 수 있도록 코드를 설계합니다.
//    (UI의 Text)
//    일정 점수가 되면 낙하 속도가 더 빨라지도록
//    코드를 수정해주세요.

//    ex) 점수 5000점 당 속도 1증가




public class SkletonController : MonoBehaviour
{
    public GameObject skeleton;

    //public void 메소드명()
    //{
    // 이 메소드를 실행할 경우 실행할 명령문을 작성하는 위치
    //}
    public void OnLButtonEnter()
    {
        skeleton.transform.Translate(1, 0, 0); 

    }
   
    public void OnRButtonEnter()
    {
        skeleton.transform.Translate(-1, 0, 0);
    }
}
