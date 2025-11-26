using UnityEngine;
using UnityEngine.UI;
using TMPro; // TextMeshPro 사용

public class RegisterViewController : MonoBehaviour
{
    [Header("UI Groups")]
    public GameObject inputGroup; // 나중에 켜질 입력창 묶음
    public GameObject cameraFrame; // 카메라 영역

    [Header("UI Elements to Fill")]
    public TMP_InputField nameField;  // 물건 이름 입력칸
    public TMP_InputField colorField; // 색상 입력칸 (DescriptionField 등을 색상용으로 쓴다면)
    public RawImage photoDisplay;     // 찍은 사진 보여줄 곳

    private void OnEnable()
    {
        // 패널이 켜질 때마다 초기화 (입력창 숨기기)
        ResetView();
    }

    // 1. 초기 상태: 탑바랑 카메라만 보이기
    public void ResetView()
    {
        inputGroup.SetActive(false); // 입력폼 숨김
        cameraFrame.SetActive(true); // 카메라는 보임
        
        // 여기에 나중에 카메라 켜는 코드 추가
        // CameraManager.Instance.StartCamera(); 
    }

    // 2. 사진 촬영 후 호출될 함수 (AI 연동 후 사용)
    public void OnPhotoTaken(string detectedName, string detectedColor, Texture2D photo)
    {
        // 입력 그룹을 켬
        inputGroup.SetActive(true);
        // [추가] 카메라 프레임(촬영 화면)은 끔
        cameraFrame.SetActive(false);

        // AI가 분석한 데이터 채워넣기
        nameField.text = detectedName;
        colorField.text = detectedColor; // 혹은 DescriptionField 등 원하는 곳에
        photoDisplay.texture = photo;

        // 필요하다면 카메라 끄기 등 추가 로직
    }
    
    // 테스트용: 카메라 프레임 누르면 일단 화면 넘어가게 하기 (임시)
    public void TestTransition()
    {
        // 가짜 데이터로 테스트
        OnPhotoTaken("인식된 지갑", "빨간색", null);
    }
}