using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string name_del_boton;
    public int width_enter;
    public int height_enter;
    public int width_exit;
    public int height_exit;


    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject theBar = GameObject.Find("Canvas/"+ name_del_boton);
        var theBarRectTransform = theBar.transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2(width_enter, height_enter);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GameObject theBar = GameObject.Find("Canvas/"+ name_del_boton);
        var theBarRectTransform = theBar.transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2(width_exit, height_exit);
    }


}
