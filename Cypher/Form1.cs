using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Cypher
{
    public partial class Form1 : Form
    {
        List<Encryptor> encryptors = new List<Encryptor>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            ActualInstructionsLB.Items.Add(AvailableInstructionsLB.SelectedItem.ToString());
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            ActualInstructionsLB.Items.Remove(ActualInstructionsLB.SelectedItem);
        }

        private void UpBTN_Click(object sender, EventArgs e)
        {
            if (ActualInstructionsLB.SelectedIndex != 0)
            {
                string temp = ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex - 1].ToString();
                ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex - 1] = ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex];
                ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex] = temp;
                ActualInstructionsLB.SelectedIndex -= 1;
            }
        }

        private void DownBTN_Click(object sender, EventArgs e)
        {

            if (ActualInstructionsLB.SelectedIndex != ActualInstructionsLB.Items.Count - 1)
            {
                string temp = ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex + 1].ToString();
                ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex + 1] = ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex];
                ActualInstructionsLB.Items[ActualInstructionsLB.SelectedIndex] = temp;
                ActualInstructionsLB.SelectedIndex += 1;
            }
        }

        private void AvailableInstructionsLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ActualInstructionsLB.Items.Add(AvailableInstructionsLB.SelectedItem.ToString());
        }

        private void ActualInstructionsLB_DoubleClick(object sender, EventArgs e)
        {
            ActualInstructionsLB.Items.Remove(AvailableInstructionsLB.SelectedItem.ToString());
        }
        char IncrementSymbolCode(char symbolCode)
        {
            return (char)((int)symbolCode + 1);
        }
        char DecrementSymbolCode(char symbolCode)
        {
            return (char)((int)symbolCode - 1);
        }
        char ZeroSymbolCode(char symbolCode)
        {
            return symbolCode;
        }

        private void CryptBTN_Click(object sender, EventArgs e)
        {
            encryptors.Clear();
            KeyTB.Text = string.Empty;
            OutputTB.Text = string.Empty;
            foreach (string functionName in ActualInstructionsLB.Items)
            {
                switch (functionName)
                {
                    case "Inc(+1)":
                        encryptors.Add(new Encryptor(IncrementSymbolCode, "Increment", "I"));
                        KeyTB.Text += "I";
                        break;
                    case "Dec(-1)":
                        encryptors.Add(new Encryptor(DecrementSymbolCode, "Decrement", "D"));
                        KeyTB.Text += "D";
                        break;
                    case "Zero(0)":
                        encryptors.Add(new Encryptor(ZeroSymbolCode, "Zero", "Z"));
                        KeyTB.Text += "Z";
                        break;
                }
            }
            for (int i = 0; i < InputTB.Text.Length; i++)
            {
                OutputTB.Text += encryptors[i % encryptors.Count].encrypt(InputTB.Text[i]);
            }


        }

        private void DeCryptBTN_Click(object sender, EventArgs e)
        {
            Decryptor decryptor = new Decryptor();
            DecryptedTB.Text = decryptor.Decrypt(KeyTB.Text, OutputTB.Text);    
        }
    }
}
