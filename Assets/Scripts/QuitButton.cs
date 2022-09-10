using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{
    [SerializeField] private float buttonDelay;
    public Button Quit_Button;

    private void Start()
    {
        StartCoroutine(QuitButtonAppear());
    }

    private IEnumerator QuitButtonAppear()
    {
        yield return new WaitForSeconds(buttonDelay);
        Quit_Button.gameObject.SetActive(true);
    }
}
