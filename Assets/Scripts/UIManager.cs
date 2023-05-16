using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject loginPanel, signupPanel, placeholderPanel, forgetPasswordPanel, notificationPanel;
    public InputField loginEmail, loginPassword, signupEmail, signupPassword, signupCPasswords, signupUserName, forgetPasswordEmail;
    public Text notif_Title_Text, notif_Message_Text, profileUserName_Text, profileUserEmail_Text;
    public Toggle rememberMe;

    public void OpenLoginPanel()
    {
        loginPanel.SetActive(true);
        signupPanel.SetActive(false);
        placeholderPanel.SetActive(false);
        forgetPasswordPanel.SetActive(false);
    }

    public void OpenSignUpPanel()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(true);
        placeholderPanel.SetActive(false);
        forgetPasswordPanel.SetActive(false);
    }

    public void OpenProfilePanel()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(false);
        placeholderPanel.SetActive(true);
        forgetPasswordPanel.SetActive(false);
    }

    public void OpenForgetPasswordPanel()
    {
        loginPanel.SetActive(false);
        signupPanel.SetActive(false);
        placeholderPanel.SetActive(false);
        forgetPasswordPanel.SetActive(true);
    }

    public void LoginUser()
    {
        if (string.IsNullOrEmpty(loginEmail.text) && string.IsNullOrEmpty(loginPassword.text))
        {
            ShowNotificationMessage("Error", "Fields Empty! Please Input All Details In All Fields");
            return;
        }
        // Do login
    }

    public void SignUpUser()
    {
        if (string.IsNullOrEmpty(signupEmail.text) && string.IsNullOrEmpty(signupPassword.text) && string.IsNullOrEmpty(signupCPasswords.text) && string.IsNullOrEmpty(signupUserName.text))
        {
            ShowNotificationMessage("Error", "Fields Empty! Please Input All Details In All Fields");
            return;
        }
        // Do SignUp
    }
    public void ForgetPassword()
    {
        if (string.IsNullOrEmpty(forgetPasswordEmail.text))
        {
            ShowNotificationMessage("Error", "Fields Empty! Please Input All Details In All Fields");
            return;
        }
        // Do Forget Password
    }

    private void ShowNotificationMessage(string title, string message)
    {
        notif_Title_Text.text = " " + title;
        notif_Message_Text.text = " " + message;
        notificationPanel.SetActive(true);
    }
    public void CloseNotificationMessage()
    {
        notif_Title_Text.text = " ";
        notif_Message_Text.text = " ";
        notificationPanel.SetActive(false);
    }
    public void LogOut()
    {
        profileUserEmail_Text.text = " ";
        profileUserName_Text.text = " ";
        OpenLoginPanel();
    }
}