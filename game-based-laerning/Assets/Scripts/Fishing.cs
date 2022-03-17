using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fishing : MonoBehaviour
{
    [SerializeField] private GameObject isFishingText, startFishButton, catchButton, attackButton, IkanPaus;

    [SerializeField] private TextMeshProUGUI attackTimeRemaining;
    private float timeCountdown;
    private float timeCountdownCounter;
    private bool isCountdown;
    
    private float HPFish;
    private float HPFishCounter;
    [SerializeField] private Image HPFishFill;

    void Start()
    {
        startFishButton.SetActive(true);
        isFishingText.SetActive(false);
        catchButton.SetActive(false);
        attackButton.SetActive(false);

        isCountdown = false;
        
        timeCountdown = 5f;
        timeCountdownCounter = timeCountdown;

        HPFish = 10f;
        HPFishCounter = HPFish;
    }

    void Update()
    {
        CountdownAttackFish();
        WinLoseCondition();
    }

    private void CountdownAttackFish()
    {
        if (isCountdown == true)
        {
            timeCountdownCounter -= 1 * Time.deltaTime;
            attackTimeRemaining.SetText(timeCountdownCounter.ToString("0"));
        }
        if(isCountdown == false)
        {
            timeCountdownCounter = timeCountdown;
        }
    }

    private void WinLoseCondition()
    {
        if (timeCountdownCounter <= 0)
        {
            isCountdown = false;
            Debug.Log("Lose");
        }

        if (HPFishCounter <= 0)
        {
            isCountdown = false;
            Debug.Log("Win");
        }
    }

    private IEnumerator isFishing(float FishingDuration)
    {
        startFishButton.SetActive(false);
        isFishingText.SetActive(true);
        yield return new WaitForSecondsRealtime(FishingDuration);
        isFishingText.SetActive(false);
        catchButton.SetActive(true);
        HPFishFill.fillAmount = 1;
    }

    public void StartFishingButton()
    {
        StartCoroutine(isFishing(2f));
    }

    public void CatchButton()
    {
        catchButton.SetActive(false);
        attackButton.SetActive(true);
    }

    public void AttackButton()
    {
        isCountdown = true;
        HPFishCounter -= 1f;
        HPFishFill.fillAmount = HPFishCounter / 10;
        Debug.Log("HP"+ HPFishCounter);
    }
}
