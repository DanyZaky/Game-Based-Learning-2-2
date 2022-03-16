using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fishing : MonoBehaviour
{
    [SerializeField] private GameObject isFishingText, startFishButton, catchButton, attackButton;

    [SerializeField] private TextMeshProUGUI attackTimeRemaining;
    private float timeCounter = 0;
    void Start()
    {
        startFishButton.SetActive(true);
        isFishingText.SetActive(false);
        catchButton.SetActive(false);
        attackButton.SetActive(false);

        timeCounter = 10f;
    }

    void Update()
    {
        timeCounter -= 1 * Time.deltaTime;
        attackTimeRemaining.SetText(timeCounter.ToString("0"));
    }

    private IEnumerator isFishing(float FishingDuration)
    {
        startFishButton.SetActive(false);
        isFishingText.SetActive(true);
        yield return new WaitForSecondsRealtime(FishingDuration);
        isFishingText.SetActive(false);
        catchButton.SetActive(true);
    }

    public void StartFishingButton()
    {
        StartCoroutine(isFishing(2f));
    }

    public void CatchButton()
    {
        
    }

    public void AttackButton()
    {

    }

}
