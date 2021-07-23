using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExploreSectionController : MonoBehaviour
{

    public Animator InvestmentAnimator;
    public GameObject Investmentsubtopics;

    public Animator loanAnimator;
    public GameObject loanSubtopics;

    public Animator insuranceAnimator;
    public GameObject insuranceSubtopics;

    public bool investmentSubtopicsState = false;
    public bool loanSubtopicsState = false;
    public bool insuranceSubtopicsState = false;

    public void enableInvestmentSubtopics()
    {
        investmentSubtopicsState = !investmentSubtopicsState;
        Investmentsubtopics.SetActive(investmentSubtopicsState);
        InvestmentAnimator.enabled = investmentSubtopicsState;
    }
    
    public void enableLoanSubtopics()
    {
        loanSubtopicsState = !loanSubtopicsState;
        loanSubtopics.SetActive(loanSubtopicsState);
        loanAnimator.enabled = loanSubtopicsState;
    }

    public void enableInsuranceSubtopics()
    {
        insuranceSubtopicsState = !insuranceSubtopicsState;
        insuranceSubtopics.SetActive(insuranceSubtopicsState);
        insuranceAnimator.enabled = insuranceSubtopicsState;
    }


    public void enable()
    {
        this.gameObject.SetActive(true);
        this.GetComponent<Animator>().enabled = true;
    }

    public void disable()
    {
        this.gameObject.SetActive(false);
        this.GetComponent<Animator>().enabled = true;
    }
}
