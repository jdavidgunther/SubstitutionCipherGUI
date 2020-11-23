using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubstitutionGUI
{
    public partial class Cypher : Form
    {
        public Cypher()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e)
        {
            string code;            
            string alphabet = " abcdefghijklmnopqrstuvwxyz0123456789";
            char[] alphabetCharArray = alphabet.ToCharArray();

            code = Codes.Text;

            char[] inputArray = code.ToCharArray();
            int shift = 5;
            string output = "";
            bool isValid = true;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int index = Array.IndexOf(alphabetCharArray, inputArray[i]);
                if (index == -1)
                {
                    isValid = false;
                    break;
                }
                index = index + shift;
                if (index >= alphabetCharArray.Length)
                {
                    index = index - alphabetCharArray.Length;
                }                
                //Console.WriteLine(index);
                //Use an if statement to see if the shifted index is higher than the total array length.


                //Console.WriteLine($"{inputArray[i]}: new index: {index}");
                //Get the shifted characther from array using the your new index number.
                //Console.WriteLine($"{inputArray[i]} becomes {alphabetCharArray[index]}");
                //Combine all the new characthers and create the new sentence
                output += alphabetCharArray[index];                               
            }
            if (isValid)
            {
                codeOutput.Text = output;
                Invalid.Text = "Valid";
            }
            else
            {
                Invalid.Text = "Invalid";
            }

        }

        private void Decode_Click(object sender, EventArgs e)
        {
            string code;
            string alphabet = " abcdefghijklmnopqrstuvwxyz0123456789";
            char[] alphabetCharArray = alphabet.ToCharArray();

            code = Codes.Text;

            char[] inputArray = code.ToCharArray();
            int shift = 5;
            string output = "";
            bool isValid = true;

            for (int i = 0; i < inputArray.Length; i++)
            {
                int index = Array.IndexOf(alphabetCharArray, inputArray[i]);
                if (index == -1)
                {
                    isValid = false;
                    break;
                }
                index = index - shift;
                if (index < 0)
                {
                    index = index + alphabetCharArray.Length;
                }
                //Console.WriteLine(index);
                //Use an if statement to see if the shifted index is higher than the total array length.


                //Console.WriteLine($"{inputArray[i]}: new index: {index}");
                //Get the shifted characther from array using the your new index number.
                //Console.WriteLine($"{inputArray[i]} becomes {alphabetCharArray[index]}");
                //Combine all the new characthers and create the new sentence
                output += alphabetCharArray[index];
            }
            if (isValid)
            {
                codeOutput.Text = output;
                Invalid.Text = "Valid";
            }
            else
            {
                Invalid.Text = "Invalid";
            }

        }
    }
}
