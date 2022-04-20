using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WalkableSurface : MonoBehaviour, IPointerClickHandler 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnPointerClick(PointerEventData data)
    {
        if(data.button == PointerEventData.InputButton.Right){
            Unit.selectedUnit.MoveTo (data.pointerCurrentRaycast.worldPosition);
        }
    }
}
