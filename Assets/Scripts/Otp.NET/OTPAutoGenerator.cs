//Made by krlosflip

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
namespace OtpNet
{
    public class OTPAutoGenerator : MonoBehaviour
    {

        public List<Image> chargers;

        int count = 6;

		Totp mOTP;

		void Start(){
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            Byte[] bytes = Encoding.UTF8.GetBytes("0123456789");
            mOTP = new Totp(bytes, 18);
            GetComponent<Text>().text = mOTP.ComputeTotp();
            StartCoroutine(ReduceImages());
		}

        IEnumerator ReduceImages(){
            yield return new WaitForSeconds(3f);
            count--;
            if(count == 0){
                GetComponent<Text>().text = mOTP.ComputeTotp();
                foreach(Image g in chargers){
                    g.color = Color.white;
                }
                count = 6;
            } else {
                chargers[count].color = Color.clear;
            }
            StartCoroutine(ReduceImages());
        }
    }
}
