using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public float Cash = 0f;
    public float BankAccount = 0f;

    public TextMeshProUGUI CashText;
    public TextMeshProUGUI BankAccountText;

    private void Start()
    {
        UpdateUI();
    }

    public void AddCash(float amount)
    {
        Cash += amount;
        UpdateUI();
    }

    public void AddToBankAccount(float amount)
    {
        BankAccount += amount;
        UpdateUI();
    }

    public bool WithdrawFromBankAccount(float amount)
    {
        if (BankAccount >= amount)
        {
            BankAccount -= amount;
            UpdateUI();
            return true;
        }
        return false;
    }

    public bool DepositToBankAccount(float amount)
    {
        if (Cash >= amount)
        {
            Cash -= amount;
            BankAccount += amount;
            UpdateUI();
            return true;
        }
        return false;
    }

    private void UpdateUI()
    {
        CashText.text = "$ " + Cash.ToString();
        BankAccountText.text = "$ " + BankAccount.ToString();
    }
}
