namespace WindowsApplication1
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    using WindowsApplication1.My;

    [DesignerGenerated]
    public class Form1 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("SN")]
        private TextBox _SN;
        [AccessedThroughProperty("KEY")]
        private TextBox _KEY;
        [AccessedThroughProperty("GroupBox1")]
        private GroupBox _GroupBox1;
        [AccessedThroughProperty("BAS")]
        private CheckBox _BAS;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("CWBQTY")]
        private TextBox _CWBQTY;
        [AccessedThroughProperty("CRMQTY")]
        private TextBox _CRMQTY;
        [AccessedThroughProperty("CRM")]
        private CheckBox _CRM;
        [AccessedThroughProperty("COPQTY")]
        private TextBox _COPQTY;
        [AccessedThroughProperty("COP")]
        private CheckBox _COP;
        [AccessedThroughProperty("BASQTY")]
        private TextBox _BASQTY;
        [AccessedThroughProperty("Label50")]
        private Label _Label50;
        [AccessedThroughProperty("Label40")]
        private Label _Label40;
        [AccessedThroughProperty("Label30")]
        private Label _Label30;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("Label49")]
        private Label _Label49;
        [AccessedThroughProperty("Label39")]
        private Label _Label39;
        [AccessedThroughProperty("Label29")]
        private Label _Label29;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("Label48")]
        private Label _Label48;
        [AccessedThroughProperty("Label38")]
        private Label _Label38;
        [AccessedThroughProperty("Label28")]
        private Label _Label28;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Label57")]
        private Label _Label57;
        [AccessedThroughProperty("Label47")]
        private Label _Label47;
        [AccessedThroughProperty("Label37")]
        private Label _Label37;
        [AccessedThroughProperty("Label27")]
        private Label _Label27;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("Label56")]
        private Label _Label56;
        [AccessedThroughProperty("Label46")]
        private Label _Label46;
        [AccessedThroughProperty("Label36")]
        private Label _Label36;
        [AccessedThroughProperty("Label26")]
        private Label _Label26;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("Label45")]
        private Label _Label45;
        [AccessedThroughProperty("Label35")]
        private Label _Label35;
        [AccessedThroughProperty("Label25")]
        private Label _Label25;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("Label44")]
        private Label _Label44;
        [AccessedThroughProperty("Label34")]
        private Label _Label34;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("Label43")]
        private Label _Label43;
        [AccessedThroughProperty("Label33")]
        private Label _Label33;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("Label52")]
        private Label _Label52;
        [AccessedThroughProperty("Label42")]
        private Label _Label42;
        [AccessedThroughProperty("Label32")]
        private Label _Label32;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("Label51")]
        private Label _Label51;
        [AccessedThroughProperty("Label41")]
        private Label _Label41;
        [AccessedThroughProperty("Label31")]
        private Label _Label31;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("WLBQTY")]
        private TextBox _WLBQTY;
        [AccessedThroughProperty("SCMQTY")]
        private TextBox _SCMQTY;
        [AccessedThroughProperty("PURQTY")]
        private TextBox _PURQTY;
        [AccessedThroughProperty("INVQTY")]
        private TextBox _INVQTY;
        [AccessedThroughProperty("WLB")]
        private CheckBox _WLB;
        [AccessedThroughProperty("SCM")]
        private CheckBox _SCM;
        [AccessedThroughProperty("PUR")]
        private CheckBox _PUR;
        [AccessedThroughProperty("INV")]
        private CheckBox _INV;
        [AccessedThroughProperty("SYSQTY")]
        private TextBox _SYSQTY;
        [AccessedThroughProperty("RMAQTY")]
        private TextBox _RMAQTY;
        [AccessedThroughProperty("PJMQTY")]
        private TextBox _PJMQTY;
        [AccessedThroughProperty("GZSQTY")]
        private TextBox _GZSQTY;
        [AccessedThroughProperty("SYS")]
        private CheckBox _SYS;
        [AccessedThroughProperty("RMA")]
        private CheckBox _RMA;
        [AccessedThroughProperty("PJM")]
        private CheckBox _PJM;
        [AccessedThroughProperty("GZS")]
        private CheckBox _GZS;
        [AccessedThroughProperty("ZCSQTY")]
        private TextBox _ZCSQTY;
        [AccessedThroughProperty("SXMQTY")]
        private TextBox _SXMQTY;
        [AccessedThroughProperty("RGSQTY")]
        private TextBox _RGSQTY;
        [AccessedThroughProperty("KJSQTY")]
        private TextBox _KJSQTY;
        [AccessedThroughProperty("GYSQTY")]
        private TextBox _GYSQTY;
        [AccessedThroughProperty("ZCS")]
        private CheckBox _ZCS;
        [AccessedThroughProperty("RGS")]
        private CheckBox _RGS;
        [AccessedThroughProperty("KJS")]
        private CheckBox _KJS;
        [AccessedThroughProperty("GYS")]
        private CheckBox _GYS;
        [AccessedThroughProperty("YSFQTY")]
        private TextBox _YSFQTY;
        [AccessedThroughProperty("YSF")]
        private CheckBox _YSF;
        [AccessedThroughProperty("SGMQTY")]
        private TextBox _SGMQTY;
        [AccessedThroughProperty("SGM")]
        private CheckBox _SGM;
        [AccessedThroughProperty("QMSQTY")]
        private TextBox _QMSQTY;
        [AccessedThroughProperty("QMS")]
        private CheckBox _QMS;
        [AccessedThroughProperty("JCAQTY")]
        private TextBox _JCAQTY;
        [AccessedThroughProperty("JCA")]
        private CheckBox _JCA;
        [AccessedThroughProperty("FIBQTY")]
        private TextBox _FIBQTY;
        [AccessedThroughProperty("FIB")]
        private CheckBox _FIB;
        [AccessedThroughProperty("REGSTR")]
        private TextBox _REGSTR;
        [AccessedThroughProperty("Label61")]
        private Label _Label61;
        [AccessedThroughProperty("Label62")]
        private Label _Label62;
        [AccessedThroughProperty("PW")]
        private TextBox _PW;
        [AccessedThroughProperty("Label63")]
        private Label _Label63;
        [AccessedThroughProperty("Label64")]
        private Label _Label64;
        [AccessedThroughProperty("Label54")]
        private Label _Label54;
        [AccessedThroughProperty("Label53")]
        private Label _Label53;
        [AccessedThroughProperty("ALLQTY")]
        private TextBox _ALLQTY;
        [AccessedThroughProperty("ALL")]
        private CheckBox _ALL;
        [AccessedThroughProperty("CWB")]
        private CheckBox _CWB;
        [AccessedThroughProperty("ToolTip1")]
        private ToolTip _ToolTip1;
        [AccessedThroughProperty("SXM")]
        private CheckBox _SXM;
        [AccessedThroughProperty("Label55")]
        private Label _Label55;
        [AccessedThroughProperty("CCode")]
        private TextBox _CCode;

        [DebuggerNonUserCode]
        public Form1()
        {
            this.InitializeComponent();
        }

        private void ALL_CheckStateChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
            {
                this.BAS.Checked = false;
                this.COP.Checked = false;
                this.CRM.Checked = false;
                this.CWB.Checked = false;
                this.FIB.Checked = false;
                this.GYS.Checked = false;
                this.GZS.Checked = false;
                this.INV.Checked = false;
                this.JCA.Checked = false;
                this.KJS.Checked = false;
                this.PJM.Checked = false;
                this.PUR.Checked = false;
                this.QMS.Checked = false;
                this.RGS.Checked = false;
                this.RMA.Checked = false;
                this.SCM.Checked = false;
                this.SGM.Checked = false;
                this.SXM.Checked = false;
                this.SYS.Checked = false;
                this.WLB.Checked = false;
                this.YSF.Checked = false;
                this.ZCS.Checked = false;
            }
        }

        public string b_to_h(string bin)
        {
            string str2 = null;
            if ((Strings.Len(bin) % 4) != 0)
            {
                bin = Strings.StrDup(4 - (Strings.Len(bin) % 4), "0") + bin;
            }
            int num2 = Strings.Len(bin);
            for (int i = 1; i <= num2; i += 4)
            {
                string str3 = Strings.Mid(bin, i, 4);
                if (str3 == "0000")
                {
                    str2 = str2 + "0";
                }
                else if (str3 == "0001")
                {
                    str2 = str2 + "1";
                }
                else if (str3 == "0010")
                {
                    str2 = str2 + "2";
                }
                else if (str3 == "0011")
                {
                    str2 = str2 + "3";
                }
                else if (str3 == "0100")
                {
                    str2 = str2 + "4";
                }
                else if (str3 == "0101")
                {
                    str2 = str2 + "5";
                }
                else if (str3 == "0110")
                {
                    str2 = str2 + "6";
                }
                else if (str3 == "0111")
                {
                    str2 = str2 + "7";
                }
                else if (str3 == "1000")
                {
                    str2 = str2 + "8";
                }
                else if (str3 == "1001")
                {
                    str2 = str2 + "9";
                }
                else if (str3 == "1010")
                {
                    str2 = str2 + "a";
                }
                else if (str3 == "1011")
                {
                    str2 = str2 + "b";
                }
                else if (str3 == "1100")
                {
                    str2 = str2 + "c";
                }
                else if (str3 == "1101")
                {
                    str2 = str2 + "d";
                }
                else if (str3 == "1110")
                {
                    str2 = str2 + "e";
                }
                else if (str3 == "1111")
                {
                    str2 = str2 + "f";
                }
            }
            return str2;
        }

        private void BAS_CheckStateChanged(object sender, EventArgs e)
        {
            if (Conversions.ToBoolean(NewLateBinding.LateGet(sender, null, "Checked", new object[0], null, null, null)))
            {
                this.ALL.Checked = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = this.CCode.Text;
            string qty = null;
            string str6 = "@@@2";
            string str5 = "";
            string str7 = "";
            qty = this.GetQty();
            string fn = this.GetFn();
            string fnAndQty = this.GetFnAndQty();
            string str3 = "%%%" + this.GetROL(this.REGSTR.Text);
            if (this.SN.Text == null)
            {
                MessageBox.Show("请输入安装代号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (this.CCode.Text == null)
            {
                MessageBox.Show("请输入客户代号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string[] strArray5;
                if (this.ALL.Checked)
                {
                    string[] strArray = new string[6];
                    strArray[1] = text;
                    strArray[2] = qty;
                    strArray[3] = fn;
                    strArray[4] = str6;
                    strArray[5] = str3;
                    int index = 1;
                    do
                    {
                        str7 = ((index % 2) == 0) ? (str7 + Strings.Right(strArray[index], 1)) : (str7 + Strings.Left(strArray[index], 1));
                        index++;
                    }
                    while (index <= 5);
                }
                else
                {
                    string[] strArray2 = new string[7];
                    strArray2[1] = text;
                    strArray2[2] = qty;
                    strArray2[3] = fn;
                    strArray2[4] = fnAndQty;
                    strArray2[5] = str6;
                    strArray2[6] = str3;
                    int index = 1;
                    do
                    {
                        str7 = ((index % 2) == 0) ? (str7 + Strings.Right(strArray2[index], 1)) : (str7 + Strings.Left(strArray2[index], 1));
                        index++;
                    }
                    while (index <= 6);
                }
                str5 = Strings.Left(this.getMd5Hash(text + qty + fn + fnAndQty + str6 + str3 + this.GetROL(str7)), 8);
                if (this.ALL.Checked)
                {
                    strArray5 = new string[] { text, "-", qty, "-", fn, "-", str6, "-", str3 };
                    strArray5[9] = "-";
                    strArray5[10] = str5;
                    this.KEY.Text = string.Concat(strArray5);
                }
                else
                {
                    strArray5 = new string[] { text, "-", qty, "-", fn, "-", fnAndQty, "-", str6 };
                    strArray5[9] = "-";
                    strArray5[10] = str3;
                    strArray5[11] = "-";
                    strArray5[12] = str5;
                    this.KEY.Text = string.Concat(strArray5);
                }
                str7 = null;
                if (this.ALL.Checked)
                {
                    string[] strArray3 = new string[8];
                    strArray3[1] = text;
                    strArray3[2] = qty;
                    strArray3[3] = fn;
                    strArray3[4] = str6;
                    strArray3[5] = str3;
                    strArray3[6] = str5;
                    strArray3[7] = this.SN.Text.Trim();
                    int index = 1;
                    do
                    {
                        str7 = ((index % 2) == 0) ? (str7 + Strings.Right(strArray3[index], 1)) : (str7 + Strings.Left(strArray3[index], 1));
                        index++;
                    }
                    while (index <= 7);
                }
                else
                {
                    string[] strArray4 = new string[9];
                    strArray4[1] = text;
                    strArray4[2] = qty;
                    strArray4[3] = fn;
                    strArray4[4] = fnAndQty;
                    strArray4[5] = str6;
                    strArray4[6] = str3;
                    strArray4[7] = str5;
                    strArray4[8] = this.SN.Text.Trim();
                    int index = 1;
                    do
                    {
                        str7 = ((index % 2) == 0) ? (str7 + Strings.Right(strArray4[index], 1)) : (str7 + Strings.Left(strArray4[index], 1));
                        index++;
                    }
                    while (index <= 8);
                }
                str7 = this.getMd5Hash(text + qty + fn + fnAndQty + str6 + str3 + str5 + this.SN.Text.Trim() + this.GetROL(str7));
                this.PW.Text = Strings.Mid(str7, 9, 8);
            }
        }

        public string d_to_b(int dec)
        {
            string str = null;
            while (true)
            {
                str = Conversions.ToString((int) (dec % 2)) + str;
                dec /= 2;
                if (dec == 0)
                {
                    return str;
                }
            }
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        public string GetFn()
        {
            char[] chArray = Conversions.ToCharArrayRankOne("00000000000000000000000000000000");
            if (this.ALL.Checked)
            {
                return "ffffffff";
            }
            if (this.YSF.Checked)
            {
                chArray[2] = '1';
            }
            if (this.PJM.Checked)
            {
                chArray[3] = '1';
            }
            if (this.KJS.Checked)
            {
                chArray[4] = '1';
            }
            if (this.RGS.Checked)
            {
                chArray[5] = '1';
            }
            if (this.SGM.Checked)
            {
                chArray[6] = '1';
            }
            if (this.CRM.Checked)
            {
                chArray[7] = '1';
            }
            if (this.GZS.Checked)
            {
                chArray[8] = '1';
            }
            if (this.ZCS.Checked)
            {
                chArray[9] = '1';
            }
            if (this.SXM.Checked)
            {
                chArray[10] = '1';
            }
            if (this.SCM.Checked)
            {
                chArray[11] = '1';
            }
            if (this.GYS.Checked)
            {
                chArray[12] = '1';
            }
            if (this.JCA.Checked)
            {
                chArray[13] = '1';
            }
            if (this.CWB.Checked)
            {
                chArray[14] = '1';
            }
            if (this.COP.Checked)
            {
                chArray[15] = '1';
            }
            if (this.PUR.Checked)
            {
                chArray[0x10] = '1';
            }
            if (this.INV.Checked)
            {
                chArray[0x11] = '1';
            }
            if (this.WLB.Checked)
            {
                chArray[0x12] = '1';
            }
            if (this.FIB.Checked)
            {
                chArray[0x13] = '1';
            }
            if (this.SYS.Checked)
            {
                chArray[20] = '1';
            }
            if (this.BAS.Checked)
            {
                chArray[0x15] = '1';
            }
            if (this.QMS.Checked)
            {
                chArray[0x16] = '1';
            }
            if (this.RMA.Checked)
            {
                chArray[0x17] = '1';
            }
            return this.b_to_h(new string(chArray));
        }

        public string GetFnAndQty()
        {
            string str = "";
            char[] chArray = Conversions.ToCharArrayRankOne("mjpdruebwynkatqf~!@#$%^&*(){}=+?");
            if (this.ALL.Checked)
            {
                return "";
            }
            if (this.YSF.Checked)
            {
                str = str + Conversions.ToString(chArray[2]) + Strings.Format(Conversion.Val(this.YSFQTY.Text), "00");
            }
            if (this.PJM.Checked)
            {
                str = str + Conversions.ToString(chArray[3]) + Strings.Format(Conversion.Val(this.PJMQTY.Text), "00");
            }
            if (this.KJS.Checked)
            {
                str = str + Conversions.ToString(chArray[4]) + Strings.Format(Conversion.Val(this.KJSQTY.Text), "00");
            }
            if (this.RGS.Checked)
            {
                str = str + Conversions.ToString(chArray[5]) + Strings.Format(Conversion.Val(this.RGSQTY.Text), "00");
            }
            if (this.SGM.Checked)
            {
                str = str + Conversions.ToString(chArray[6]) + Strings.Format(Conversion.Val(this.SGMQTY.Text), "00");
            }
            if (this.CRM.Checked)
            {
                str = str + Conversions.ToString(chArray[7]) + Strings.Format(Conversion.Val(this.CRMQTY.Text), "00");
            }
            if (this.GZS.Checked)
            {
                str = str + Conversions.ToString(chArray[8]) + Strings.Format(Conversion.Val(this.GZSQTY.Text), "00");
            }
            if (this.ZCS.Checked)
            {
                str = str + Conversions.ToString(chArray[9]) + Strings.Format(Conversion.Val(this.ZCSQTY.Text), "00");
            }
            if (this.SXM.Checked)
            {
                str = str + Conversions.ToString(chArray[10]) + Strings.Format(Conversion.Val(this.SXMQTY.Text), "00");
            }
            if (this.SCM.Checked)
            {
                str = str + Conversions.ToString(chArray[11]) + Strings.Format(Conversion.Val(this.SCMQTY.Text), "00");
            }
            if (this.GYS.Checked)
            {
                str = str + Conversions.ToString(chArray[12]) + Strings.Format(Conversion.Val(this.GYSQTY.Text), "00");
            }
            if (this.JCA.Checked)
            {
                str = str + Conversions.ToString(chArray[13]) + Strings.Format(Conversion.Val(this.JCAQTY.Text), "00");
            }
            if (this.CWB.Checked)
            {
                str = str + Conversions.ToString(chArray[14]) + Strings.Format(Conversion.Val(this.CWBQTY.Text), "00");
            }
            if (this.COP.Checked)
            {
                str = str + Conversions.ToString(chArray[15]) + Strings.Format(Conversion.Val(this.COPQTY.Text), "00");
            }
            if (this.PUR.Checked)
            {
                str = str + Conversions.ToString(chArray[0x10]) + Strings.Format(Conversion.Val(this.PURQTY.Text), "00");
            }
            if (this.INV.Checked)
            {
                str = str + Conversions.ToString(chArray[0x11]) + Strings.Format(Conversion.Val(this.INVQTY.Text), "00");
            }
            if (this.WLB.Checked)
            {
                str = str + Conversions.ToString(chArray[0x12]) + Strings.Format(Conversion.Val(this.WLBQTY.Text), "00");
            }
            if (this.FIB.Checked)
            {
                str = str + Conversions.ToString(chArray[0x13]) + Strings.Format(Conversion.Val(this.FIBQTY.Text), "00");
            }
            if (this.SYS.Checked)
            {
                str = str + Conversions.ToString(chArray[20]) + Strings.Format(Conversion.Val(this.SYSQTY.Text), "00");
            }
            if (this.BAS.Checked)
            {
                str = str + Conversions.ToString(chArray[0x15]) + Strings.Format(Conversion.Val(this.BASQTY.Text), "00");
            }
            if (this.QMS.Checked)
            {
                str = str + Conversions.ToString(chArray[0x16]) + Strings.Format(Conversion.Val(this.QMSQTY.Text), "00");
            }
            if (this.RMA.Checked)
            {
                str = str + Conversions.ToString(chArray[0x17]) + Strings.Format(Conversion.Val(this.RMAQTY.Text), "00");
            }
            return str;
        }

        public string getMd5Hash(string input)
        {
            byte[] buffer = new MD5CryptoServiceProvider().ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder builder = new StringBuilder();
            int num2 = buffer.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                builder.Append(buffer[i].ToString("x2"));
            }
            return builder.ToString();
        }

        public string GetQty() => 
            !this.ALL.Checked ? Strings.Format(((((((((((((((((((((Conversion.Val(this.BASQTY.Text) + Conversion.Val(this.COPQTY.Text)) + Conversion.Val(this.CRMQTY.Text)) + Conversion.Val(this.CWBQTY.Text)) + Conversion.Val(this.FIBQTY.Text)) + Conversion.Val(this.GYSQTY.Text)) + Conversion.Val(this.GZSQTY.Text)) + Conversion.Val(this.INVQTY.Text)) + Conversion.Val(this.JCAQTY.Text)) + Conversion.Val(this.KJSQTY.Text)) + Conversion.Val(this.PJMQTY.Text)) + Conversion.Val(this.PURQTY.Text)) + Conversion.Val(this.QMSQTY.Text)) + Conversion.Val(this.RGSQTY.Text)) + Conversion.Val(this.RMAQTY.Text)) + Conversion.Val(this.SCMQTY.Text)) + Conversion.Val(this.SGMQTY.Text)) + Conversion.Val(this.SXMQTY.Text)) + Conversion.Val(this.SYSQTY.Text)) + Conversion.Val(this.WLBQTY.Text)) + Conversion.Val(this.YSFQTY.Text)) + Conversion.Val(this.ZCSQTY.Text), "00") : Strings.Format(Conversion.Val(this.ALLQTY.Text), "00");

        public string GetROL(string str)
        {
            string str2 = "";
            byte[] bytes = Encoding.Default.GetBytes(str);
            int length = bytes.Length;
            for (int i = 1; i <= length; i++)
            {
                string str4 = this.d_to_b(bytes[i - 1]);
                str4 = Strings.StrDup(8 - str4.Length, "0") + str4;
                if (i < 8)
                {
                    str4 = Strings.Right(str4, i) + Strings.Left(str4, 8 - i);
                    str2 = str2 + this.b_to_h(str4).ToUpper();
                }
                else if (i <= 8)
                {
                    str2 = str2 + this.b_to_h(str4).ToUpper();
                }
                else
                {
                    str4 = Strings.Right(str4, i % 8) + Strings.Left(str4, 8 - (i % 8));
                    str2 = str2 + this.b_to_h(str4).ToUpper();
                }
            }
            return str2;
        }

        public string h_to_b(string hex)
        {
            string str = null;
            hex = Strings.UCase(hex);
            int num2 = Strings.Len(hex);
            for (int i = 1; i <= num2; i++)
            {
                string str3 = Strings.Mid(hex, i, 1);
                if (str3 == "0")
                {
                    str = str + "0000";
                }
                else if (str3 == "1")
                {
                    str = str + "0001";
                }
                else if (str3 == "2")
                {
                    str = str + "0010";
                }
                else if (str3 == "3")
                {
                    str = str + "0011";
                }
                else if (str3 == "4")
                {
                    str = str + "0100";
                }
                else if (str3 == "5")
                {
                    str = str + "0101";
                }
                else if (str3 == "6")
                {
                    str = str + "0110";
                }
                else if (str3 == "7")
                {
                    str = str + "0111";
                }
                else if (str3 == "8")
                {
                    str = str + "1000";
                }
                else if (str3 == "9")
                {
                    str = str + "1001";
                }
                else if (str3 == "a")
                {
                    str = str + "1010";
                }
                else if (str3 == "b")
                {
                    str = str + "1011";
                }
                else if (str3 == "c")
                {
                    str = str + "1100";
                }
                else if (str3 == "d")
                {
                    str = str + "1101";
                }
                else if (str3 == "e")
                {
                    str = str + "1110";
                }
                else if (str3 == "f")
                {
                    str = str + "1111";
                }
            }
            return str;
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Button1 = new Button();
            this.SN = new TextBox();
            this.KEY = new TextBox();
            this.GroupBox1 = new GroupBox();
            this.Label50 = new Label();
            this.Label40 = new Label();
            this.Label30 = new Label();
            this.Label20 = new Label();
            this.Label10 = new Label();
            this.Label49 = new Label();
            this.Label39 = new Label();
            this.Label29 = new Label();
            this.Label19 = new Label();
            this.Label8 = new Label();
            this.Label48 = new Label();
            this.Label38 = new Label();
            this.Label28 = new Label();
            this.Label18 = new Label();
            this.Label6 = new Label();
            this.Label54 = new Label();
            this.Label57 = new Label();
            this.Label47 = new Label();
            this.Label37 = new Label();
            this.Label27 = new Label();
            this.Label17 = new Label();
            this.Label4 = new Label();
            this.Label56 = new Label();
            this.Label46 = new Label();
            this.Label36 = new Label();
            this.Label26 = new Label();
            this.Label16 = new Label();
            this.Label2 = new Label();
            this.Label45 = new Label();
            this.Label35 = new Label();
            this.Label25 = new Label();
            this.Label15 = new Label();
            this.Label9 = new Label();
            this.Label44 = new Label();
            this.Label34 = new Label();
            this.Label24 = new Label();
            this.Label14 = new Label();
            this.Label7 = new Label();
            this.Label43 = new Label();
            this.Label33 = new Label();
            this.Label23 = new Label();
            this.Label13 = new Label();
            this.Label5 = new Label();
            this.Label53 = new Label();
            this.Label52 = new Label();
            this.Label42 = new Label();
            this.Label32 = new Label();
            this.Label22 = new Label();
            this.Label12 = new Label();
            this.Label3 = new Label();
            this.Label51 = new Label();
            this.Label41 = new Label();
            this.Label31 = new Label();
            this.Label21 = new Label();
            this.Label11 = new Label();
            this.Label1 = new Label();
            this.WLBQTY = new TextBox();
            this.SCMQTY = new TextBox();
            this.PURQTY = new TextBox();
            this.INVQTY = new TextBox();
            this.CWBQTY = new TextBox();
            this.WLB = new CheckBox();
            this.SCM = new CheckBox();
            this.PUR = new CheckBox();
            this.INV = new CheckBox();
            this.CWB = new CheckBox();
            this.SYSQTY = new TextBox();
            this.RMAQTY = new TextBox();
            this.PJMQTY = new TextBox();
            this.GZSQTY = new TextBox();
            this.CRMQTY = new TextBox();
            this.SYS = new CheckBox();
            this.RMA = new CheckBox();
            this.PJM = new CheckBox();
            this.GZS = new CheckBox();
            this.ALLQTY = new TextBox();
            this.CRM = new CheckBox();
            this.ZCSQTY = new TextBox();
            this.SXMQTY = new TextBox();
            this.RGSQTY = new TextBox();
            this.KJSQTY = new TextBox();
            this.GYSQTY = new TextBox();
            this.ALL = new CheckBox();
            this.COPQTY = new TextBox();
            this.ZCS = new CheckBox();
            this.SXM = new CheckBox();
            this.RGS = new CheckBox();
            this.KJS = new CheckBox();
            this.GYS = new CheckBox();
            this.COP = new CheckBox();
            this.YSFQTY = new TextBox();
            this.YSF = new CheckBox();
            this.SGMQTY = new TextBox();
            this.SGM = new CheckBox();
            this.QMSQTY = new TextBox();
            this.QMS = new CheckBox();
            this.JCAQTY = new TextBox();
            this.JCA = new CheckBox();
            this.FIBQTY = new TextBox();
            this.FIB = new CheckBox();
            this.BASQTY = new TextBox();
            this.BAS = new CheckBox();
            this.REGSTR = new TextBox();
            this.Label61 = new Label();
            this.Label62 = new Label();
            this.PW = new TextBox();
            this.Label63 = new Label();
            this.Label64 = new Label();
            this.ToolTip1 = new ToolTip(this.components);
            this.CCode = new TextBox();
            this.Label55 = new Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            Point point = new Point(0x20b, 0x243);
            this.Button1.Location = point;
            this.Button1.Name = "Button1";
            Size size = new Size(0x4b, 0x17);
            this.Button1.Size = size;
            this.Button1.TabIndex = 0;
            this.Button1.Text = "注册";
            this.Button1.UseVisualStyleBackColor = true;
            point = new Point(14, 0x18);
            this.SN.Location = point;
            this.SN.Name = "SN";
            size = new Size(0x1bd, 0x15);
            this.SN.Size = size;
            this.SN.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.SN, "请输入安装代号！");
            point = new Point(12, 0x21a);
            this.KEY.Location = point;
            this.KEY.Multiline = true;
            this.KEY.Name = "KEY";
            this.KEY.ReadOnly = true;
            size = new Size(0x1ca, 0x40);
            this.KEY.Size = size;
            this.KEY.TabIndex = 1;
            this.GroupBox1.Controls.Add(this.Label50);
            this.GroupBox1.Controls.Add(this.Label40);
            this.GroupBox1.Controls.Add(this.Label30);
            this.GroupBox1.Controls.Add(this.Label20);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.Label49);
            this.GroupBox1.Controls.Add(this.Label39);
            this.GroupBox1.Controls.Add(this.Label29);
            this.GroupBox1.Controls.Add(this.Label19);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label48);
            this.GroupBox1.Controls.Add(this.Label38);
            this.GroupBox1.Controls.Add(this.Label28);
            this.GroupBox1.Controls.Add(this.Label18);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label54);
            this.GroupBox1.Controls.Add(this.Label57);
            this.GroupBox1.Controls.Add(this.Label47);
            this.GroupBox1.Controls.Add(this.Label37);
            this.GroupBox1.Controls.Add(this.Label27);
            this.GroupBox1.Controls.Add(this.Label17);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label56);
            this.GroupBox1.Controls.Add(this.Label46);
            this.GroupBox1.Controls.Add(this.Label36);
            this.GroupBox1.Controls.Add(this.Label26);
            this.GroupBox1.Controls.Add(this.Label16);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label45);
            this.GroupBox1.Controls.Add(this.Label35);
            this.GroupBox1.Controls.Add(this.Label25);
            this.GroupBox1.Controls.Add(this.Label15);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label44);
            this.GroupBox1.Controls.Add(this.Label34);
            this.GroupBox1.Controls.Add(this.Label24);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label43);
            this.GroupBox1.Controls.Add(this.Label33);
            this.GroupBox1.Controls.Add(this.Label23);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label53);
            this.GroupBox1.Controls.Add(this.Label52);
            this.GroupBox1.Controls.Add(this.Label42);
            this.GroupBox1.Controls.Add(this.Label32);
            this.GroupBox1.Controls.Add(this.Label22);
            this.GroupBox1.Controls.Add(this.Label12);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label51);
            this.GroupBox1.Controls.Add(this.Label41);
            this.GroupBox1.Controls.Add(this.Label31);
            this.GroupBox1.Controls.Add(this.Label21);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.WLBQTY);
            this.GroupBox1.Controls.Add(this.SCMQTY);
            this.GroupBox1.Controls.Add(this.PURQTY);
            this.GroupBox1.Controls.Add(this.INVQTY);
            this.GroupBox1.Controls.Add(this.CWBQTY);
            this.GroupBox1.Controls.Add(this.WLB);
            this.GroupBox1.Controls.Add(this.SCM);
            this.GroupBox1.Controls.Add(this.PUR);
            this.GroupBox1.Controls.Add(this.INV);
            this.GroupBox1.Controls.Add(this.CWB);
            this.GroupBox1.Controls.Add(this.SYSQTY);
            this.GroupBox1.Controls.Add(this.RMAQTY);
            this.GroupBox1.Controls.Add(this.PJMQTY);
            this.GroupBox1.Controls.Add(this.GZSQTY);
            this.GroupBox1.Controls.Add(this.CRMQTY);
            this.GroupBox1.Controls.Add(this.SYS);
            this.GroupBox1.Controls.Add(this.RMA);
            this.GroupBox1.Controls.Add(this.PJM);
            this.GroupBox1.Controls.Add(this.GZS);
            this.GroupBox1.Controls.Add(this.ALLQTY);
            this.GroupBox1.Controls.Add(this.CRM);
            this.GroupBox1.Controls.Add(this.ZCSQTY);
            this.GroupBox1.Controls.Add(this.SXMQTY);
            this.GroupBox1.Controls.Add(this.RGSQTY);
            this.GroupBox1.Controls.Add(this.KJSQTY);
            this.GroupBox1.Controls.Add(this.GYSQTY);
            this.GroupBox1.Controls.Add(this.ALL);
            this.GroupBox1.Controls.Add(this.COPQTY);
            this.GroupBox1.Controls.Add(this.ZCS);
            this.GroupBox1.Controls.Add(this.SXM);
            this.GroupBox1.Controls.Add(this.RGS);
            this.GroupBox1.Controls.Add(this.KJS);
            this.GroupBox1.Controls.Add(this.GYS);
            this.GroupBox1.Controls.Add(this.COP);
            this.GroupBox1.Controls.Add(this.YSFQTY);
            this.GroupBox1.Controls.Add(this.YSF);
            this.GroupBox1.Controls.Add(this.SGMQTY);
            this.GroupBox1.Controls.Add(this.SGM);
            this.GroupBox1.Controls.Add(this.QMSQTY);
            this.GroupBox1.Controls.Add(this.QMS);
            this.GroupBox1.Controls.Add(this.JCAQTY);
            this.GroupBox1.Controls.Add(this.JCA);
            this.GroupBox1.Controls.Add(this.FIBQTY);
            this.GroupBox1.Controls.Add(this.FIB);
            this.GroupBox1.Controls.Add(this.BASQTY);
            this.GroupBox1.Controls.Add(this.BAS);
            point = new Point(12, 0x3e);
            this.GroupBox1.Location = point;
            this.GroupBox1.Name = "GroupBox1";
            size = new Size(0x26b, 0x18f);
            this.GroupBox1.Size = size;
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "功能选择";
            this.ToolTip1.SetToolTip(this.GroupBox1, "选取要注册的功能！");
            this.Label50.AutoSize = true;
            point = new Point(0x1fd, 270);
            this.Label50.Location = point;
            this.Label50.Name = "Label50";
            size = new Size(0x1d, 12);
            this.Label50.Size = size;
            this.Label50.TabIndex = 2;
            this.Label50.Text = "功能";
            this.Label40.AutoSize = true;
            point = new Point(0x1fd, 0xd5);
            this.Label40.Location = point;
            this.Label40.Name = "Label40";
            size = new Size(0x1d, 12);
            this.Label40.Size = size;
            this.Label40.TabIndex = 2;
            this.Label40.Text = "功能";
            this.Label30.AutoSize = true;
            point = new Point(0x1fd, 0x98);
            this.Label30.Location = point;
            this.Label30.Name = "Label30";
            size = new Size(0x1d, 12);
            this.Label30.Size = size;
            this.Label30.TabIndex = 2;
            this.Label30.Text = "功能";
            this.Label20.AutoSize = true;
            point = new Point(0x1fd, 0x5e);
            this.Label20.Location = point;
            this.Label20.Name = "Label20";
            size = new Size(0x1d, 12);
            this.Label20.Size = size;
            this.Label20.TabIndex = 2;
            this.Label20.Text = "功能";
            this.Label10.AutoSize = true;
            point = new Point(0x1fd, 0x27);
            this.Label10.Location = point;
            this.Label10.Name = "Label10";
            size = new Size(0x1d, 12);
            this.Label10.Size = size;
            this.Label10.TabIndex = 2;
            this.Label10.Text = "功能";
            this.Label49.AutoSize = true;
            point = new Point(0x1fd, 270);
            this.Label49.Location = point;
            this.Label49.Name = "Label49";
            size = new Size(0x1d, 12);
            this.Label49.Size = size;
            this.Label49.TabIndex = 2;
            this.Label49.Text = "功能";
            this.Label39.AutoSize = true;
            point = new Point(0x1fd, 0xd5);
            this.Label39.Location = point;
            this.Label39.Name = "Label39";
            size = new Size(0x1d, 12);
            this.Label39.Size = size;
            this.Label39.TabIndex = 2;
            this.Label39.Text = "功能";
            this.Label29.AutoSize = true;
            point = new Point(0x1fd, 0x98);
            this.Label29.Location = point;
            this.Label29.Name = "Label29";
            size = new Size(0x1d, 12);
            this.Label29.Size = size;
            this.Label29.TabIndex = 2;
            this.Label29.Text = "功能";
            this.Label19.AutoSize = true;
            point = new Point(0x1fd, 0x5e);
            this.Label19.Location = point;
            this.Label19.Name = "Label19";
            size = new Size(0x1d, 12);
            this.Label19.Size = size;
            this.Label19.TabIndex = 2;
            this.Label19.Text = "功能";
            this.Label8.AutoSize = true;
            point = new Point(0x1fd, 0x27);
            this.Label8.Location = point;
            this.Label8.Name = "Label8";
            size = new Size(0x1d, 12);
            this.Label8.Size = size;
            this.Label8.TabIndex = 2;
            this.Label8.Text = "功能";
            this.Label48.AutoSize = true;
            point = new Point(0x16a, 270);
            this.Label48.Location = point;
            this.Label48.Name = "Label48";
            size = new Size(0x1d, 12);
            this.Label48.Size = size;
            this.Label48.TabIndex = 2;
            this.Label48.Text = "功能";
            this.Label38.AutoSize = true;
            point = new Point(0x16a, 0xd5);
            this.Label38.Location = point;
            this.Label38.Name = "Label38";
            size = new Size(0x1d, 12);
            this.Label38.Size = size;
            this.Label38.TabIndex = 2;
            this.Label38.Text = "功能";
            this.Label28.AutoSize = true;
            point = new Point(0x16a, 0x98);
            this.Label28.Location = point;
            this.Label28.Name = "Label28";
            size = new Size(0x1d, 12);
            this.Label28.Size = size;
            this.Label28.TabIndex = 2;
            this.Label28.Text = "功能";
            this.Label18.AutoSize = true;
            point = new Point(0x16a, 0x5e);
            this.Label18.Location = point;
            this.Label18.Name = "Label18";
            size = new Size(0x1d, 12);
            this.Label18.Size = size;
            this.Label18.TabIndex = 2;
            this.Label18.Text = "功能";
            this.Label6.AutoSize = true;
            point = new Point(0x16a, 0x27);
            this.Label6.Location = point;
            this.Label6.Name = "Label6";
            size = new Size(0x1d, 12);
            this.Label6.Size = size;
            this.Label6.TabIndex = 2;
            this.Label6.Text = "功能";
            this.Label54.AutoSize = true;
            point = new Point(360, 0x14e);
            this.Label54.Location = point;
            this.Label54.Name = "Label54";
            size = new Size(0x1d, 12);
            this.Label54.Size = size;
            this.Label54.TabIndex = 2;
            this.Label54.Text = "功能";
            this.Label57.AutoSize = true;
            point = new Point(0xd8, 0x14e);
            this.Label57.Location = point;
            this.Label57.Name = "Label57";
            size = new Size(0x1d, 12);
            this.Label57.Size = size;
            this.Label57.TabIndex = 2;
            this.Label57.Text = "功能";
            this.Label47.AutoSize = true;
            point = new Point(0xd8, 270);
            this.Label47.Location = point;
            this.Label47.Name = "Label47";
            size = new Size(0x1d, 12);
            this.Label47.Size = size;
            this.Label47.TabIndex = 2;
            this.Label47.Text = "功能";
            this.Label37.AutoSize = true;
            point = new Point(0xd8, 0xd5);
            this.Label37.Location = point;
            this.Label37.Name = "Label37";
            size = new Size(0x1d, 12);
            this.Label37.Size = size;
            this.Label37.TabIndex = 2;
            this.Label37.Text = "功能";
            this.Label27.AutoSize = true;
            point = new Point(0xd8, 0x98);
            this.Label27.Location = point;
            this.Label27.Name = "Label27";
            size = new Size(0x1d, 12);
            this.Label27.Size = size;
            this.Label27.TabIndex = 2;
            this.Label27.Text = "功能";
            this.Label17.AutoSize = true;
            point = new Point(0xd8, 0x5e);
            this.Label17.Location = point;
            this.Label17.Name = "Label17";
            size = new Size(0x1d, 12);
            this.Label17.Size = size;
            this.Label17.TabIndex = 2;
            this.Label17.Text = "功能";
            this.Label4.AutoSize = true;
            point = new Point(0xe7, 0x27);
            this.Label4.Location = point;
            this.Label4.Name = "Label4";
            size = new Size(0x1d, 12);
            this.Label4.Size = size;
            this.Label4.TabIndex = 2;
            this.Label4.Text = "功能";
            this.Label56.AutoSize = true;
            point = new Point(0x44, 330);
            this.Label56.Location = point;
            this.Label56.Name = "Label56";
            size = new Size(0x1d, 12);
            this.Label56.Size = size;
            this.Label56.TabIndex = 2;
            this.Label56.Text = "功能";
            this.Label46.AutoSize = true;
            point = new Point(0x44, 0x10a);
            this.Label46.Location = point;
            this.Label46.Name = "Label46";
            size = new Size(0x1d, 12);
            this.Label46.Size = size;
            this.Label46.TabIndex = 2;
            this.Label46.Text = "功能";
            this.Label36.AutoSize = true;
            point = new Point(0x44, 0xd1);
            this.Label36.Location = point;
            this.Label36.Name = "Label36";
            size = new Size(0x1d, 12);
            this.Label36.Size = size;
            this.Label36.TabIndex = 2;
            this.Label36.Text = "功能";
            this.Label26.AutoSize = true;
            point = new Point(0x44, 0x94);
            this.Label26.Location = point;
            this.Label26.Name = "Label26";
            size = new Size(0x1d, 12);
            this.Label26.Size = size;
            this.Label26.TabIndex = 2;
            this.Label26.Text = "功能";
            this.Label16.AutoSize = true;
            point = new Point(0x44, 90);
            this.Label16.Location = point;
            this.Label16.Name = "Label16";
            size = new Size(0x1d, 12);
            this.Label16.Size = size;
            this.Label16.TabIndex = 2;
            this.Label16.Text = "功能";
            this.Label2.AutoSize = true;
            point = new Point(0x44, 0x23);
            this.Label2.Location = point;
            this.Label2.Name = "Label2";
            size = new Size(0x35, 12);
            this.Label2.Size = size;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "功能代号";
            this.Label45.AutoSize = true;
            point = new Point(0x1d0, 270);
            this.Label45.Location = point;
            this.Label45.Name = "Label45";
            size = new Size(0x29, 12);
            this.Label45.Size = size;
            this.Label45.TabIndex = 2;
            this.Label45.Text = "用户数";
            this.Label35.AutoSize = true;
            point = new Point(0x1d0, 0xd5);
            this.Label35.Location = point;
            this.Label35.Name = "Label35";
            size = new Size(0x29, 12);
            this.Label35.Size = size;
            this.Label35.TabIndex = 2;
            this.Label35.Text = "用户数";
            this.Label25.AutoSize = true;
            point = new Point(0x1d0, 0x98);
            this.Label25.Location = point;
            this.Label25.Name = "Label25";
            size = new Size(0x29, 12);
            this.Label25.Size = size;
            this.Label25.TabIndex = 2;
            this.Label25.Text = "用户数";
            this.Label15.AutoSize = true;
            point = new Point(0x1d0, 0x5e);
            this.Label15.Location = point;
            this.Label15.Name = "Label15";
            size = new Size(0x29, 12);
            this.Label15.Size = size;
            this.Label15.TabIndex = 2;
            this.Label15.Text = "用户数";
            this.Label9.AutoSize = true;
            point = new Point(0x1d0, 0x27);
            this.Label9.Location = point;
            this.Label9.Name = "Label9";
            size = new Size(0x29, 12);
            this.Label9.Size = size;
            this.Label9.TabIndex = 2;
            this.Label9.Text = "用户数";
            this.Label44.AutoSize = true;
            point = new Point(0x1d0, 270);
            this.Label44.Location = point;
            this.Label44.Name = "Label44";
            size = new Size(0x29, 12);
            this.Label44.Size = size;
            this.Label44.TabIndex = 2;
            this.Label44.Text = "用户数";
            this.Label34.AutoSize = true;
            point = new Point(0x1d0, 0xd5);
            this.Label34.Location = point;
            this.Label34.Name = "Label34";
            size = new Size(0x29, 12);
            this.Label34.Size = size;
            this.Label34.TabIndex = 2;
            this.Label34.Text = "用户数";
            this.Label24.AutoSize = true;
            point = new Point(0x1d0, 0x98);
            this.Label24.Location = point;
            this.Label24.Name = "Label24";
            size = new Size(0x29, 12);
            this.Label24.Size = size;
            this.Label24.TabIndex = 2;
            this.Label24.Text = "用户数";
            this.Label14.AutoSize = true;
            point = new Point(0x1d0, 0x5e);
            this.Label14.Location = point;
            this.Label14.Name = "Label14";
            size = new Size(0x29, 12);
            this.Label14.Size = size;
            this.Label14.TabIndex = 2;
            this.Label14.Text = "用户数";
            this.Label7.AutoSize = true;
            point = new Point(0x1d0, 0x27);
            this.Label7.Location = point;
            this.Label7.Name = "Label7";
            size = new Size(0x29, 12);
            this.Label7.Size = size;
            this.Label7.TabIndex = 2;
            this.Label7.Text = "用户数";
            this.Label43.AutoSize = true;
            point = new Point(0x13d, 270);
            this.Label43.Location = point;
            this.Label43.Name = "Label43";
            size = new Size(0x29, 12);
            this.Label43.Size = size;
            this.Label43.TabIndex = 2;
            this.Label43.Text = "用户数";
            this.Label33.AutoSize = true;
            point = new Point(0x13d, 0xd5);
            this.Label33.Location = point;
            this.Label33.Name = "Label33";
            size = new Size(0x29, 12);
            this.Label33.Size = size;
            this.Label33.TabIndex = 2;
            this.Label33.Text = "用户数";
            this.Label23.AutoSize = true;
            point = new Point(0x13d, 0x98);
            this.Label23.Location = point;
            this.Label23.Name = "Label23";
            size = new Size(0x29, 12);
            this.Label23.Size = size;
            this.Label23.TabIndex = 2;
            this.Label23.Text = "用户数";
            this.Label13.AutoSize = true;
            point = new Point(0x13d, 0x5e);
            this.Label13.Location = point;
            this.Label13.Name = "Label13";
            size = new Size(0x29, 12);
            this.Label13.Size = size;
            this.Label13.TabIndex = 2;
            this.Label13.Text = "用户数";
            this.Label5.AutoSize = true;
            point = new Point(0x13d, 0x27);
            this.Label5.Location = point;
            this.Label5.Name = "Label5";
            size = new Size(0x29, 12);
            this.Label5.Size = size;
            this.Label5.TabIndex = 2;
            this.Label5.Text = "用户数";
            this.Label53.AutoSize = true;
            point = new Point(0x13b, 0x14e);
            this.Label53.Location = point;
            this.Label53.Name = "Label53";
            size = new Size(0x29, 12);
            this.Label53.Size = size;
            this.Label53.TabIndex = 2;
            this.Label53.Text = "用户数";
            this.Label52.AutoSize = true;
            point = new Point(170, 0x14e);
            this.Label52.Location = point;
            this.Label52.Name = "Label52";
            size = new Size(0x29, 12);
            this.Label52.Size = size;
            this.Label52.TabIndex = 2;
            this.Label52.Text = "用户数";
            this.Label42.AutoSize = true;
            point = new Point(170, 270);
            this.Label42.Location = point;
            this.Label42.Name = "Label42";
            size = new Size(0x29, 12);
            this.Label42.Size = size;
            this.Label42.TabIndex = 2;
            this.Label42.Text = "用户数";
            this.Label32.AutoSize = true;
            point = new Point(170, 0xd5);
            this.Label32.Location = point;
            this.Label32.Name = "Label32";
            size = new Size(0x29, 12);
            this.Label32.Size = size;
            this.Label32.TabIndex = 2;
            this.Label32.Text = "用户数";
            this.Label22.AutoSize = true;
            point = new Point(170, 0x98);
            this.Label22.Location = point;
            this.Label22.Name = "Label22";
            size = new Size(0x29, 12);
            this.Label22.Size = size;
            this.Label22.TabIndex = 2;
            this.Label22.Text = "用户数";
            this.Label12.AutoSize = true;
            point = new Point(170, 0x5e);
            this.Label12.Location = point;
            this.Label12.Name = "Label12";
            size = new Size(0x29, 12);
            this.Label12.Size = size;
            this.Label12.TabIndex = 2;
            this.Label12.Text = "用户数";
            this.Label3.AutoSize = true;
            point = new Point(170, 0x27);
            this.Label3.Location = point;
            this.Label3.Name = "Label3";
            size = new Size(0x29, 12);
            this.Label3.Size = size;
            this.Label3.TabIndex = 2;
            this.Label3.Text = "用户数";
            this.Label51.AutoSize = true;
            point = new Point(0x17, 0x14c);
            this.Label51.Location = point;
            this.Label51.Name = "Label51";
            size = new Size(0x29, 12);
            this.Label51.Size = size;
            this.Label51.TabIndex = 2;
            this.Label51.Text = "用户数";
            this.Label41.AutoSize = true;
            point = new Point(0x17, 0x10c);
            this.Label41.Location = point;
            this.Label41.Name = "Label41";
            size = new Size(0x29, 12);
            this.Label41.Size = size;
            this.Label41.TabIndex = 2;
            this.Label41.Text = "用户数";
            this.Label31.AutoSize = true;
            point = new Point(0x17, 0xd3);
            this.Label31.Location = point;
            this.Label31.Name = "Label31";
            size = new Size(0x29, 12);
            this.Label31.Size = size;
            this.Label31.TabIndex = 2;
            this.Label31.Text = "用户数";
            this.Label21.AutoSize = true;
            point = new Point(0x17, 150);
            this.Label21.Location = point;
            this.Label21.Name = "Label21";
            size = new Size(0x29, 12);
            this.Label21.Size = size;
            this.Label21.TabIndex = 2;
            this.Label21.Text = "用户数";
            this.Label11.AutoSize = true;
            point = new Point(0x17, 0x5c);
            this.Label11.Location = point;
            this.Label11.Name = "Label11";
            size = new Size(0x29, 12);
            this.Label11.Size = size;
            this.Label11.TabIndex = 2;
            this.Label11.Text = "用户数";
            this.Label1.AutoSize = true;
            point = new Point(0x17, 0x25);
            this.Label1.Location = point;
            this.Label1.Name = "Label1";
            size = new Size(0x29, 12);
            this.Label1.Size = size;
            this.Label1.TabIndex = 2;
            this.Label1.Text = "用户数";
            this.WLBQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "WLBQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.WLBQTY.Enabled = MySettings.Default.WLBQTY;
            point = new Point(0x1d0, 0x120);
            this.WLBQTY.Location = point;
            this.WLBQTY.MaxLength = 2;
            this.WLBQTY.Name = "WLBQTY";
            size = new Size(0x29, 0x15);
            this.WLBQTY.Size = size;
            this.WLBQTY.TabIndex = 1;
            this.SCMQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "SCMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.SCMQTY.Enabled = MySettings.Default.SCMQTY;
            point = new Point(0x1d0, 0xe7);
            this.SCMQTY.Location = point;
            this.SCMQTY.MaxLength = 2;
            this.SCMQTY.Name = "SCMQTY";
            size = new Size(0x29, 0x15);
            this.SCMQTY.Size = size;
            this.SCMQTY.TabIndex = 1;
            this.PURQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "PURQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.PURQTY.Enabled = MySettings.Default.PURQTY;
            point = new Point(0x1d0, 170);
            this.PURQTY.Location = point;
            this.PURQTY.MaxLength = 2;
            this.PURQTY.Name = "PURQTY";
            size = new Size(0x29, 0x15);
            this.PURQTY.Size = size;
            this.PURQTY.TabIndex = 1;
            this.INVQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "INVQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.INVQTY.Enabled = MySettings.Default.INVQTY;
            point = new Point(0x1d0, 0x70);
            this.INVQTY.Location = point;
            this.INVQTY.MaxLength = 2;
            this.INVQTY.Name = "INVQTY";
            size = new Size(0x29, 0x15);
            this.INVQTY.Size = size;
            this.INVQTY.TabIndex = 1;
            this.CWBQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "CWBQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.CWBQTY.Enabled = MySettings.Default.CWBQTY;
            point = new Point(0x1d0, 0x39);
            this.CWBQTY.Location = point;
            this.CWBQTY.MaxLength = 2;
            this.CWBQTY.Name = "CWBQTY";
            size = new Size(0x29, 0x15);
            this.CWBQTY.Size = size;
            this.CWBQTY.TabIndex = 1;
            this.WLB.AutoSize = true;
            this.WLB.Checked = MySettings.Default.WLBQTY;
            this.WLB.DataBindings.Add(new Binding("Checked", MySettings.Default, "WLBQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x1ff, 290);
            this.WLB.Location = point;
            this.WLB.Name = "WLB";
            size = new Size(60, 0x10);
            this.WLB.Size = size;
            this.WLB.TabIndex = 0;
            this.WLB.Text = "物流包";
            this.ToolTip1.SetToolTip(this.WLB, "WLB 物流包(销售/采购/存货)");
            this.WLB.UseVisualStyleBackColor = true;
            this.SCM.AutoSize = true;
            this.SCM.Checked = MySettings.Default.SCMQTY;
            this.SCM.DataBindings.Add(new Binding("Checked", MySettings.Default, "SCMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x1ff, 0xe9);
            this.SCM.Location = point;
            this.SCM.Name = "SCM";
            size = new Size(0x48, 0x10);
            this.SCM.Size = size;
            this.SCM.TabIndex = 0;
            this.SCM.Text = "生产成本";
            this.ToolTip1.SetToolTip(this.SCM, "SCM 生产成本");
            this.SCM.UseVisualStyleBackColor = true;
            this.PUR.AutoSize = true;
            this.PUR.Checked = MySettings.Default.PURQTY;
            this.PUR.DataBindings.Add(new Binding("Checked", MySettings.Default, "PURQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x1ff, 0xac);
            this.PUR.Location = point;
            this.PUR.Name = "PUR";
            size = new Size(0x30, 0x10);
            this.PUR.Size = size;
            this.PUR.TabIndex = 0;
            this.PUR.Text = "采购";
            this.ToolTip1.SetToolTip(this.PUR, "PUR 采购");
            this.PUR.UseVisualStyleBackColor = true;
            this.INV.AutoSize = true;
            this.INV.Checked = MySettings.Default.INVQTY;
            this.INV.DataBindings.Add(new Binding("Checked", MySettings.Default, "INVQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x1ff, 0x72);
            this.INV.Location = point;
            this.INV.Name = "INV";
            size = new Size(0x30, 0x10);
            this.INV.Size = size;
            this.INV.TabIndex = 0;
            this.INV.Text = "存货";
            this.ToolTip1.SetToolTip(this.INV, "INV 存货");
            this.INV.UseVisualStyleBackColor = true;
            this.CWB.AutoSize = true;
            this.CWB.Checked = MySettings.Default.CWBQTY;
            this.CWB.DataBindings.Add(new Binding("Checked", MySettings.Default, "CWBQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x1ff, 0x3b);
            this.CWB.Location = point;
            this.CWB.Name = "CWB";
            size = new Size(0x60, 0x10);
            this.CWB.Size = size;
            this.CWB.TabIndex = 0;
            this.CWB.Text = "财务报表平台";
            this.ToolTip1.SetToolTip(this.CWB, "CWB 财务报表平台");
            this.CWB.UseVisualStyleBackColor = true;
            this.SYSQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "SYSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.SYSQTY.Enabled = MySettings.Default.SYSQTY;
            point = new Point(0x13d, 0x120);
            this.SYSQTY.Location = point;
            this.SYSQTY.MaxLength = 2;
            this.SYSQTY.Name = "SYSQTY";
            size = new Size(0x29, 0x15);
            this.SYSQTY.Size = size;
            this.SYSQTY.TabIndex = 1;
            this.RMAQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "RMAQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.RMAQTY.Enabled = MySettings.Default.RMAQTY;
            point = new Point(0x13d, 0xe7);
            this.RMAQTY.Location = point;
            this.RMAQTY.MaxLength = 2;
            this.RMAQTY.Name = "RMAQTY";
            size = new Size(0x29, 0x15);
            this.RMAQTY.Size = size;
            this.RMAQTY.TabIndex = 1;
            this.PJMQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "PJMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.PJMQTY.Enabled = MySettings.Default.PJMQTY;
            point = new Point(0x13d, 170);
            this.PJMQTY.Location = point;
            this.PJMQTY.MaxLength = 2;
            this.PJMQTY.Name = "PJMQTY";
            size = new Size(0x29, 0x15);
            this.PJMQTY.Size = size;
            this.PJMQTY.TabIndex = 1;
            this.GZSQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "GZSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.GZSQTY.Enabled = MySettings.Default.GZSQTY;
            point = new Point(0x13d, 0x70);
            this.GZSQTY.Location = point;
            this.GZSQTY.MaxLength = 2;
            this.GZSQTY.Name = "GZSQTY";
            size = new Size(0x29, 0x15);
            this.GZSQTY.Size = size;
            this.GZSQTY.TabIndex = 1;
            this.CRMQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "CRMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.CRMQTY.Enabled = MySettings.Default.CRMQTY;
            point = new Point(0x13d, 0x39);
            this.CRMQTY.Location = point;
            this.CRMQTY.MaxLength = 2;
            this.CRMQTY.Name = "CRMQTY";
            size = new Size(0x29, 0x15);
            this.CRMQTY.Size = size;
            this.CRMQTY.TabIndex = 1;
            this.SYS.AutoSize = true;
            this.SYS.Checked = MySettings.Default.SYSQTY;
            this.SYS.DataBindings.Add(new Binding("Checked", MySettings.Default, "SYSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x16c, 290);
            this.SYS.Location = point;
            this.SYS.Name = "SYS";
            size = new Size(60, 0x10);
            this.SYS.Size = size;
            this.SYS.TabIndex = 0;
            this.SYS.Text = "系统包";
            this.ToolTip1.SetToolTip(this.SYS, "SYS 系统包（销售/采购/存货/生管/物料需求/应收应付/报表生成）");
            this.SYS.UseVisualStyleBackColor = true;
            this.RMA.AutoSize = true;
            this.RMA.Checked = MySettings.Default.RMAQTY;
            this.RMA.DataBindings.Add(new Binding("Checked", MySettings.Default, "RMAQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x16c, 0xe9);
            this.RMA.Location = point;
            this.RMA.Name = "RMA";
            size = new Size(0x48, 0x10);
            this.RMA.Size = size;
            this.RMA.TabIndex = 0;
            this.RMA.Text = "服务管理";
            this.ToolTip1.SetToolTip(this.RMA, "RMA 服务管理");
            this.RMA.UseVisualStyleBackColor = true;
            this.PJM.AutoSize = true;
            this.PJM.Checked = MySettings.Default.PJMQTY;
            this.PJM.DataBindings.Add(new Binding("Checked", MySettings.Default, "PJMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x16c, 0xac);
            this.PJM.Location = point;
            this.PJM.Name = "PJM";
            size = new Size(0x48, 0x10);
            this.PJM.Size = size;
            this.PJM.TabIndex = 0;
            this.PJM.Text = "票据资金";
            this.ToolTip1.SetToolTip(this.PJM, "PJM 票据资金");
            this.PJM.UseVisualStyleBackColor = true;
            this.GZS.AutoSize = true;
            this.GZS.Checked = MySettings.Default.GZSQTY;
            this.GZS.DataBindings.Add(new Binding("Checked", MySettings.Default, "GZSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x16c, 0x72);
            this.GZS.Location = point;
            this.GZS.Name = "GZS";
            size = new Size(0x30, 0x10);
            this.GZS.Size = size;
            this.GZS.TabIndex = 0;
            this.GZS.Text = "工资";
            this.ToolTip1.SetToolTip(this.GZS, "GZS 工资");
            this.GZS.UseVisualStyleBackColor = true;
            this.ALLQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "ALLQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.ALLQTY.Enabled = MySettings.Default.ALLQTY;
            point = new Point(0x13b, 0x160);
            this.ALLQTY.Location = point;
            this.ALLQTY.Name = "ALLQTY";
            size = new Size(0x29, 0x15);
            this.ALLQTY.Size = size;
            this.ALLQTY.TabIndex = 1;
            this.CRM.AutoSize = true;
            this.CRM.Checked = MySettings.Default.CRMQTY;
            this.CRM.DataBindings.Add(new Binding("Checked", MySettings.Default, "CRMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x16c, 0x3b);
            this.CRM.Location = point;
            this.CRM.Name = "CRM";
            size = new Size(0x48, 0x10);
            this.CRM.Size = size;
            this.CRM.TabIndex = 0;
            this.CRM.Text = "客户关系";
            this.ToolTip1.SetToolTip(this.CRM, "CRM 客户关系");
            this.CRM.UseVisualStyleBackColor = true;
            this.ZCSQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "ZCSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.ZCSQTY.Enabled = MySettings.Default.ZCSQTY;
            point = new Point(170, 0x160);
            this.ZCSQTY.Location = point;
            this.ZCSQTY.MaxLength = 2;
            this.ZCSQTY.Name = "ZCSQTY";
            size = new Size(0x29, 0x15);
            this.ZCSQTY.Size = size;
            this.ZCSQTY.TabIndex = 1;
            this.SXMQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "SXMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.SXMQTY.Enabled = MySettings.Default.SXMQTY;
            point = new Point(170, 0x120);
            this.SXMQTY.Location = point;
            this.SXMQTY.MaxLength = 2;
            this.SXMQTY.Name = "SXMQTY";
            size = new Size(0x29, 0x15);
            this.SXMQTY.Size = size;
            this.SXMQTY.TabIndex = 1;
            this.RGSQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "RGSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.RGSQTY.Enabled = MySettings.Default.RGSQTY;
            point = new Point(170, 0xe7);
            this.RGSQTY.Location = point;
            this.RGSQTY.MaxLength = 2;
            this.RGSQTY.Name = "RGSQTY";
            size = new Size(0x29, 0x15);
            this.RGSQTY.Size = size;
            this.RGSQTY.TabIndex = 1;
            this.KJSQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "KJSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.KJSQTY.Enabled = MySettings.Default.KJSQTY;
            point = new Point(170, 170);
            this.KJSQTY.Location = point;
            this.KJSQTY.MaxLength = 2;
            this.KJSQTY.Name = "KJSQTY";
            size = new Size(0x29, 0x15);
            this.KJSQTY.Size = size;
            this.KJSQTY.TabIndex = 1;
            this.GYSQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "GYSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.GYSQTY.Enabled = MySettings.Default.GYSQTY;
            point = new Point(170, 0x70);
            this.GYSQTY.Location = point;
            this.GYSQTY.MaxLength = 2;
            this.GYSQTY.Name = "GYSQTY";
            size = new Size(0x29, 0x15);
            this.GYSQTY.Size = size;
            this.GYSQTY.TabIndex = 1;
            this.ALL.AutoSize = true;
            this.ALL.Checked = MySettings.Default.ALLQTY;
            this.ALL.DataBindings.Add(new Binding("Checked", MySettings.Default, "ALLQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0x16a, 0x162);
            this.ALL.Location = point;
            this.ALL.Name = "ALL";
            size = new Size(0x48, 0x10);
            this.ALL.Size = size;
            this.ALL.TabIndex = 0;
            this.ALL.Text = "所有功能";
            this.ToolTip1.SetToolTip(this.ALL, "所有功能");
            this.ALL.UseVisualStyleBackColor = true;
            this.COPQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "COPQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.COPQTY.Enabled = MySettings.Default.COPQTY;
            point = new Point(170, 0x39);
            this.COPQTY.Location = point;
            this.COPQTY.MaxLength = 2;
            this.COPQTY.Name = "COPQTY";
            size = new Size(0x29, 0x15);
            this.COPQTY.Size = size;
            this.COPQTY.TabIndex = 1;
            this.ZCS.AutoSize = true;
            this.ZCS.Checked = MySettings.Default.ZCSQTY;
            this.ZCS.DataBindings.Add(new Binding("Checked", MySettings.Default, "ZCSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0xda, 0x162);
            this.ZCS.Location = point;
            this.ZCS.Name = "ZCS";
            size = new Size(0x30, 0x10);
            this.ZCS.Size = size;
            this.ZCS.TabIndex = 0;
            this.ZCS.Text = "资产";
            this.ToolTip1.SetToolTip(this.ZCS, "ZCS 资产");
            this.ZCS.UseVisualStyleBackColor = true;
            this.SXM.AutoSize = true;
            this.SXM.Checked = MySettings.Default.SXMQTY;
            this.SXM.DataBindings.Add(new Binding("Checked", MySettings.Default, "SXMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0xda, 290);
            this.SXM.Location = point;
            this.SXM.Name = "SXM";
            size = new Size(0x48, 0x10);
            this.SXM.Size = size;
            this.SXM.TabIndex = 0;
            this.SXM.Text = "物料需求";
            this.ToolTip1.SetToolTip(this.SXM, "SXM 物料需求");
            this.SXM.UseVisualStyleBackColor = true;
            this.RGS.AutoSize = true;
            this.RGS.Checked = MySettings.Default.RGSQTY;
            this.RGS.DataBindings.Add(new Binding("Checked", MySettings.Default, "RGSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0xda, 0xe9);
            this.RGS.Location = point;
            this.RGS.Name = "RGS";
            size = new Size(0x48, 0x10);
            this.RGS.Size = size;
            this.RGS.TabIndex = 0;
            this.RGS.Text = "报表生成";
            this.ToolTip1.SetToolTip(this.RGS, "RGS 报表生成");
            this.RGS.UseVisualStyleBackColor = true;
            this.KJS.AutoSize = true;
            this.KJS.Checked = MySettings.Default.KJSQTY;
            this.KJS.DataBindings.Add(new Binding("Checked", MySettings.Default, "KJSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0xda, 0xac);
            this.KJS.Location = point;
            this.KJS.Name = "KJS";
            size = new Size(0x48, 0x10);
            this.KJS.Size = size;
            this.KJS.TabIndex = 0;
            this.KJS.Text = "会计总账";
            this.ToolTip1.SetToolTip(this.KJS, "KJS 会计总账");
            this.KJS.UseVisualStyleBackColor = true;
            this.GYS.AutoSize = true;
            this.GYS.Checked = MySettings.Default.GYSQTY;
            this.GYS.DataBindings.Add(new Binding("Checked", MySettings.Default, "GYSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0xda, 0x72);
            this.GYS.Location = point;
            this.GYS.Name = "GYS";
            size = new Size(0x48, 0x10);
            this.GYS.Size = size;
            this.GYS.TabIndex = 0;
            this.GYS.Text = "工单工艺";
            this.ToolTip1.SetToolTip(this.GYS, "GYS 工单工艺");
            this.GYS.UseVisualStyleBackColor = true;
            this.COP.AutoSize = true;
            this.COP.Checked = MySettings.Default.COPQTY;
            this.COP.DataBindings.Add(new Binding("Checked", MySettings.Default, "COPQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(0xda, 0x3b);
            this.COP.Location = point;
            this.COP.Name = "COP";
            size = new Size(0x30, 0x10);
            this.COP.Size = size;
            this.COP.TabIndex = 0;
            this.COP.Text = "销售";
            this.ToolTip1.SetToolTip(this.COP, "COP 销售");
            this.COP.UseVisualStyleBackColor = true;
            this.YSFQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "YSFQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.YSFQTY.Enabled = MySettings.Default.YSFQTY;
            point = new Point(0x17, 350);
            this.YSFQTY.Location = point;
            this.YSFQTY.MaxLength = 2;
            this.YSFQTY.Name = "YSFQTY";
            size = new Size(0x29, 0x15);
            this.YSFQTY.Size = size;
            this.YSFQTY.TabIndex = 1;
            this.YSF.AutoSize = true;
            this.YSF.Checked = MySettings.Default.YSFQTY;
            this.YSF.DataBindings.Add(new Binding("Checked", MySettings.Default, "YSFQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(70, 350);
            this.YSF.Location = point;
            this.YSF.Name = "YSF";
            size = new Size(0x48, 0x10);
            this.YSF.Size = size;
            this.YSF.TabIndex = 0;
            this.YSF.Text = "应收应付";
            this.ToolTip1.SetToolTip(this.YSF, "YSF 应收应付");
            this.YSF.UseVisualStyleBackColor = true;
            this.SGMQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "SGMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.SGMQTY.Enabled = MySettings.Default.SGMQTY;
            point = new Point(0x17, 0x11e);
            this.SGMQTY.Location = point;
            this.SGMQTY.MaxLength = 2;
            this.SGMQTY.Name = "SGMQTY";
            size = new Size(0x29, 0x15);
            this.SGMQTY.Size = size;
            this.SGMQTY.TabIndex = 1;
            this.SGM.AutoSize = true;
            this.SGM.Checked = MySettings.Default.SGMQTY;
            this.SGM.DataBindings.Add(new Binding("Checked", MySettings.Default, "SGMQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(70, 0x11e);
            this.SGM.Location = point;
            this.SGM.Name = "SGM";
            size = new Size(0x48, 0x10);
            this.SGM.Size = size;
            this.SGM.TabIndex = 0;
            this.SGM.Text = "生产管理";
            this.ToolTip1.SetToolTip(this.SGM, "SGM 生产管理");
            this.SGM.UseVisualStyleBackColor = true;
            this.QMSQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "QMSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.QMSQTY.Enabled = MySettings.Default.QMSQTY;
            point = new Point(0x17, 0xe5);
            this.QMSQTY.Location = point;
            this.QMSQTY.MaxLength = 2;
            this.QMSQTY.Name = "QMSQTY";
            size = new Size(0x29, 0x15);
            this.QMSQTY.Size = size;
            this.QMSQTY.TabIndex = 1;
            this.QMS.AutoSize = true;
            this.QMS.Checked = MySettings.Default.QMSQTY;
            this.QMS.DataBindings.Add(new Binding("Checked", MySettings.Default, "QMSQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(70, 0xe5);
            this.QMS.Location = point;
            this.QMS.Name = "QMS";
            size = new Size(0x48, 0x10);
            this.QMS.Size = size;
            this.QMS.TabIndex = 0;
            this.QMS.Text = "检验管理";
            this.ToolTip1.SetToolTip(this.QMS, "QMS 检验管理");
            this.QMS.UseVisualStyleBackColor = true;
            this.JCAQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "JCAQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.JCAQTY.Enabled = MySettings.Default.JCAQTY;
            point = new Point(0x17, 0xa8);
            this.JCAQTY.Location = point;
            this.JCAQTY.MaxLength = 2;
            this.JCAQTY.Name = "JCAQTY";
            size = new Size(0x29, 0x15);
            this.JCAQTY.Size = size;
            this.JCAQTY.TabIndex = 1;
            this.JCA.AutoSize = true;
            this.JCA.Checked = MySettings.Default.JCAQTY;
            this.JCA.DataBindings.Add(new Binding("Checked", MySettings.Default, "JCAQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(70, 0xa8);
            this.JCA.Location = point;
            this.JCA.Name = "JCA";
            size = new Size(0x48, 0x10);
            this.JCA.Size = size;
            this.JCA.TabIndex = 0;
            this.JCA.Text = "营业决策";
            this.ToolTip1.SetToolTip(this.JCA, "JCA 营业决策");
            this.JCA.UseVisualStyleBackColor = true;
            this.FIBQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "FIBQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.FIBQTY.Enabled = MySettings.Default.FIBQTY;
            point = new Point(0x17, 110);
            this.FIBQTY.Location = point;
            this.FIBQTY.MaxLength = 2;
            this.FIBQTY.Name = "FIBQTY";
            size = new Size(0x29, 0x15);
            this.FIBQTY.Size = size;
            this.FIBQTY.TabIndex = 1;
            this.FIB.AutoSize = true;
            this.FIB.Checked = MySettings.Default.FIBQTY;
            this.FIB.DataBindings.Add(new Binding("Checked", MySettings.Default, "FIBQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(70, 110);
            this.FIB.Location = point;
            this.FIB.Name = "FIB";
            size = new Size(60, 0x10);
            this.FIB.Size = size;
            this.FIB.TabIndex = 0;
            this.FIB.Text = "财务包";
            this.ToolTip1.SetToolTip(this.FIB, "FIB 财务包(会计总帐/应收应付)");
            this.FIB.UseVisualStyleBackColor = true;
            this.BASQTY.DataBindings.Add(new Binding("Enabled", MySettings.Default, "BASQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            this.BASQTY.Enabled = MySettings.Default.BASQTY;
            point = new Point(0x17, 0x37);
            this.BASQTY.Location = point;
            this.BASQTY.MaxLength = 2;
            this.BASQTY.Name = "BASQTY";
            size = new Size(0x29, 0x15);
            this.BASQTY.Size = size;
            this.BASQTY.TabIndex = 1;
            this.BAS.AutoSize = true;
            this.BAS.Checked = MySettings.Default.BASQTY;
            this.BAS.DataBindings.Add(new Binding("Checked", MySettings.Default, "BASQTY", true, DataSourceUpdateMode.OnPropertyChanged));
            point = new Point(70, 0x37);
            this.BAS.Location = point;
            this.BAS.Name = "BAS";
            size = new Size(60, 0x10);
            this.BAS.Size = size;
            this.BAS.TabIndex = 0;
            this.BAS.Text = "基础包";
            this.ToolTip1.SetToolTip(this.BAS, "BAS 基础包（销售/采购/存货/应收应付/报表生成）");
            this.BAS.UseVisualStyleBackColor = true;
            point = new Point(13, 0x1e8);
            this.REGSTR.Location = point;
            this.REGSTR.Name = "REGSTR";
            size = new Size(0x26a, 0x15);
            this.REGSTR.Size = size;
            this.REGSTR.TabIndex = 3;
            this.ToolTip1.SetToolTip(this.REGSTR, "请输入要注册的公司名！");
            this.Label61.AutoSize = true;
            point = new Point(12, 470);
            this.Label61.Location = point;
            this.Label61.Name = "Label61";
            size = new Size(0x41, 12);
            this.Label61.Size = size;
            this.Label61.TabIndex = 2;
            this.Label61.Text = "注册公司名";
            this.Label62.AutoSize = true;
            point = new Point(10, 520);
            this.Label62.Location = point;
            this.Label62.Name = "Label62";
            size = new Size(0x29, 12);
            this.Label62.Size = size;
            this.Label62.TabIndex = 2;
            this.Label62.Text = "序列号";
            point = new Point(0x1f0, 0x21a);
            this.PW.Location = point;
            this.PW.Name = "PW";
            this.PW.ReadOnly = true;
            size = new Size(0x87, 0x15);
            this.PW.Size = size;
            this.PW.TabIndex = 1;
            this.Label63.AutoSize = true;
            point = new Point(0x1ee, 520);
            this.Label63.Location = point;
            this.Label63.Name = "Label63";
            size = new Size(0x35, 12);
            this.Label63.Size = size;
            this.Label63.TabIndex = 2;
            this.Label63.Text = "验证口令";
            this.Label64.AutoSize = true;
            point = new Point(12, 7);
            this.Label64.Location = point;
            this.Label64.Name = "Label64";
            size = new Size(0x35, 12);
            this.Label64.Size = size;
            this.Label64.TabIndex = 2;
            this.Label64.Text = "安装代号";
            this.ToolTip1.IsBalloon = true;
            point = new Point(0x1de, 0x18);
            this.CCode.Location = point;
            this.CCode.MaxLength = 6;
            this.CCode.Name = "CCode";
            size = new Size(0x99, 0x15);
            this.CCode.Size = size;
            this.CCode.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.CCode, "请输入客服代号！");
            this.Label55.AutoSize = true;
            point = new Point(0x1dc, 7);
            this.Label55.Location = point;
            this.Label55.Name = "Label55";
            size = new Size(0x35, 12);
            this.Label55.Size = size;
            this.Label55.TabIndex = 2;
            this.Label55.Text = "客户代号";
            SizeF ef = new SizeF(6f, 12f);
            this.AutoScaleDimensions = ef;
            this.AutoScaleMode = AutoScaleMode.Font;
            size = new Size(0x283, 610);
            this.ClientSize = size;
            this.Controls.Add(this.REGSTR);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.KEY);
            this.Controls.Add(this.CCode);
            this.Controls.Add(this.SN);
            this.Controls.Add(this.Label55);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label64);
            this.Controls.Add(this.Label63);
            this.Controls.Add(this.Label62);
            this.Controls.Add(this.Label61);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Keygen";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public string StrEncrypt(string input, bool ror)
        {
            byte num = Conversions.ToByte(input.Trim());
            return "";
        }

        internal virtual Button Button1
        {
            [DebuggerNonUserCode]
            get => 
                this._Button1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.Button1_Click);
                if (this._Button1 != null)
                {
                    this._Button1.Click -= handler;
                }
                this._Button1 = value;
                if (this._Button1 != null)
                {
                    this._Button1.Click += handler;
                }
            }
        }

        internal virtual TextBox SN
        {
            [DebuggerNonUserCode]
            get => 
                this._SN;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._SN = value;
        }

        internal virtual TextBox KEY
        {
            [DebuggerNonUserCode]
            get => 
                this._KEY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._KEY = value;
        }

        internal virtual GroupBox GroupBox1
        {
            [DebuggerNonUserCode]
            get => 
                this._GroupBox1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._GroupBox1 = value;
        }

        internal virtual CheckBox BAS
        {
            [DebuggerNonUserCode]
            get => 
                this._BAS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._BAS != null)
                {
                    this._BAS.CheckStateChanged -= handler;
                }
                this._BAS = value;
                if (this._BAS != null)
                {
                    this._BAS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual Label Label10
        {
            [DebuggerNonUserCode]
            get => 
                this._Label10;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label10 = value;
        }

        internal virtual Label Label8
        {
            [DebuggerNonUserCode]
            get => 
                this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label8 = value;
        }

        internal virtual Label Label6
        {
            [DebuggerNonUserCode]
            get => 
                this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label6 = value;
        }

        internal virtual Label Label4
        {
            [DebuggerNonUserCode]
            get => 
                this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label4 = value;
        }

        internal virtual Label Label2
        {
            [DebuggerNonUserCode]
            get => 
                this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label2 = value;
        }

        internal virtual Label Label9
        {
            [DebuggerNonUserCode]
            get => 
                this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label9 = value;
        }

        internal virtual Label Label7
        {
            [DebuggerNonUserCode]
            get => 
                this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label7 = value;
        }

        internal virtual Label Label5
        {
            [DebuggerNonUserCode]
            get => 
                this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label5 = value;
        }

        internal virtual Label Label3
        {
            [DebuggerNonUserCode]
            get => 
                this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label3 = value;
        }

        internal virtual Label Label1
        {
            [DebuggerNonUserCode]
            get => 
                this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label1 = value;
        }

        internal virtual TextBox CWBQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._CWBQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._CWBQTY = value;
        }

        internal virtual TextBox CRMQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._CRMQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._CRMQTY = value;
        }

        internal virtual CheckBox CRM
        {
            [DebuggerNonUserCode]
            get => 
                this._CRM;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._CRM != null)
                {
                    this._CRM.CheckStateChanged -= handler;
                }
                this._CRM = value;
                if (this._CRM != null)
                {
                    this._CRM.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox COPQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._COPQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._COPQTY = value;
        }

        internal virtual CheckBox COP
        {
            [DebuggerNonUserCode]
            get => 
                this._COP;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._COP != null)
                {
                    this._COP.CheckStateChanged -= handler;
                }
                this._COP = value;
                if (this._COP != null)
                {
                    this._COP.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox BASQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._BASQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._BASQTY = value;
        }

        internal virtual Label Label50
        {
            [DebuggerNonUserCode]
            get => 
                this._Label50;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label50 = value;
        }

        internal virtual Label Label40
        {
            [DebuggerNonUserCode]
            get => 
                this._Label40;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label40 = value;
        }

        internal virtual Label Label30
        {
            [DebuggerNonUserCode]
            get => 
                this._Label30;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label30 = value;
        }

        internal virtual Label Label20
        {
            [DebuggerNonUserCode]
            get => 
                this._Label20;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label20 = value;
        }

        internal virtual Label Label49
        {
            [DebuggerNonUserCode]
            get => 
                this._Label49;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label49 = value;
        }

        internal virtual Label Label39
        {
            [DebuggerNonUserCode]
            get => 
                this._Label39;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label39 = value;
        }

        internal virtual Label Label29
        {
            [DebuggerNonUserCode]
            get => 
                this._Label29;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label29 = value;
        }

        internal virtual Label Label19
        {
            [DebuggerNonUserCode]
            get => 
                this._Label19;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label19 = value;
        }

        internal virtual Label Label48
        {
            [DebuggerNonUserCode]
            get => 
                this._Label48;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label48 = value;
        }

        internal virtual Label Label38
        {
            [DebuggerNonUserCode]
            get => 
                this._Label38;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label38 = value;
        }

        internal virtual Label Label28
        {
            [DebuggerNonUserCode]
            get => 
                this._Label28;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label28 = value;
        }

        internal virtual Label Label18
        {
            [DebuggerNonUserCode]
            get => 
                this._Label18;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label18 = value;
        }

        internal virtual Label Label57
        {
            [DebuggerNonUserCode]
            get => 
                this._Label57;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label57 = value;
        }

        internal virtual Label Label47
        {
            [DebuggerNonUserCode]
            get => 
                this._Label47;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label47 = value;
        }

        internal virtual Label Label37
        {
            [DebuggerNonUserCode]
            get => 
                this._Label37;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label37 = value;
        }

        internal virtual Label Label27
        {
            [DebuggerNonUserCode]
            get => 
                this._Label27;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label27 = value;
        }

        internal virtual Label Label17
        {
            [DebuggerNonUserCode]
            get => 
                this._Label17;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label17 = value;
        }

        internal virtual Label Label56
        {
            [DebuggerNonUserCode]
            get => 
                this._Label56;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label56 = value;
        }

        internal virtual Label Label46
        {
            [DebuggerNonUserCode]
            get => 
                this._Label46;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label46 = value;
        }

        internal virtual Label Label36
        {
            [DebuggerNonUserCode]
            get => 
                this._Label36;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label36 = value;
        }

        internal virtual Label Label26
        {
            [DebuggerNonUserCode]
            get => 
                this._Label26;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label26 = value;
        }

        internal virtual Label Label16
        {
            [DebuggerNonUserCode]
            get => 
                this._Label16;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label16 = value;
        }

        internal virtual Label Label45
        {
            [DebuggerNonUserCode]
            get => 
                this._Label45;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label45 = value;
        }

        internal virtual Label Label35
        {
            [DebuggerNonUserCode]
            get => 
                this._Label35;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label35 = value;
        }

        internal virtual Label Label25
        {
            [DebuggerNonUserCode]
            get => 
                this._Label25;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label25 = value;
        }

        internal virtual Label Label15
        {
            [DebuggerNonUserCode]
            get => 
                this._Label15;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label15 = value;
        }

        internal virtual Label Label44
        {
            [DebuggerNonUserCode]
            get => 
                this._Label44;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label44 = value;
        }

        internal virtual Label Label34
        {
            [DebuggerNonUserCode]
            get => 
                this._Label34;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label34 = value;
        }

        internal virtual Label Label24
        {
            [DebuggerNonUserCode]
            get => 
                this._Label24;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label24 = value;
        }

        internal virtual Label Label14
        {
            [DebuggerNonUserCode]
            get => 
                this._Label14;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label14 = value;
        }

        internal virtual Label Label43
        {
            [DebuggerNonUserCode]
            get => 
                this._Label43;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label43 = value;
        }

        internal virtual Label Label33
        {
            [DebuggerNonUserCode]
            get => 
                this._Label33;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label33 = value;
        }

        internal virtual Label Label23
        {
            [DebuggerNonUserCode]
            get => 
                this._Label23;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label23 = value;
        }

        internal virtual Label Label13
        {
            [DebuggerNonUserCode]
            get => 
                this._Label13;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label13 = value;
        }

        internal virtual Label Label52
        {
            [DebuggerNonUserCode]
            get => 
                this._Label52;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label52 = value;
        }

        internal virtual Label Label42
        {
            [DebuggerNonUserCode]
            get => 
                this._Label42;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label42 = value;
        }

        internal virtual Label Label32
        {
            [DebuggerNonUserCode]
            get => 
                this._Label32;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label32 = value;
        }

        internal virtual Label Label22
        {
            [DebuggerNonUserCode]
            get => 
                this._Label22;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label22 = value;
        }

        internal virtual Label Label12
        {
            [DebuggerNonUserCode]
            get => 
                this._Label12;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label12 = value;
        }

        internal virtual Label Label51
        {
            [DebuggerNonUserCode]
            get => 
                this._Label51;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label51 = value;
        }

        internal virtual Label Label41
        {
            [DebuggerNonUserCode]
            get => 
                this._Label41;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label41 = value;
        }

        internal virtual Label Label31
        {
            [DebuggerNonUserCode]
            get => 
                this._Label31;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label31 = value;
        }

        internal virtual Label Label21
        {
            [DebuggerNonUserCode]
            get => 
                this._Label21;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label21 = value;
        }

        internal virtual Label Label11
        {
            [DebuggerNonUserCode]
            get => 
                this._Label11;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label11 = value;
        }

        internal virtual TextBox WLBQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._WLBQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._WLBQTY = value;
        }

        internal virtual TextBox SCMQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._SCMQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._SCMQTY = value;
        }

        internal virtual TextBox PURQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._PURQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._PURQTY = value;
        }

        internal virtual TextBox INVQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._INVQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._INVQTY = value;
        }

        internal virtual CheckBox WLB
        {
            [DebuggerNonUserCode]
            get => 
                this._WLB;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._WLB != null)
                {
                    this._WLB.CheckStateChanged -= handler;
                }
                this._WLB = value;
                if (this._WLB != null)
                {
                    this._WLB.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox SCM
        {
            [DebuggerNonUserCode]
            get => 
                this._SCM;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._SCM != null)
                {
                    this._SCM.CheckStateChanged -= handler;
                }
                this._SCM = value;
                if (this._SCM != null)
                {
                    this._SCM.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox PUR
        {
            [DebuggerNonUserCode]
            get => 
                this._PUR;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._PUR != null)
                {
                    this._PUR.CheckStateChanged -= handler;
                }
                this._PUR = value;
                if (this._PUR != null)
                {
                    this._PUR.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox INV
        {
            [DebuggerNonUserCode]
            get => 
                this._INV;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._INV != null)
                {
                    this._INV.CheckStateChanged -= handler;
                }
                this._INV = value;
                if (this._INV != null)
                {
                    this._INV.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox SYSQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._SYSQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._SYSQTY = value;
        }

        internal virtual TextBox RMAQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._RMAQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._RMAQTY = value;
        }

        internal virtual TextBox PJMQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._PJMQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._PJMQTY = value;
        }

        internal virtual TextBox GZSQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._GZSQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._GZSQTY = value;
        }

        internal virtual CheckBox SYS
        {
            [DebuggerNonUserCode]
            get => 
                this._SYS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._SYS != null)
                {
                    this._SYS.CheckStateChanged -= handler;
                }
                this._SYS = value;
                if (this._SYS != null)
                {
                    this._SYS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox RMA
        {
            [DebuggerNonUserCode]
            get => 
                this._RMA;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._RMA != null)
                {
                    this._RMA.CheckStateChanged -= handler;
                }
                this._RMA = value;
                if (this._RMA != null)
                {
                    this._RMA.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox PJM
        {
            [DebuggerNonUserCode]
            get => 
                this._PJM;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._PJM != null)
                {
                    this._PJM.CheckStateChanged -= handler;
                }
                this._PJM = value;
                if (this._PJM != null)
                {
                    this._PJM.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox GZS
        {
            [DebuggerNonUserCode]
            get => 
                this._GZS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._GZS != null)
                {
                    this._GZS.CheckStateChanged -= handler;
                }
                this._GZS = value;
                if (this._GZS != null)
                {
                    this._GZS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox ZCSQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._ZCSQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._ZCSQTY = value;
        }

        internal virtual TextBox SXMQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._SXMQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._SXMQTY = value;
        }

        internal virtual TextBox RGSQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._RGSQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._RGSQTY = value;
        }

        internal virtual TextBox KJSQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._KJSQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._KJSQTY = value;
        }

        internal virtual TextBox GYSQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._GYSQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._GYSQTY = value;
        }

        internal virtual CheckBox ZCS
        {
            [DebuggerNonUserCode]
            get => 
                this._ZCS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._ZCS != null)
                {
                    this._ZCS.CheckStateChanged -= handler;
                }
                this._ZCS = value;
                if (this._ZCS != null)
                {
                    this._ZCS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox RGS
        {
            [DebuggerNonUserCode]
            get => 
                this._RGS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._RGS != null)
                {
                    this._RGS.CheckStateChanged -= handler;
                }
                this._RGS = value;
                if (this._RGS != null)
                {
                    this._RGS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox KJS
        {
            [DebuggerNonUserCode]
            get => 
                this._KJS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._KJS != null)
                {
                    this._KJS.CheckStateChanged -= handler;
                }
                this._KJS = value;
                if (this._KJS != null)
                {
                    this._KJS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox GYS
        {
            [DebuggerNonUserCode]
            get => 
                this._GYS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._GYS != null)
                {
                    this._GYS.CheckStateChanged -= handler;
                }
                this._GYS = value;
                if (this._GYS != null)
                {
                    this._GYS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox YSFQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._YSFQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._YSFQTY = value;
        }

        internal virtual CheckBox YSF
        {
            [DebuggerNonUserCode]
            get => 
                this._YSF;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._YSF != null)
                {
                    this._YSF.CheckStateChanged -= handler;
                }
                this._YSF = value;
                if (this._YSF != null)
                {
                    this._YSF.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox SGMQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._SGMQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._SGMQTY = value;
        }

        internal virtual CheckBox SGM
        {
            [DebuggerNonUserCode]
            get => 
                this._SGM;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._SGM != null)
                {
                    this._SGM.CheckStateChanged -= handler;
                }
                this._SGM = value;
                if (this._SGM != null)
                {
                    this._SGM.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox QMSQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._QMSQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._QMSQTY = value;
        }

        internal virtual CheckBox QMS
        {
            [DebuggerNonUserCode]
            get => 
                this._QMS;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._QMS != null)
                {
                    this._QMS.CheckStateChanged -= handler;
                }
                this._QMS = value;
                if (this._QMS != null)
                {
                    this._QMS.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox JCAQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._JCAQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._JCAQTY = value;
        }

        internal virtual CheckBox JCA
        {
            [DebuggerNonUserCode]
            get => 
                this._JCA;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._JCA != null)
                {
                    this._JCA.CheckStateChanged -= handler;
                }
                this._JCA = value;
                if (this._JCA != null)
                {
                    this._JCA.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox FIBQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._FIBQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._FIBQTY = value;
        }

        internal virtual CheckBox FIB
        {
            [DebuggerNonUserCode]
            get => 
                this._FIB;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._FIB != null)
                {
                    this._FIB.CheckStateChanged -= handler;
                }
                this._FIB = value;
                if (this._FIB != null)
                {
                    this._FIB.CheckStateChanged += handler;
                }
            }
        }

        internal virtual TextBox REGSTR
        {
            [DebuggerNonUserCode]
            get => 
                this._REGSTR;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._REGSTR = value;
        }

        internal virtual Label Label61
        {
            [DebuggerNonUserCode]
            get => 
                this._Label61;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label61 = value;
        }

        internal virtual Label Label62
        {
            [DebuggerNonUserCode]
            get => 
                this._Label62;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label62 = value;
        }

        internal virtual TextBox PW
        {
            [DebuggerNonUserCode]
            get => 
                this._PW;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._PW = value;
        }

        internal virtual Label Label63
        {
            [DebuggerNonUserCode]
            get => 
                this._Label63;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label63 = value;
        }

        internal virtual Label Label64
        {
            [DebuggerNonUserCode]
            get => 
                this._Label64;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label64 = value;
        }

        internal virtual Label Label54
        {
            [DebuggerNonUserCode]
            get => 
                this._Label54;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label54 = value;
        }

        internal virtual Label Label53
        {
            [DebuggerNonUserCode]
            get => 
                this._Label53;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label53 = value;
        }

        internal virtual TextBox ALLQTY
        {
            [DebuggerNonUserCode]
            get => 
                this._ALLQTY;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._ALLQTY = value;
        }

        internal virtual CheckBox ALL
        {
            [DebuggerNonUserCode]
            get => 
                this._ALL;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.ALL_CheckStateChanged);
                if (this._ALL != null)
                {
                    this._ALL.CheckStateChanged -= handler;
                }
                this._ALL = value;
                if (this._ALL != null)
                {
                    this._ALL.CheckStateChanged += handler;
                }
            }
        }

        internal virtual CheckBox CWB
        {
            [DebuggerNonUserCode]
            get => 
                this._CWB;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._CWB != null)
                {
                    this._CWB.CheckStateChanged -= handler;
                }
                this._CWB = value;
                if (this._CWB != null)
                {
                    this._CWB.CheckStateChanged += handler;
                }
            }
        }

        internal virtual ToolTip ToolTip1
        {
            [DebuggerNonUserCode]
            get => 
                this._ToolTip1;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._ToolTip1 = value;
        }

        internal virtual CheckBox SXM
        {
            [DebuggerNonUserCode]
            get => 
                this._SXM;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                EventHandler handler = new EventHandler(this.BAS_CheckStateChanged);
                if (this._SXM != null)
                {
                    this._SXM.CheckStateChanged -= handler;
                }
                this._SXM = value;
                if (this._SXM != null)
                {
                    this._SXM.CheckStateChanged += handler;
                }
            }
        }

        internal virtual Label Label55
        {
            [DebuggerNonUserCode]
            get => 
                this._Label55;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._Label55 = value;
        }

        internal virtual TextBox CCode
        {
            [DebuggerNonUserCode]
            get => 
                this._CCode;
            [MethodImpl(MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set => 
                this._CCode = value;
        }
    }
}

