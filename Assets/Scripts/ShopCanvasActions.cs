using UnityEngine;
using System.Collections;

public class ShopCanvasActions : MonoBehaviour {

    public GameObject bakeneko;

    public void OnClickCincoBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().numCincoBolsitas++;
    }
    public void OnClickCincuentaBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().numCincuentaBolsitas++;
    }
    public void OnClickCienBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().numCienBolsitas++;
    }
    public void OnClickDosCienBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().numDosCienBolsitas++;
    }
    public void OnClickDosCienCincuentaBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().numDosCienCincuentaBolsitas++;
    }


}
