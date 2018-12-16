using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLoadingStuff : MonoBehaviour {

    public GameObject Done;

    public GameObject LoginUI;

    public GameObject Style1;

    public GameObject PlayerPrefab;

    public Animator PlayerMenuAnimation;

    private void Start()
    {
        StartCoroutine(ActivationRoutine());
        LoginUI.SetActive(false);
        StartCoroutine(ActivateUI());
        Style1.SetActive(true);
        PlayerMenuAnimation = GetComponent<Animator>();
        PlayerPrefab.SetActive(false);
    }

    private IEnumerator ActivationRoutine()
    {
        yield return new WaitForSeconds(2);

        Done.SetActive(true);
    }

    private IEnumerator ActivateUI()
    {
        yield return new WaitForSeconds(3);

        LoginUI.SetActive(true);
        Style1.SetActive(false);
        PlayerPrefab.SetActive(true);
        PlayerMenuAnimation.Play("MenuAnimation");
    }

}
