using UnityEngine;

public class BankTeller : MonoBehaviour
{
    public float SalaryPerSecond = 0.05f;
   

    private Wallet _wallet;
    public bool isWorking;
    private float _timeWorked;
    private float _earnedSalary;

    private void Start()
    {
        _wallet = GetComponent<Wallet>();
    }

    private void Update()
    {
       

        if (isWorking)
        {
            _timeWorked += Time.deltaTime;
            _earnedSalary = _timeWorked * SalaryPerSecond;
        }
    }

    public void StartWork()
    {
        isWorking = true;
    }

    public void StopWork()
    {
        isWorking = false;
        _wallet.AddToBankAccount(_earnedSalary);
        _timeWorked = 0f;
        _earnedSalary = 0f;
    }
}
