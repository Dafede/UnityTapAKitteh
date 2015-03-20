using UnityEngine;
using System.Collections;

public class MainCanvasActions : MonoBehaviour {

    public Camera mainCamera;
    private Animator animator;


    void Awake() {
        
        animator = mainCamera.GetComponent<Animator>();
    }

    public void OnClickShopButton() {
        animator.SetBool("MoveCameraLeft",true);
        
    }

    public void OnClickInfoButton() { 

    }
}
