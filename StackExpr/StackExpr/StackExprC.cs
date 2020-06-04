using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackExpr
{
    class StackExprC
    {
        struct exvar
        {
            public bool v;
            public double val;
        }
        string PostExpr;
        exvar[] Vars = new exvar[26];
        Stack ExStack = new Stack();
        private byte ICP(char c)
        {
            byte tmp = 4;
            if (c == '(')
                tmp = 0;
            if ((c == '*') | (c == '/'))
                tmp = 1;
            if ((c == '+') | (c == '-'))
                tmp = 2;
            if (c == ')')
                tmp = 3;
            return tmp;
        }
        private byte ISP(char c)
        {
            byte tmp = 4;
            if ((c == '*') | (c == '/'))
                tmp = 1;
            if ((c == '+') | (c == '-'))
                tmp = 2;
            if ((c == '(') | (c == '#'))
                tmp = 3;
            return tmp;
        }
        public string InfToPostf(string _Expr)
        {
            int a, z, i;
            char tmp;
            ExStack.Push('#');
            PostExpr = "";
            a = Convert.ToInt32('a');
            z = Convert.ToInt32('z');
            for (i = 0; i < 26; i++)
                Vars[i].v = false;
            for (i = 0; i < _Expr.Length; i++)
                if ((Convert.ToInt32(_Expr[i]) >= a) & (Convert.ToInt32(_Expr[i]) <= z))
                {
                    PostExpr = PostExpr + _Expr[i];
                    Vars[Convert.ToInt32(_Expr[i]) - a].v = true;
                }
                else
                {
                    tmp = Convert.ToChar(ExStack.Pop());
                    while (ISP(tmp) < ICP(_Expr[i]))
                    {
                        if (!(tmp == '('))
                        {
                            if (tmp != ')')
                                PostExpr = PostExpr + tmp;
                        }
                        tmp = Convert.ToChar(ExStack.Pop());
                    }
                    if (!((tmp == '(') && (_Expr[i] == ')')))
                    {
                        ExStack.Push(tmp);
                        if (!(_Expr[i] == ')'))
                            ExStack.Push(_Expr[i]);
                    }
                }
            tmp = Convert.ToChar(ExStack.Pop());
            while (!(tmp == '#'))
            {
                PostExpr = PostExpr + tmp;
                tmp = Convert.ToChar(ExStack.Pop());
            }
            return PostExpr;
        }
        public void ShowId(DataGridView _dgVal)
        {
            int a, i,j;            
            a = Convert.ToByte('a');
            _dgVal.RowCount=1;
            j = 0;
            for (i=0;i<26;i++)
                if (Vars[i].v)
                {
                    _dgVal.RowCount=_dgVal.RowCount+1;
                    _dgVal.Rows[j].Cells[0].Value = Convert.ToChar(a + i).ToString();
                    j = j + 1;
                }
        }
        public bool PutVal(DataGridView _dgVal)
        {
            int a, i, j;
            bool tmp;
            string id, val;
            a = Convert.ToByte('a');
            tmp = true;
            for (i = 0; i < _dgVal.RowCount-1;i++ )
            {
                id = _dgVal.Rows[i].Cells[0].Value.ToString();
                j=Convert.ToByte(Convert.ToChar(id));
                val = _dgVal.Rows[i].Cells[1].Value.ToString();
                tmp = tmp & Double.TryParse(val, out Vars[j-a].val); 
            }
                               
            return tmp;
        }
        public string CalcExpr()
        {
            int a, z, i;
            double op1, op2;
            a = Convert.ToByte('a');
            z = Convert.ToInt32('z');
            for (i = 0; i < PostExpr.Length; i++)
                if ((Convert.ToInt32(PostExpr[i]) >= a) & (Convert.ToInt32(PostExpr[i]) <= z))
                    ExStack.Push(Vars[Convert.ToInt32(PostExpr[i])-a].val);
                else
                {
                    op2 = Convert.ToDouble(ExStack.Pop().ToString());
                    op1 = Convert.ToDouble(ExStack.Pop().ToString());
                    if (PostExpr[i] == '+')
                        ExStack.Push(op1 + op2);
                    if (PostExpr[i] == '-')
                        ExStack.Push(op1 - op2);
                    if (PostExpr[i] == '*')
                        ExStack.Push(op1 * op2);
                    if (PostExpr[i] == '/')
                        ExStack.Push(op1 / op2);
                }
            return ExStack.Pop().ToString();
        }
    }
}
