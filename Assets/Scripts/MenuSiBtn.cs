using UnityEngine;
using System.Collections;

public class MenuSiBtn : MonoBehaviour
{
    GameObject carteMicroBit, ledStart, song, btnOn, btnOff, l1, l2, l3, l4BtnA, l5BtnB, fin, dnm2, marin;
    bool sons = false;


    void Start()
    {
        l1 = GameObject.Find("LOnSon").gameObject;
        l2 = GameObject.Find("L1à5Wait1s").gameObject;
        l3 = GameObject.Find("L6à13While").gameObject;
        l4BtnA = GameObject.Find("L14à15BtnA").gameObject;
        l5BtnB = GameObject.Find("L16à17BtnB").gameObject;
        fin = GameObject.Find("L18à20").gameObject;
        carteMicroBit = GameObject.Find("CarteMicroBit").gameObject;
        ledStart = GameObject.Find("LedStart").gameObject;
        song = GameObject.Find("Song").gameObject;
        btnOn = GameObject.Find("Btn3Y").gameObject;
        btnOff = GameObject.Find("Btn3Ys").gameObject;
        dnm2 = GameObject.Find("dnmmPanel").gameObject;
        marin = GameObject.Find("Marin").gameObject;        
        l1.SetActive(false); //true
        l2.SetActive(false);
        l3.SetActive(false);
        l4BtnA.SetActive(false);
        l5BtnB.SetActive(false);
        fin.SetActive(false);
        carteMicroBit.SetActive(false); //true
        ledStart.SetActive(false);
        song.SetActive(false);
        btnOn.SetActive(false); //true
        btnOff.SetActive(false);
        dnm2.SetActive(true);
        marin.SetActive(false);

    }
    
    public void dnmBtn()
    {
        carteMicroBit.SetActive(true);
        dnm2.SetActive(false);
    }

    public void marinBtn()
    {
        l1.SetActive(true);
        carteMicroBit.SetActive(true);
        btnOn.SetActive(true);
        marin.SetActive(true);
        dnm2.SetActive(false);
    }

    
    public void btn1() //Bouton A
    {
        if(sons == true)
        {
            song.SetActive(false);
            l5BtnB.SetActive(false);
            l4BtnA.SetActive(true);
            StartCoroutine(WaitBtnA());
        }
    }

    public void btn2() //Bouton B
    {
        if(sons == true)
        {
            l4BtnA.SetActive(false);
            l5BtnB.SetActive(true);
            song.SetActive(true);
        }
    }

    public void btn3()
    {
        l2.SetActive(true);
        StartCoroutine(WaitBeforeShow());
    }

    public void btn3Off()
    {
        btnOn.SetActive(true);
        fin.SetActive(true);
        l2.SetActive(false);
        sons = false;
        ledStart.SetActive(false);
        song.SetActive(false);
        btnOff.SetActive(false);
        l3.SetActive(false);
        l5BtnB.SetActive(false);
        StartCoroutine(WaitTheEnd());

    }

    IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(1);
        l3.SetActive(true);
        sons = true;
        ledStart.SetActive(true);
        btnOff.SetActive(true);
        //song.SetActive(true);
        btnOn.SetActive(false);
    }

    IEnumerator WaitTheEnd()
    {
        
        yield return new WaitForSeconds(1);
        fin.SetActive(false);
    }

    IEnumerator WaitBtnA()
    {
        yield return new WaitForSeconds(1);
        l4BtnA.SetActive(false);
    }

    public void Update()
    {
        if(marin == false)
        {
            btnOn.SetActive(false);
        }
    }
}