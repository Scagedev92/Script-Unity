using UnityEngine;
using UnityEngine.UI;

public class BankTellerActivator : MonoBehaviour
{
    public BankTeller BankTellerScript;
    public GameObject UI;
    public Button WorkButton;
    public Button CloseButton;

    private void Start()
    {
        UI.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(true);
            WorkButton.onClick.AddListener(WorkAndCloseUI);
            CloseButton.onClick.AddListener(StopWorkAndCloseUI);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UI.SetActive(false);
            WorkButton.onClick.RemoveAllListeners();
            CloseButton.onClick.RemoveAllListeners();
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void WorkAndCloseUI()
    {
        if (!BankTellerScript.isWorking)
            BankTellerScript.StartWork();
        UI.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void StopWorkAndCloseUI()
    {
        if (BankTellerScript.isWorking)
            BankTellerScript.StopWork();
        UI.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
