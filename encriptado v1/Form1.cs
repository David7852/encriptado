using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace encriptado_v1
{
    public partial class Form1 : Form, encriptor
    {
        String key,text,outtext;
        public Form1()
        {
            InitializeComponent();
            key = "";
            text = "";
            outtext = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            key = textBox1.Text;
        }

        private void filechoose(object sender, EventArgs e)
        {            
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Title = "Seleccione un archivo para procesar";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    label2.Text ="Cargado: "+ openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\')+1);
                    text = File.ReadAllText(file);
                }
                catch (IOException)
                {                }
            }
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void encriptar(object sender, EventArgs e)
        {
            if(key.Length==0)
            {
                string message = "Ingrese una contraseña primero";
                string caption = "Error de contraseña";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            else if(key.Length < 5)
            {
                string message = "La contraseña debe tener al menos 5 caracteres";
                string caption = "Error de contraseña";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                outtext = encripting(keyfix(key),text);
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "DefaultOutputName.txt";
                save.Filter = "Text File | *.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.Write(outtext);
                    writer.Dispose();
                    writer.Close();
                }
            }
        }

        private void desencriptar(object sender, EventArgs e)
        {
            if (key.Length == 0)
            {
                string message = "Ingrese una contraseña primero";
                string caption = "Error de contraseña";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            else if (key.Length < 5)
            {
                string message = "La contraseña debe tener al menos 5 caracteres";
                string caption = "Error de contraseña";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                outtext = decripting(keyfix(key), text);
                SaveFileDialog save = new SaveFileDialog();
                save.FileName = "DefaultOutputName.txt";
                save.Filter = "Text File | *.txt";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile());
                    writer.Write(outtext);
                    writer.Dispose();
                    writer.Close();
                }
            }
        }
        
        public string encripting(int[] key, string subject)
        {
            char[] res = subject.ToCharArray();
            int s = res.Length - 1;
            foreach(int k in key)
            {
                for(int i=0;i<s;i++)
                {
                    if (i % 2 == 0 && i < s - 1)
                    {
                        char aux = res[i];
                        res[i] = res[i + 2];
                        res[i + 2] = aux;
                    }
                    else
                    {
                        char aux = res[i];
                        res[i] = res[i + 1];
                        res[i + 1] = aux;
                    }
                }
                mask(k * ((key.Length + (int)(s/4))*(key.Length + (int) (s/4))), ref res);
            }
            mask(getbyte(key),ref res);
            String result = new string(res);
            return result;
        }

        public string decripting(int[] key, string subject)
        {
            char[] res = subject.ToCharArray();
            int s = res.Length - 1;
            mask(getbyte(key), ref res);
            for (int x=key.Length-1;x>=0;x--)
            {
                int k = key[x];
                mask(k * ((key.Length + (int)(s / 4)) * (key.Length + (int)(s / 4))), ref res);
                for (int i=s;i>=1;i--)
                {
                    if (i % 2 == 0)
                    {
                        char aux = res[i];
                        res[i] = res[i - 2];
                        res[i - 2] = aux;
                    }
                    else
                    {
                        char aux = res[i];
                        res[i] = res[i - 1];
                        res[i - 1] = aux;
                    }
                    
                }
            }
            String result = new string(res);
            return result;
        }

        public void mask(int key,ref char[] subject)
        {
            for(int c=0;c<subject.Length;c++)
            {
                subject[c] = (char)(subject[c] ^ key);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int[] keyfix(String key)
        {
            char[] res = key.ToCharArray();
            int[] i = new int[res.Length];
            for(int c=0;c<i.Length;c++)
            {
                i[c] = res[c];
            }
            return i;
        }

        public int getbyte(int[] key)
        {
            int c = 0;
            foreach(int k in key)
            {
                c += k;
            }
            return c;
        }        
    }
}