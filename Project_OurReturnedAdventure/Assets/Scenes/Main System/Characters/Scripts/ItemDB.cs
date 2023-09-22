using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    [Header("아이템 반응")]
    public GameObject ITEM;
    public string[] ItemName;
    /// <summary>
    /// = new string[] { "닭날개", "닭다리" };
    /// public string[] ItemInform = new string[] {
    ///     "마을에 돌아다니는 애꿎은 닭을 잡고 얻는 날개.\n살이 너무 없어서 얼마 먹지도 못할 것 같다.\n모닥불에서 사용시 체력 3 회복\n[퀘스트][회복]",
    ///     "마을에 돌아다니는 애꿏은 닭을 잡고 얻는 다리.\n날개보다는 살이 많아서 그나마 먹음직하다.\n모닥불에서 사용시 체력 8 회복\n[퀘스트][회복]",
    ///     ""    }; 
    /// </summary>
    public int[] ItemID;
    // = new int[] {};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
