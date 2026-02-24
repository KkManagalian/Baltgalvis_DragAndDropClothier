using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Windows;
using static System.Net.Mime.MediaTypeNames;

public class TextStuff : MonoBehaviour
{
    private string name;
    private int age;
    private int currentYear = DateTime.Now.Year;
    private int year;
    public GameObject nameInputField;
    public GameObject yearInputField;
    public GameObject textField;

    public void getText()
    {
        year = int.Parse(yearInputField.GetComponent<TMP_InputField>().text);
        age = currentYear - year;

        if(age<0 || age > 100)
        {
            textField.GetComponent<TMP_Text>().text = "Skeletona vecums nav derīgs!";

        } else
        {
            name = nameInputField.GetComponent<TMP_InputField>().text;
            textField.GetComponent<TMP_Text>().text = "Skeletons " + name + " ir " + age + " gadus vecs!";
        }

        

    }

}
