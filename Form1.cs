using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        private const int MinP = 0;
        private const int MinQ = 0;
        private const int MinB = 0;
        private const int MaxB = 10533;
        private BigInteger[] plaintext = [];
        private BigInteger[] ciphertext = [];


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void plaintextOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "�������� ���� ��� ��������";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    // ������ ���������� �����
                    byte[] buffer = File.ReadAllBytes(filePath);
                    // ��������� � BigInteger
                    plaintext = buffer
                        .Select(message => new BigInteger(message))
                        .ToArray();
                    // ��������� �������
                    tbPlaintext.Text = string.Join(' ', plaintext);
                }
                catch
                {
                    MessageBox.Show("������ ��� �������� �����!");
                }
            }
        }

        private async void ciphertextOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "�������� ���� ��� ��������";
            openFileDialog.Multiselect = false;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ������ ���������� �����
                    plaintext = await Program.ReadEncryptedFileAsync(openFileDialog.FileName);

                    // ��������� �������
                    tbPlaintext.Text = string.Join(' ', plaintext);
                    tbCiphertext.Text = "";
                }
                catch
                {
                    MessageBox.Show("������ ��� �������� �������������� �����!");
                }
            }
        }

        private async void plaintextSaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "�������� ���� ��� ����������";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] buffer = ciphertext
                        .Select(message => message.ToByteArray().First())
                        .ToArray();

                try
                {
                    // ���������� � ���� 
                    await Program.SaveFile(saveFileDialog.FileName, buffer);
                }
                catch
                {
                    MessageBox.Show("������ ��� ���������� � ����!");
                }
            }
        }

        private async void ciphertextSaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "�������� ���� ��� ����������";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // ���������� � ���� 
                    await Program.SaveFile(saveFileDialog.FileName, ciphertext);
                }
                catch
                {
                    MessageBox.Show("������ ��� ���������� � ����!");
                }
            }
        }

        private void btnEbcrypt_Click(object sender, EventArgs e)
        {
            BigInteger p, q, b;
            try
            {
                p = BigInteger.Parse(tbP.Text);
                q = int.Parse(tbQ.Text);
                b = int.Parse(tbB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�������� ����", "������");
                return;
            }

            if (!Program.IsCorrectParam(p, MinP, "p", out var error))
            {
                MessageBox.Show(error, "������");
                return;
            }

            if (!Program.IsCorrectParam(q, MinQ, "q", out error))
            {
                MessageBox.Show(error, "������");
                return;
            }

            if (!Program.IsCorrectParamB(b, MinB, MaxB, "b", out error))
            {
                MessageBox.Show(error, "������");
                return;
            }

            BigInteger n = p * q;
            tbN.Text = n.ToString();

            ciphertext = Program.Encrypt(new OpenKey(n, b), plaintext);

            tbCiphertext.Text = string.Join(' ', ciphertext);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            BigInteger p, q, b;
            try
            {
                p = BigInteger.Parse(tbP.Text);
                q = int.Parse(tbQ.Text);
                b = int.Parse(tbB.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("�������� ����", "������");
                return;
            }


            if (!Program.IsCorrectParam(p, MinP, "p", out var error))
            {
                MessageBox.Show(error, "������");
                return;
            }

            if (!Program.IsCorrectParam(q, MinQ, "q", out error))
            {
                MessageBox.Show(error, "������");
                return;
            }

            if (!Program.IsCorrectParamB(b, MinB, MaxB, "b", out error))
            {
                MessageBox.Show(error, "������");
                return;
            }

            BigInteger n = p * q;
            tbN.Text = n.ToString();

            ciphertext = Program.Decrypt(new OpenKey(n, b), new PrivateKey(p, q), plaintext);

            tbCiphertext.Text = string.Join(' ', ciphertext);
        }
    }
}
