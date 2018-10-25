//Made by krlosflip

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
namespace OtpNet
{
    public class OTPTokenGenerator : MonoBehaviour
    {

        public Text mText;

		Totp mOTP;

		void Start(){
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            Byte[] bytes = Encoding.UTF8.GetBytes("0123456789");
            mOTP = new Totp(bytes, 1);
		}

        public void GenerateOTP()
        {
            mText.text = mOTP.ComputeTotp();
        }

    }
}
