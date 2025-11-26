using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    private Button btn;
    private UIManager uiManager;

    void Start()
    {
        // 1. 내 몸에 붙은 버튼 컴포넌트 가져오기
        btn = GetComponent<Button>();

        // 2. 씬에 있는 UIManager 찾기
        uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();

        // 3. 버튼이 클릭되면 UIManager의 OpenDetail 함수 실행하도록 연결
        btn.onClick.AddListener(() => uiManager.OpenDetail());
    }
}