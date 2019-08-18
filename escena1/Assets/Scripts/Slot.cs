using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Slot : MonoBehaviour, IDropHandler
{
    public GameObject slot;
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
        if (!item){
            Debug.Log("hola");

            if(gameObject.tag=="TornilloBueno"){
                SceneManager.LoadScene("SiAciertaTornillo");
            }else{
                SceneManager.LoadScene("SiFallaTornillo");
            }


        }
    }
}
