using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncoderDecoder
{
  public partial class Form1 : Form
  {
    private Atbash coderAtbash = new Atbash();
    private Caesar coderCaesar = new Caesar();
    private PolybiusSquare coderPolybius = new PolybiusSquare();
    private PlayfairRectangle coderPlayfair = new PlayfairRectangle();
    private VigenereTable coderVigenere = new VigenereTable();
    private MethodOfPermutations coderPermutations = new MethodOfPermutations();
    private MethodXOR coderGamm = new MethodXOR();
    private AffineCryptosystem coderAffine = new AffineCryptosystem();

    public Form1()
    {
      InitializeComponent();
    }

    #region Atbash
    private void btnEncode1_Click(object sender, EventArgs e)
    {
      tbAtbash2.Text = string.Empty;
      tbAtbash2.Text += coderAtbash.encode(tbAtbash1.Text);

      //for (int i = 0; i < textBox1.Text.Length; i++)
      //{
        //textBox2.Text += (int)textBox1.Text[i];
      //}
    }

    private void btnDecode1_Click(object sender, EventArgs e)
    {
      tbAtbash2.Text = string.Empty;
      tbAtbash2.Text += coderAtbash.encode(tbAtbash1.Text);
    }
    #endregion

    #region Caesar
    private void btnCaesar1_Click(object sender, EventArgs e)
    {
      tbCaesar2.Text = string.Empty;
      tbCaesar2.Text += coderCaesar.encode(tbCaesar1.Text, Convert.ToInt32(tbCaesar3.Text));
    }

    private void btnCaesar2_Click(object sender, EventArgs e)
    {
      tbCaesar2.Text = string.Empty;
      tbCaesar2.Text += coderCaesar.decode(tbCaesar1.Text);
    }
    #endregion

    #region Polybius
    private void btnPolybius1_Click(object sender, EventArgs e)
    {
      tbPolybius2.Text = string.Empty;
      tbPolybius2.Text += coderPolybius.encode(tbPolybius1.Text);
    }

    private void btnPolybius2_Click(object sender, EventArgs e)
    {
      tbPolybius2.Text = string.Empty;
      tbPolybius2.Text += coderPolybius.decode(tbPolybius1.Text);
    }
    #endregion

    #region Playfair
    private void btnPlayfair1_Click(object sender, EventArgs e)
    {
      tbPlayfair2.Text = string.Empty;
      tbPlayfair2.Text += coderPlayfair.encode(tbPlayfair1.Text);
    }

    private void btnPlayfair2_Click(object sender, EventArgs e)
    {
      tbPlayfair2.Text = string.Empty;
      tbPlayfair2.Text += coderPlayfair.decode(tbPlayfair1.Text);
    }
    #endregion

    #region Vigenere
    private void btnVigenere1_Click(object sender, EventArgs e)
    {
      tbVigenere2.Text = string.Empty;
      tbVigenere2.Text += coderVigenere.encode(tbVigenere1.Text, tbVigenere3.Text);
    }

    private void btnVigenere2_Click(object sender, EventArgs e)
    {
      tbVigenere2.Text = string.Empty;
      tbVigenere2.Text += coderVigenere.decode(tbVigenere1.Text, tbVigenere3.Text);
    }
    #endregion

    #region Permutations
    private void btnPermutations1_Click(object sender, EventArgs e)
    {
      tbPermutations2.Text = string.Empty;
      tbPermutations2.Text += coderPermutations.encode(tbPermutations1.Text, cbPermutations1.SelectedItem.ToString(), 
        cbPermutations2.SelectedItem.ToString(), tbPermutations3.Text, tbPermutations4.Text);
    }

    private void btnPermutations2_Click(object sender, EventArgs e)
    {
      tbPermutations2.Text = string.Empty;
      tbPermutations2.Text += coderPermutations.decode(tbPermutations1.Text, cbPermutations1.SelectedItem.ToString(),
        cbPermutations2.SelectedItem.ToString(), tbPermutations3.Text, tbPermutations4.Text);
    }

    private void tabPage6_Enter(object sender, EventArgs e)
    {
      cbPermutations1.SelectedIndex = 0;
      cbPermutations2.SelectedIndex = 0;
    }
    #endregion

    #region MethodXOR
    private void btnGamm1_Click(object sender, EventArgs e)
    {
      tbGamm2.Text = string.Empty;
      tbGamm2.Text += coderGamm.encode(tbGamm1.Text, tbGamm3.Text);
    }

    private void btnGamm2_Click(object sender, EventArgs e)
    {
      tbGamm2.Text = string.Empty;
      tbGamm2.Text += coderGamm.encode(tbGamm1.Text, tbGamm3.Text);
    }
    #endregion

    #region Affine cpyptosystem
    private void btnAffineEncode_Click(object sender, EventArgs e)
    {
      tbAffine2.Text = string.Empty;
      tbAffine2.Text += coderAffine.encode(tbAffine1.Text, tbAffine3.Text, tbAffine4.Text);
    }

    private void btnAffineDecode_Click(object sender, EventArgs e)
    {
      tbAffine2.Text = string.Empty;
      tbAffine2.Text += coderAffine.encode(tbAffine1.Text, tbAffine3.Text, tbAffine4.Text);
    }
    #endregion
  }
}
