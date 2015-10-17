using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {
#region Variables
    //Static variables
    public static string Email = "";
    public static string Password = "";

    //Public Variables
    public string currentMenu = "Login";

    //Private Variables
    private string creatAccountUrl = "";
    private string loginUrl = "";
    private string confirmEmail = "";
    private string confirmPass = "";
    private string createEmail = "";
    private string createPass = "";

    //GUI test section
    public float x;
    public float y;
    public float myWidth;
    public float myHeight;

#endregion

    // Use this for initialization
    void Start ()
    {
	
	}// End Start Function

    // Main GUI Function
    void OnGUI()
    {
        //Depending on the value of currentMenu, then display the corresponding
        //GUI with appropriate function call
        if(currentMenu == "Login"){
            //Call the login GUI
            LoginGUI();
        }else if(currentMenu == "CreateAccount"){
            //Call the create account GUI
            CreateAccountGUI();
        }
    }// End OnGUI

#region Custom Functions
    //This method will login to the accounts
    void LoginGUI()
    {
        //Box to simulate login window
        GUI.Box(new Rect(Screen.width / 4, Screen.height / 5, Screen.width / 2,
            3 * Screen.height / 5), "Login");
        
        //Create account button and login button
        if(GUI.Button(new Rect(Screen.width / 3, 3 * Screen.height / 5, 
            Screen.width / 8, Screen.height / 20), "Create Account")){
            currentMenu = "CreateAccount";
        }
        if(GUI.Button(new Rect(Screen.width / 2, 3 * Screen.height / 5,
            Screen.width / 8, Screen.height / 20), "Login")) {

        }// End buttons

        //Email GUI
        GUI.Label(new Rect(2 * Screen.width / 5, 2 * Screen.height / 5 - 20,
            Screen.width / 3, Screen.height / 22), "Email");
        Email = GUI.TextField(new Rect(2 * Screen.width / 5,
            2 * Screen.height / 5, Screen.width / 3,
            Screen.height / 22), Email);

        //Password GUI
        GUI.Label(new Rect(2 * Screen.width / 5, 2 * Screen.height / 5 + 20,
            Screen.width / 3, Screen.height / 22), "Password");
        Password = GUI.TextField(new Rect(2 * Screen.width / 5, 
            2 * Screen.height / 5 + 40, Screen.width / 3,
            Screen.height / 22), Password);


    }//End LoginGUI Function

    // This function will be the GUI for creating the account
    void CreateAccountGUI()
    {
        //Box to simulate login window
        GUI.Box(new Rect(Screen.width / 4, Screen.height / 5, Screen.width / 2,
            3 * Screen.height / 5), "Create Account");

        //Email, password, and confirmation (input fields)
        //Email GUI
        GUI.Label(new Rect(2 * Screen.width / 5, 2 * Screen.height / 5 - 20,
            Screen.width / 3, Screen.height / 22), "Email");
        createEmail = GUI.TextField(new Rect(2 * Screen.width / 5,
            2 * Screen.height / 5, Screen.width / 3,
            Screen.height / 22), createEmail);

        //Password GUI
        GUI.Label(new Rect(2 * Screen.width / 5, 2 * Screen.height / 5 + 20,
            Screen.width / 3, Screen.height / 22), "Password");
        createPass = GUI.TextField(new Rect(2 * Screen.width / 5,
            2 * Screen.height / 5 + 40, Screen.width / 3,
            Screen.height / 22), createPass);

        //Email GUI
        GUI.Label(new Rect(2 * Screen.width / 5, 2 * Screen.height / 5 + 60,
            Screen.width / 3, Screen.height / 22), "Confirm Email");
        confirmEmail = GUI.TextField(new Rect(2 * Screen.width / 5,
            2 * Screen.height / 5 + 80, Screen.width / 3,
            Screen.height / 22), confirmEmail);

        //Password GUI
        GUI.Label(new Rect(2 * Screen.width / 5, 2 * Screen.height / 5 + 100,
            Screen.width / 3, Screen.height / 22), "Confirm Password");
        confirmPass = GUI.TextField(new Rect(2 * Screen.width / 5,
            2 * Screen.height / 5 + 120, Screen.width / 3,
            Screen.height / 22), confirmPass);
        //End input fields

        //Create random int field for bot protection


        //Open Create Account Window
        //create account button and back button
        if (GUI.Button(new Rect(Screen.width / 3, 4 * Screen.height / 5,
            Screen.width / 8, Screen.height / 20), "Create Account")){
            if ((confirmPass == createPass) && (confirmEmail == createEmail)) { 
                //StartCoroutine();
            }
            else{
                //StartCoroutine();
            }
        }//End Create Account

        //Login User
        if (GUI.Button(new Rect(Screen.width / 2, 4 * Screen.height / 5,
            Screen.width / 8, Screen.height / 20), "Back")){
            currentMenu = "Login";
        }// End buttons

    } // End CreateAccountGUI Method

#endregion

}
