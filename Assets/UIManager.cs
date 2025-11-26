using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject detailPanel;
    public GameObject registerPanel; // [추가] 등록 화면 패널

    // 상세화면 열기 (기존)
    public void OpenDetail()
    {
        mainPanel.SetActive(false);
        detailPanel.SetActive(true);
        registerPanel.SetActive(false);
    }

    // [추가] 등록화면 열기 함수
    public void OpenRegister()
    {
        mainPanel.SetActive(false);   // 메인 끄기
        detailPanel.SetActive(false);
        registerPanel.SetActive(true); // 등록 화면 켜기
    }

    // 메인으로 돌아오기 (업데이트)
    public void BackToMain()
    {
        detailPanel.SetActive(false); // 상세 끄기
        registerPanel.SetActive(false); // [추가] 등록 화면도 끄기
        mainPanel.SetActive(true);    // 메인 켜기
    }
}