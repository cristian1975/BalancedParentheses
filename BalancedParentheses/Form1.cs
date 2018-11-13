using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancedParentheses
{
    public partial class BalancedParantheses : Form
    {
        public BalancedParantheses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;
            
            (bool isMatched, int idx) = IsMatchedParentheses(text);

            if (isMatched)
            {
                lblMessage.Text="Parentheses are in balance.";
                lblMessage.ForeColor = Color.DarkGreen;
            }
            else
            {
                try
                {
                    string ErrText = text.Substring(idx - 3, 7).Replace(" ", ".");
                    lblMessage.Text = "The error is:" + ErrText;
                    lblMessage.ForeColor = Color.DarkRed;
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Parentheses are not in balance but error message cannot be displayed in requested format ( 3 characters before and after the error)";
                    lblMessage.ForeColor = Color.DarkRed;
                }

            }
            lblMessage.Visible = true;

        }

        public static (bool isMatched, int idx) IsMatchedParentheses(string text)
        {
            Stack<char> st = new Stack<char>();
            char[] chars = text.ToCharArray();
            int i = 0;
            for (i = 0; i < chars.Length; i++)
            {
                switch (chars[i])
                {
                    case '{':
                    case '[':
                    case '(':
                        st.Push(chars[i]);
                        break;
                    case '}':
                        if (st.Count == 0 || (st.Count() > 0 && st.Pop() != '{'))
                        {
                            return (false, i);
                        }
                        break;
                    case ']':
                        if (st.Count == 0 || (st.Count() > 0 && st.Pop() != '['))
                        {
                            return (false, i);
                        }
                        break;
                    case ')':
                        if (st.Count == 0 || (st.Count() > 0 && st.Pop() != '(' ))
                        {
                            return (false, i);
                        }                    
                        break;
                }

            }

            return (st.Count == 0, i);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }
    }
}
