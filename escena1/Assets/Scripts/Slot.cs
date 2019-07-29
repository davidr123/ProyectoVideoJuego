using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject item{
        get{
            if(transform.childCount>0 ){
                return transform.GetChild(0).gameObject;
            }
            return null;
        }
    }

    public void OnDrop (PointerEventData eventData)
    {
        if(!item){
                TornilloRiel.itemBeginDragged.transform.SetParent(transform);
                SceneManager.LoadScene("SiAciertaTornillo");
            }
    }
}
