using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ESC_Button : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Image buttonImage;
    public Sprite defaultSprite;
    public Sprite pressedSprite;

    public RectTransform text;
    private Vector2 defaultText;
    public Vector2 pressedText = new Vector2(0, -7);
    // Start is called before the first frame update
    void Start()
    {
        defaultText = text.anchoredPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnBtnClick()
    {
        Debug.Log("����");
        Application.Quit();     // ���� ���� ����
        UnityEditor.EditorApplication.isPlaying = false;    // �׽�Ʈ ����
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonImage.sprite = pressedSprite;
        text.anchoredPosition = defaultText + pressedText;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonImage.sprite = defaultSprite;
        text.anchoredPosition = defaultText;
    }
}