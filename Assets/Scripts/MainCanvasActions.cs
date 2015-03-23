using UnityEngine;
using System.Collections;

public class MainCanvasActions : MonoBehaviour {

    public Camera mainCamera;
    private Animator animator;


    void Awake() {
        
        animator = mainCamera.GetComponent<Animator>();
    }

    public void OnClickShopButton() {
        animator.SetBool("GoLeft", true);
        animator.SetBool("GoRight", false);
        Invoke("SetAllTheStuffToFalse", 0.25f); //Very very CRAP
    }

    public void OnClickInfoButton() {
        animator.SetBool("GoRight", true);
        animator.SetBool("GoLeft", false);
        Invoke("SetAllTheStuffToFalse", 0.25f); //Very very CRAP
    }

    // Crapiest crap
    private void SetAllTheStuffToFalse() {
        animator.SetBool("GoRight", false);
        animator.SetBool("GoLeft", false);
    }
}
