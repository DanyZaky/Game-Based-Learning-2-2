using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Fishing : MonoBehaviour
{
    [SerializeField] private GameObject isFishingText, startFishButton, catchButton, EndFishedButton, stopFishingButton, attackButton, IkanPaus;

    [SerializeField] private TextMeshProUGUI attackTimeRemaining, winLoseText;
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
        IkanPaus.SetActive(false);

        attackTimeRemaining.gameObject.SetActive(false);
        winLoseText.gameObject.SetActive(false);

        isCountdown = false;
        
        timeCountdown = 5f;
        timeCountdownCounter = timeCountdown;

        HPFish = 10f;
        HPFishCounter = HPFish;

        stopFishingButton.SetActive(false);
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
            isFished("Lose", 1f);
            EndFishedButton.SetActive(true);
            stopFishingButton.SetActive(true);
            HPFishCounter = HPFish;
        }

        if (HPFishCounter <= 0)
        {
            isCountdown = false;
            Debug.Log("Win");
            isFished("Win", 1f);
            EndFishedButton.SetActive(true);
            stopFishingButton.SetActive(true);
            HPFishCounter = HPFish;
        }
    }

    private void isFished(string winLose, float endDuration)
    {
        winLoseText.gameObject.SetActive(true);
        winLoseText.SetText(winLose);
        IkanPaus.SetActive(false);
        attackButton.SetActive(false);
    }

    private IEnumerator isFishing(float FishingDuration)
    {
        EndFishedButton.SetActive(false);
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
        
        isCountdown = true;
        attackTimeRemaining.gameObject.SetActive(true);

        IkanPaus.SetActive(true);
    }

    public void AttackButton()
    {
        
        HPFishCounter -= 1f;
        HPFishFill.fillAmount = HPFishCounter / 10;
        Debug.Log("HP"+ HPFishCounter);
    }

    public void FishedButton()
    {
        EndFishedButton.SetActive(false);
        winLoseText.gameObject.SetActive(false);
        stopFishingButton.SetActive(false);
        StartCoroutine(isFishing(2f));
    }

    public void EndFishingButton()
    {
        EndFishedButton.SetActive(false);
        winLoseText.gameObject.SetActive(false);
        stopFishingButton.SetActive(false);
        startFishButton.SetActive(true);
    }
    //tes
}
