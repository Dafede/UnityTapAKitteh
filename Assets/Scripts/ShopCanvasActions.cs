using UnityEngine;
using System.Collections;

public class ShopCanvasActions : MonoBehaviour {

    public GameObject bakeneko;

    public void OnClickCincoBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().NumCincoBolsitas++;
    }
    public void OnClickCincuentaBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().NumCincuentaBolsitas++;
    }
    public void OnClickCienBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().NumCienBolsitas++;
    }
    public void OnClickDosCienBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().NumDosCienBolsitas++;
    }
    public void OnClickDosCienCincuentaBolsita()
    {
        bakeneko.GetComponent<Bakeneko>().NumDosCienCincuentaBolsitas++;
    }


}
