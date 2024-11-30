using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasiskiAnalyzer
{
    public partial class MainAnalyzer : Form
    {
        public MainAnalyzer()
        {
            InitializeComponent();


            keyLength.Value = 2;
            selectLetter.Value = 1;
            buttonCopy.Text = key.ToString();

            keyLength.ValueChanged += (object? sender, EventArgs e) =>
            {
                if (keyLength.Value < 2)
                {
                    keyLength.Value = 2;
                    return;
                }

                if (keyLength.Value < key.Length)
                {
                    int l = key.Length;
                    for(int i = 0; i < l - keyLength.Value; i++)
                    {
                        key.Length--;
                    }
                }
                else if(keyLength.Value > key.Length)
                {
                    int l = key.Length;
                    for (int i = l; i < keyLength.Value; i++)
                    {
                        key.Append('a');
                    }
                }

                buttonCopy.Text = key.ToString();
            };
            selectLetter.ValueChanged += (object? sender, EventArgs e) =>
            {
                if (selectLetter.Value < 1)
                {
                    selectLetter.Value = 1;
                    return;
                }
                if (selectLetter.Value > key.Length)
                {
                    selectLetter.Value = key.Length;
                    return;
                }


                for(int i = 0; i < key.Length; i++)
                {
                    key[i] = Char.ToLower(key[i]);
                }
                
                buttonCopy.Text = key.ToString();
                key[(int)selectLetter.Value - 1] = (char)(key[(int)selectLetter.Value - 1] - ('a' - 'A'));


                
                shiftLetter.Value = key[(int)selectLetter.Value - 1] - 'A';


                buttonCopy.Text = key.ToString();
            };
            shiftLetter.ValueChanged += (object? sender, EventArgs e) =>
            {
                if (shiftLetter.Value > 25)
                {
                    shiftLetter.Value = 25;
                    return;
                }

                key.Clear();
                key.Append(buttonCopy.Text);

                key[(int)selectLetter.Value - 1] = (char)(shiftLetter.Value + 'A');

                buttonCopy.Text = key.ToString();
                keyChar.Text = key[(int)selectLetter.Value - 1].ToString();
            };

            buttonCopy.Click += (object? sender, EventArgs e) =>
            {
                keyInput.Text = key.ToString().ToLower();

                KasiskiAnalyzer.Main.textHandler.SetKey(key.ToString());
                KasiskiAnalyzer.Main.textHandler.DecodeCrypted();

                // KasiskiAnalyzer.Main.textCryptedText.Text = new String(KasiskiAnalyzer.Main.textHandler.cryptedText);
                // KasiskiAnalyzer.Main.textProcessedText.Text = new String(KasiskiAnalyzer.Main.textHandler.decodedText);
            };
        }
    }
}
