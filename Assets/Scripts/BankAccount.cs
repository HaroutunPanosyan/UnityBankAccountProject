using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BankAccount : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_InputField deposit;
    //public InputField deposit;
    [SerializeField]
    TMPro.TMP_Text depositText;
    //public InputField withdraw;
    private double _balance = 0.0; 
    public double Deposit(double input) 
    {
        return _balance += input;       
    } 
    public double Withdraw(double input)
    {
        return _balance -= input;
    }
    public double GetBalance() 
    { 
        return _balance; 
    }     

}
