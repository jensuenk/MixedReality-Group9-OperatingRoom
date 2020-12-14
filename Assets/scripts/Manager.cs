using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public CanvasGroup cnv;
    public GameObject patientcamera;
    public GameObject OutofbodyCamera;
    public bool change;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fadeWhiteAndChangeCamera());
    }

    // Update is called once per frame
    void Update()
    {
        if (change)
        {
            StartCoroutine(fadeWhiteAndChangeCamera());
            change = false;
        }
    }
    public void PatientToOutOfBody()
    {

    }

    public IEnumerator fadeWhiteAndChangeCamera()
    {
        yield return new WaitForSeconds(90f);
        while (cnv.alpha < 1)
        {
            cnv.alpha += Time.deltaTime / 2;
            yield return null;
        }

        patientcamera.SetActive(false);
        OutofbodyCamera.SetActive(true);

        yield return new WaitForSeconds(1f);
        while (cnv.alpha > 0)
        {
            cnv.alpha -= Time.deltaTime / 2;
            yield return null;
        }

        yield return null;
    }
}
