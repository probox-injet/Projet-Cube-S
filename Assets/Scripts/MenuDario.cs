using System.Collections;
using UnityEngine;

public class MenuDario : MonoBehaviour
{
    GameObject dario, l1dr, dr2, dr3, dr4, dr5, dr6, dr7;
    void Start()
    {
        dario = GameObject.Find("Dario").gameObject;
        l1dr = GameObject.Find("L1àL3Dr").gameObject;
        dr2 = GameObject.Find("L4à6Dr").gameObject;
        dr3 = GameObject.Find("L7à9Dr").gameObject;
        dr4 = GameObject.Find("L10à11D").gameObject;
        dr5 = GameObject.Find("L12à13D").gameObject;
        dr6 = GameObject.Find("L14à16D").gameObject;
        dr7 = GameObject.Find("L17à20D").gameObject;
        dario.SetActive(false);
        l1dr.SetActive(false);
        dr2.SetActive(false);
        dr3.SetActive(false);
        dr4.SetActive(false);
        dr5.SetActive(false);
        dr6.SetActive(false);
        dr7.SetActive(false);
    }

    public void darioBtn()
    {
        dario.SetActive(true);
        l1dr.SetActive(true);
    }
}
