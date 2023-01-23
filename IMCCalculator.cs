using UnityEngine;

public class IMCCalculator : MonoBehaviour
{
    public float height = 1.8f; // Height of the character in meters
    public float weight = 80.0f; // Weight of the character in kilograms
    public string imc;

    void Update()
    {
        float bmi = weight / (height * height); // Calculate the BMI
        Debug.Log("BMI: " + bmi); // Log the BMI to the console

        // Check if the BMI is within a healthy range
        if (bmi < 18.5f)
        {
            imc = "bajo peso";
            Debug.Log("Underweight");
        }
        else if (bmi >= 18.5f && bmi <= 24.9f)
        {
            imc = "Peso normal";
            Debug.Log("Normal weight");
        }
        else if (bmi >= 25.0f && bmi <= 29.9f)
        {
            imc = "Exceso de peso";
            Debug.Log("Overweight");
        }
        else if (bmi >= 30.0f)
        {
            imc = "Obesa";
            Debug.Log("Obese");
        }
    }
}
