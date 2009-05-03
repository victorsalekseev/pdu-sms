using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ������� SMS, ���������� � ������� PDU
        /// </summary>
        enum message_status_pdu
        {
           received_unread = 0, //It refers to the message status "received unread".
           received_read   = 1, //It refers to the message status "received read".
           stored_unsent   = 2, //It refers to the message status "stored unsent".
           stored_sent     = 3 //It refers to the message status "stored sent".
        }

        /// <summary>
        /// ��� ������������� ������
        /// </summary>
        enum TypeOfNumber
        {
            National      = 0x81,
            International = 0x91
        }

        enum DEncProtocol
        {
            SbitDefault = 0x00,// 7-bit 160chr in 140pc bytes 
            UTF7        = 0x08// - BigEndianUnicode (UTF7)
            //#	'F0' for 7bit, immediate display	'7biti'
            //#	'F6' for 8bit, SIM specific			'8bit'
            //#	'F4' for 8bit, immediate display	'8biti'
            //#	'F5' for 8bit, ME specific			'8bitm'
        }

        /// <summary>
        /// ��������� ������������ SMS � PDU-�������
        /// </summary>
        struct RPDUSMS
        {
            /*
            07 91 9730071111F1 04 0B 91 9730232933F1 00 00 90408290434361 1C 31D98C56B3DD7039582C2693CD66345AAD66B3DD6E385C2E07
            */
            //��� SCA
            public byte SMSC_num_len;//= 0;����� � ������� 2-� ���� �����  07
            //����� - ������ SCA ����� � ������ 
            //(��������� ���� ���� � ������), ����
            //������ ����� 0 �� ��������� SCA
            //���������� �����������.
            public byte SMSC_type_of_num;//= (byte)0x91;//��.TypeOfNumber   91
            public string SMSC_num;//= string.Empty;//� ������� BCD         9730071111F1
            //��� SCA

            //��� PDU Type
            public byte TPDU;//= 0x00;//�� ��������� ��� ��������� ������   00
            //��� PDU Type

            //��� OA
            public byte OA_ref_num_len;//= 0x0B;//����������� �����         0B
            //��������-���������, ������ 11 ����. CXXXZZZYYAA
            public byte OA_type_of_num;//= (byte)0x91;//��. TypeOfNumber    91
            //�������-��������
            public string OA_num;//= string.Empty;//� ������� BCD           9730232933F1
            //��� OA

            //��� PID 
            //������������� ��������� - ��������� SMSC,
            //��� ������������ ���������
            public byte PID;//= 0x00;//                                     00
            //������������� ������ ���������, ���� �� ����� 0,
            //�� ������ ���� ����� 41..47 ��� ����, ����� ��������
            //��������� � ���� �� �������� ��������� (��� � ��+!!!)
            //#		41H:	Replace Short Message Type1
            //#		...
            //#		47H:	Replace Short Message Type7
            //#		Can be used to replace previously sent SMS messgaes in the MS (Mobile Station)
            //��� PID
            //��� PID

            //��� DCS
            //��������� ����� ��������� ����������� ���
            //�������� ����� ��������� (��� ����� �� ����� 
            //��� ��� �������������) � ������ ��������� 
            //����� ���������.
            public byte DCS;//= 0x00;// 7-bit 160chr in 140pc bytes         00
            //0x08 - BigEndianUnicode (UTF7)
            //#	'F0' for 7bit, immediate display	'7biti'
            //#	'F6' for 8bit, SIM specific			'8bit'
            //#	'F4' for 8bit, immediate display	'8biti'
            //#	'F5' for 8bit, ME specific			'8bitm'

            //��� DCS

            //��� SCTS
            //����� ��������� SMS �������� ����������
            public DateTime SCTS;//= "10101010000000";//                    90408290434361
            //��� SCTS

            //��� UDL
            //����� ���� UD (���������)
            public byte UDL;//= 0x01;//����� "����������" ������ � ������   1C
            //��� ���������, � ������� SMS ������
            /*
            7BIT 1C 31D98C56B3DD7039582C2693CD66345AAD66B3DD6E385C2E07
                                          1234567890112233445566778899
                                                                       
            UCS2 0C 041F 0440 0438 0432 0435 0442
                       �    �    �    �    �    �
            */
            //��� UDL
            
            //��� UD
            public string UD;//= "0C";//��������� ���������                  31D98C56B3DD7039582C2693CD66345AAD66B3DD6E385C2E07
            //��� UD
        }

        /// <summary>
        /// ��������� ������������� SMS � PDU-�������
        /// </summary>
        struct SPDUSMS
        {
            /*
            07 91 8350000005F1 31 00 0C 91 835010325467 00 08 AA 0� 041F04400438043204350442
            */
            //��� SCA
            public byte SMSC_num_len;//= 0;����� � ������� 2-� ���� �����   07
            //����� - ������ SCA ����� � ������ 
            //(��������� ���� �����), ����
            //������ ����� 0 �� ��������� SCA
            //���������� �����������.
            public byte SMSC_type_of_num;//= (byte)0x91;//��.TypeOfNumber   91
            public string SMSC_num;//= string.Empty;//� ������� BCD         8350000005F1
            //��� SCA

            //��� PDU Type
            public byte TPDU;//= 0x01;//�� ��������� ��� ���������� ������  31
            //0001L - MTI: ��������� SMS ���� ��������� � �������� SMS � 
            //����������� ������� �������� - 0011H
            //��. SetTPDU, ����� ��������, ��� ������ ������������
            //1 ���� VP!!!. � ���� �� 01 - ������ �� �� ���� :)
            //��� PDU Type

            //��� MR
            public byte MR;//= 0;//0.255 ���-�� ������� ������������ SMS    00
            //��� MR

            //��� DA 
            //������������� ����������
            public byte DA_ref_len;//= 0x0B;// ����� �������� ����������   0C
            //��������-���������, ������ 11 ����. CXXXZZZYYAA
            public byte DA_type_of_num;//= (byte)0x91;//��. TypeOfNumber    91
            public string DA_num;//= string.Empty;//� ������� BCD           835010325467
            //��� DA

            //��� PID 
            //������������� ��������� - ��������� SMSC,
            //��� ������������ ���������
            public byte PID;//= 0x00;//                                     00
            //������������� ������ ���������, ���� �� ����� 0,
            //�� ������ ���� ����� 41..47 ��� ����, ����� ��������
            //��������� � ���� �� �������� ��������� (��� � ��+!!!)            
            //#		41H:	Replace Short Message Type1
            //#		...
            //#		47H:	Replace Short Message Type7
            //#		Can be used to replace previously sent SMS messgaes in the MS (Mobile Station)
            //��� PID

            //��� DCS
            //��������� ����� ��������� ����������� ���
            //�������� ����� ��������� (��� ����� �� ����� 
            //��� ��� �������������) � ������ ��������� 
            //����� ���������.
            public byte DCS;//= 0x00;// 7-bit 160chr in 140pc bytes         08
            //0x08 - BigEndianUnicode (UTF7)            
            //#	'F0' for 7bit, immediate display	'7biti'
            //#	'F6' for 8bit, SIM specific			'8bit'
            //#	'F4' for 8bit, immediate display	'8biti'
            //#	'F5' for 8bit, ME specific			'8bitm'
            //��� DCS

            //��� VP
            //����� �������� ���������
            public byte VP;//= "0,1,7 ����";//                            AA
            //0 0 : TP-VP field not present
            //1 0 : TP-VP field present. Relative format (one octet)
            //0 1 : TP-VP field present. Enhanced format (7 octets)
            //1 1 : TP-VP field present. Absolute format (7 octets)
            //������������ AA
            //��� VP

            //��� UDL
            //����� ���� UD (���������)
            public byte UDL;//= 0x01;//����� "����������" ������ � ������   0C
            //��� ���������, � ������� SMS ������
            /*
            7BIT 1C 31D98C56B3DD7039582C2693CD66345AAD66B3DD6E385C2E07
                                          1234567890112233445566778899
                                                                       
            UCS2 0C 041F 0440 0438 0432 0435 0442
                       �    �    �    �    �    �
            */
            //��� UDL

            //��� UD
            public string UD;//= "0C";//��������� ���������                 041F04400438043204350442
            //��� UD
        }

        /// <summary>
        /// �������� TPDU
        /// </summary>
        /// <returns></returns>
        private byte SetTPDU(bool isSend)
        {
            /*
            TODO: ��� ����� ���������, �� ��� ��� �� ����� ����
            R:
            +------+----+------+-----+-----+----+-----+ 
            | ���� |  7 |  6   | 5   | 4 3 | 2  | 1 0 | 
            +------+----+------+-----+-----+----+-----+ 
                   | RP | UDHI | SRI | n/a | MMS| MTI | 
                   +----+------+-----+-----+----+-----+
            
            RP (Reply Path) � 0: ���������� �� �������� ���� �����������, 1: ���������� �� �������� ���� ������������ 
            UDHI (User Data Header Information) � 0: � "UD" ������ ���������, 1: ������ "UD" �������� ��������� � ��������� (�� ���� �� ������� � ��������� ����) 
            SRI (Status Report Inf) � ���������� ��������� �������� ������ ��������� (0: ��� �������, 1: ������)
            n/a - �� �������� ��������� �� �� ������������!
            MMS - ���������� �� ������������ ��������� � SMSC
            MTI (Message Type) - ��� ���������: 00 - ��������, 01 - ���������
            
            S:
            +------+----+------+-----+-----+----+-----+ 
            | ���� |  7 |  6   | 5   | 4 3 | 2  | 1 0 | 
            +------+----+------+-----+-----+----+-----+ 
                   | RP | UDHI | SRR | VPF | RD | MTI | 
                   +----+------+-----+-----+----+-----+
            
            RP (Reply Path) � 0: ���������� �� �������� ���� �����������, 1: ���������� �� �������� ���� ������������ 
            UDHI (User Data Header Information) � 0: � "UD" ������ ���������, 1: ������ "UD" �������� ��������� � ��������� (�� ���� �� ������� � ��������� ����) 
            SRR (Status Report Requirement) � 0: ��� ������� �� ������, 1: ������ �� ������ 
            VPF (Validity Period Format) - ���� ������� ���� VP, �� �������� ��������� �� �� ������������!
            RD 	- ������� ���������
            MTI (Message Type) - ��� ���������: 00 - ��������, 01 - ���������
            
            # RP:
	        #	Reply path : 0 = not set / 1 = set
	        # UDHI:
	        #	User data only contains short message : 0
	        #	User data contains a header :			1
	        # SRR:
	        #	Status report requested	:	0 = no / 1 = yes
	        # VPF:
	        #	Validity period field
	        #	0 0	:	Not set
	        #	0 1 :	Reserved
	        #	1 0	:	VP field present : relative (integer)
	        #	1 1 :	VP field present : absolute	(semi-octet)
	        # RD:
	        #	Reject (1)  or accept (0) an SMS in the SMSC with the same MR and DA from the same OA
	        # MTI:
	        #	Message type
	        #	0 0	:	SMS deliver SMSC -> MS
	        #	0 1	:	SMS Submit	MS->SMSC
	        #
	        # We default this field to: 00010001, which means
	        #	Validity period in relative format if $vp
	        #	SMSSubmit type of message
	        #	Accept the same message in the SMSC again
            */
            byte ret = 0x00;//� � �������� 0x04 ���� �� ��������
            if (isSend)
            {
                ret = 0x01;
            }
            return ret;
        }

        /// <summary>
        /// �������� DCS
        /// </summary>
        /// <param name="isUnicode">������?</param>
        /// <returns></returns>
        private byte SetDCS(bool isUnicode)
        {
            /*
            +------+------------------+---+---------+ 
            | ���� |          7 6 5 4 | 3 |   2 1 0 | 
            +------+------------------+---+---------+ 
                   | ������ ��������� | 0 |   X X X | 
                   +------------------+---+---------+
            */
            //����� ����� ��� �����������: UTB � 7bit default alphabet
            byte ret = 0x00;
            if (isUnicode)
            {
                ret = 0x08;
            }
            //� ������ ���
            /*        
	        ###########################################################################
	        # 5) Get data coding scheme
	        # -------------------------------------------------------------------------
	        # Structure:
	        #	bits	    7 6 5 4      3   2   1   0
	        #           +--------------+---+---+---+---+
	        #			| Coding group | 0 | X | X | X |	
	        #           +--------------+---+---+---+---+	
	        # Examples:
	        #				0 0 0 0      0   0   0   0		: 00H	: 7-bit datacoding, default alphabet
	        #				1 1 1 1      0   1   1   0		: F6H	: 8-bit datacoding Class 2
	        #
	        # Coding group	 |	Alphabet indication
	        # ---------------+---------------------------------------------------------
	        # 	0000         | 0000		Default alphabet
	        #                | 0001		Reserved
	        #                | ...		"    " 
	        #                | 1111		"    "
	        # ---------------+---------------------------------------------------------
	        #   0001-1110    | Reserved coding groups
	        # ---------------+---------------------------------------------------------
	        #   1111		 | bit 3 		: Reserved, always 0
	        #                | bit 2 		: Data Coding
	        #				 |					0	:	Default alphabet (7bit)
	        #				 |					1	:	8 bit encoding INTEL-ASCII
	        #                | bits 1 0 	: Message Class
	        #                |					0 0	:	Class 0, immedidate display
	        #                |                  0 1 :	Class 1, ME specific	(Mobile Equiment)
	        #				 |					1 0 :	Class 2, SIM specific	
	        #				 |					1 1 :	Class 3, TE specific    (Terminate Equipment)
	        # ---------------+---------------------------------------------------------
	        #   We have 2 possible ways of interpreting this for our SMS software
	        #	7 bit default alphabet	:	00000000	111100xx
	        #	8 bit intel-ascii       :	111101xx
	        #		x being a wild card
	        ###########################################################################
            */
     return ret;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int f = Convert.ToChar("4");

// for i:=1 to length(s) do begin
//  k:= ord(s[i]);
//  if k>=192 then k:= k + 1040 - 192;
//  result:= result + inttohex(k,4)
// end
//end;

            string a = HexToBin("0D", 4);
            string b = PDU7bToString("31D98C56B3DD7039582C2693CD66345AAD66B3DD6E385C2E07");
            string kj = BinToHex("1011101", "2");
            string[] � = StringToPDU7b("1234567890112233445566778899");
            string[] s = StringToUCS2("������");
            string h = BCDFixNum("+79033292331");
            string h1 = BCDUnFixNum("9730232933F1");
            DateTime dt=GetSMSTime("90408290244361");
            string k = USC2toString("041F04400438043204350442");
            string l = StringToUCS2("������")[1];
            int nmm = 0;
            GetPDUSendStr("", TypeOfNumber.International, "79033292331", TypeOfNumber.International, DEncProtocol.UTF7, "����", out nmm);

            int[] index, message_status;
            string[] address_text;
            //ReadPDUInboxSMS("AT+CMGL=1\r\n\r\n+CMGL: 2,1,,160\r\n07919772009057F8400DD0CDF2396C7CBB010008809003715582008C050003B702010423002004120430044100200438043C0435044E04420441044F0020043F0440043E043F044304490435043D043D044B043500200432044B0437043E0432044B002E002004170432043E043D043A043E04320020043E04420020002B003700390031003900380033003000330034003500340020003A00200031002C0020043F043E0441043B\r\n+CMGL: 3,1,,100\r\n07919772009057F8440DD0CDF2396C7CBB0100088090037155820050050003B7020204350434043D04380439002004370432043E043D043E043A003A002000310037003A00350035002000330030005F00300039005F003200300030003800200028004D0053004B0029002E\r\n+CMGL: 4,1,,27\r\n07919730071111F1040B919730232933F1000890407201933161080031003200340435\r\n+CMGL: 5,1,,22\r\n07919730071111F1040B919730232933F100009040728153846103335A0D\r\n+CMGL: 6,1,,25\r\n07919730071111F1040B919730232933F100009040728173836106B3D96C369B01\r\n+CMGL: 7,1,,29\r\n07919730071111F1040B919730232933F10008904072817483610A0430043F044004330441\r\n+CMGL: 8,1,,22\r\n07919730071111F1040B919730232933F10000904072912344610331D90C\r\n+CMGL: 9,1,,22\r\n07919730071111F1040B919730232933F10000904072913384610331D90C\r\n+CMGL: 10,1,,22\r\n07919730071111F1040B919730232933F100009040729153126103B49A0D\r\n+CMGL: 11,1,,44\r\n07919730071111F1040B919730232933F10000904082904343611C31D98C56B3DD7039582C2693CD66345AAD66B3DD6E385C2E07\r\n+CMGL: 12,1,,31\r\n07919730071111F1040B919730232933F10008904082902443610C041F04400438043204350442\r\n+CMGL: 13,1,,160\r\n07919772009057F8400DD0CDF2396C7CBB010008904003618354618C050003C402010423002004120430044100200438043C0435044E04420441044F0020043F0440043E043F044304490435043D043D044B043500200432044B0437043E0432044B002E002004170432043E043D043A043E04320020043E04420020002B003700390031003900380033003000330034003500340020003A00200031002C0020043F043E0441043B\r\n+CMGL: 14,1,,100\r\n07919772009057F8440DD0CDF2396C7CBB0100089040036183546150050003C4020204350434043D04380439002004370432043E043D043E043A003A002000310036003A00330038002000330030005F00300034005F003200300030003900200028004D0053004B0029002E\r\n\r\nOK", out index, out message_status, out address_text);
            // ReadPDUOutboxSMS("AT+CMGL=3\r\n\r\n+CMGL: 0,3,,22\r\n07919772929090F011000B819830232933F10008FF080074006500730074\r\n+CMGL: 1,3,,152\r\n07919772929090F011010B819806539928F40008FF8A041C0435043304300444043E043D00200441043F0440043E0441043804420020043D043E043C002004420435043B04350444043E043D0430002E00200412043E04420020043D04300020044D0442043E043C0020043504410442044C00200418043D04350442002004380020043D04350442002000760070006E00310035002E0076006F006C00670061\r\n\r\nOK", out index, out message_status, out address_text);
            // �������� (��)������ ReadPDUInboxSMS("AT+CMGL=4\r\n\r\n+CMGL: 2,1,,160\r\n07919772009057F8400DD0CDF2396C7CBB010008809003715582008C050003B702010423002004120430044100200438043C0435044E04420441044F0020043F0440043E043F044304490435043D043D044B043500200432044B0437043E0432044B002E002004170432043E043D043A043E04320020043E04420020002B003700390031003900380033003000330034003500340020003A00200031002C0020043F043E0441043B\r\n\r\nOK", out index, out message_status, out address_text);
            //OK
            //
            dt = dt;
        }
        #region -------- �������������� --------
        public string IntToHex(int number, string cap)
        {
            return String.Format("{0:X"+cap+"}", number);
        }

        public int HexToInt(string hexString)
        {
            return int.Parse(hexString,
                System.Globalization.NumberStyles.HexNumber, null);
        }

        public string BinToHex(string sbin, string cap)
        {
            int res = 0;
            for (int i = 0; i < sbin.Length; i++)
            {
                int m= Convert.ToInt32(Math.Pow(2, sbin.Length - i-1));
                int cn = int.Parse(Convert.ToString(sbin[i]));
                res +=  cn*m;
            }
            return IntToHex(res, cap);
        }

        public string HexToBin(string shex, int cap)
        {
            string bin = string.Empty;
            shex = shex.ToUpper();
            string[] bin_array = new string[] {    "0",    "1",   "10",   "11",  "100",  "101",  "110",  "111",
                                                "1000", "1001", "1010", "1011", "1100", "1101", "1110", "1111" };
            for (int i = 0; i < shex.Length; i++)
            {
                string c_bin = bin_array[Convert.ToInt32(shex[shex.Length-i-1].ToString(), 16)];
                while (c_bin.Length < cap)
                {
                    c_bin = "0" + c_bin;
                }
                bin = c_bin + bin;
            }
            return bin;
        }
        #endregion

        #region -------- ������ � ������������ --------
        /// <summary>
        /// �������� ����� ������� �������� SMS �� ������ ����������
        /// </summary>
        /// <param name="SCTS"></param>
        /// <returns></returns>
        public DateTime GetSMSTime(string SCTS)
        {
            string s = SCTS;
            /*
            Code: 
            +-------------------------------------------------------+
            |   1       2       3       4       5       6       7   | 
            | 0   1   2   3   4   5   6   7   8   9   10  11 12  13 |
            +-------+-------+-------+-------+-------+-------+-------+ 
            |  ���  | ����� |  ���� |  ���  |  ���  |  ���  |��.����| 
            +-------+-------+-------+-------+-------+-------+-------+ 
            | 2 | 1 | 2 | 1 | 2 | 1 | 2 | 1 | 2 | 1 | 2 | 1 | 2 | 1 | 
            +-------+-------+-------+-------+-------+-------+-------+ 
            �������� ������ ������ ����: 
            +--+--+--+--+--+--+--+ 
            |79|50|12|31|54|33|00| 
            +--+--+--+--+--+--+--+              
            ���������������� ���: 
            21 ��� 97 ���� 13:45:33
             */
            int year = int.Parse(s[1].ToString() + s[0].ToString());
            int mon = int.Parse(s[3].ToString() + s[2].ToString());
            int day = int.Parse(s[5].ToString() + s[4].ToString());
            int hour = int.Parse(s[7].ToString() + s[6].ToString());
            int min = int.Parse(s[9].ToString() + s[8].ToString());
            int sec = int.Parse(s[11].ToString() + s[10].ToString());
            int utc = int.Parse(s[13].ToString() + s[12].ToString());
            DateTime dt = new DateTime(2000 + year, mon, day, hour, min, sec);
            return dt;
        }

        public string BCDFixNum(string number)
        {
            string res = string.Empty;
            if (number.Length % 2 > 0)
            {
                number += "F";
            }
            for (int i = 0; i < number.Length; i++)
            {
                res += number[i + 1].ToString() + number[i].ToString();
                i++;
            }
            return res;
        }

        public string BCDUnFixNum(string number)
        {
            string res = string.Empty;
            if (number.Length % 2 != 0)
            {
                throw new ArgumentException("PDU telephone nuber must be even");
            }
            for (int i = 0; i < number.Length; i++)
            {
                res += number[i + 1].ToString() + number[i].ToString();
                i++;
            }
            if (res[res.Length - 1].ToString() == "F")
            {
                res = res.Remove(res.Length - 1);
            }
            return res;
        }

        /// <summary>
        /// String to UCS2
        /// </summary>
        /// <param name="s">������ utf</param>
        /// <returns>0-����� ����, 1-������</returns>
        public string[] StringToUCS2(string s)
        {
            string res = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                int k = (char)s[i];
                res = res + IntToHex(k, "4");
            }
            return new string[] { string.Format("{0}", IntToHex(res.Length/2,"2")), res }; 
        }

        public string USC2toString(string ucs2_text)
        {
            byte[] res = new byte[ucs2_text.Length/2];
            if (ucs2_text.Length % 4 == 0)
            {
                for (int i = 0; i < ucs2_text.Length / 2; i++)
                {
                    res[i] = Convert.ToByte(ucs2_text.Substring(i * 2, 2), 16);
                }
                return Encoding.BigEndianUnicode.GetString(res);
            }
            else
            {
                throw new ArgumentException("����� ������� ������ �� ������ 4-�");
            }
        }

        /// <summary>
        /// Unicode 7bit hex to 8bit string (no russian character set)
        /// </summary>
        /// <param name="s">������ ���.</param>
        /// <returns>0-����� ����, 1-������</returns>
        public string PDU7bToString(string pdu_string)
        {
            string ret_bin = string.Empty;//���-������

            //� ����� �� � ���� �������?
            if (pdu_string.Length % 2 > 0)
            {
                throw new ArgumentException("������� ������ �������");
            }

            //������ �������� ������, ������������ � 8��� � �����
            for (int i = 0; i < pdu_string.Length; i++)
            {
                //������������ �����
                ret_bin = ret_bin+HexToBin(pdu_string.Substring(pdu_string.Length - i - 2, 2), 4) ;
                i++;
            }

            int ful_hex_it = 0;//�������� ������
            int bit_in_byte = 7;//���� � ����
            double endsb = (double)ret_bin.Length / bit_in_byte;
            double intendsb = Math.Truncate(endsb);
            if (endsb != intendsb)
            {
                ful_hex_it = (int)intendsb + 1;
            }
            else
            {
                ful_hex_it = (int)intendsb;
            }

            byte[] ret = new byte[ful_hex_it];//�������� ���������
            for (int hi = 0; hi < ful_hex_it; hi++)
            {
                //������+7 �� ������ ������ �����
                //����� ����� �� 7 ����� bit � ��������� � hex
                //�������� � �����, �� ����� �������

                //������� ��� ����������
                int est_back = bit_in_byte;

                //�������� ����� ��� ��������� ��������� �� 1-� ���
                int bst_back = bit_in_byte * (hi + 1);

                //���� ����� �� ������ ���-�� ��� � �����, 
                //�� � ����� ����� �� ������ ����
                //����� �������, ������� ��� ��������
                if (bst_back > ret_bin.Length)
                {
                    bst_back = 0;
                    est_back = ret_bin.Length - (hi * bit_in_byte);
                }
                else
                {
                    //����� ��������� �����
                    bst_back = ret_bin.Length - bst_back;
                }
                //2-������ ��� ����� ���� ������ � ������ ����� ������
                ret[hi] =Convert.ToByte(BinToHex(ret_bin.Substring(bst_back, est_back), "2"),16); 
            }

            string s = string.Empty;
            //������ � ��������� �������� 0x00, ��� �� ��������
            if (ret[ful_hex_it-1] == (byte)0x00)
            {
                byte[] retf = new byte[ful_hex_it - 1];
                for (int i = 0; i < retf.Length; i++)
                {
                    retf[i] = ret[i];
                }
                s = Encoding.ASCII.GetString(retf);
            }
            else
            {
                s = Encoding.ASCII.GetString(ret);
            }
            return s;
        }

        /// <summary>
        /// Unicode 8bit string to 7bit hex (no russian character set)
        /// </summary>
        /// <param name="s">������ ���.</param>
        /// <returns>0-����� ����, 1-������</returns>
        public string[] StringToPDU7b(string str)
        {
            string ret_bin = string.Empty;//���-������
            string ret = string.Empty;//���������

            //������ �������� ������, �������� ���-�����������������
            for (int i = 0; i < str.Length; i++)
            {
                int symbl_hex_code = (char)str[i];
                string bin_c = Convert.ToString(symbl_hex_code, 2);

                //���� ����� �������� - ���� �������� ���� ������ 7, �� ��������� �� ������
                if (bin_c.Length > 7)
                {
                    throw new ArgumentException("A non printable symbol contained in text.");
                }

                //� ���� ������, ��������� �� 7
                while (bin_c.Length < 7)
                {
                    bin_c = "0" + bin_c;
                }

                //� ���������� � ������ �����(!)
                ret_bin = bin_c + ret_bin;
            }

            //� ret_bin ������ �������� ������, ������� ���� ��������� � hex

            //���� ������� �� ������� ����, �� ��������� 1 �������� ��� ��� ����������
            int ful_hex_it = 0;
            int bit_in_byte = 8;
            double endsb = (double)ret_bin.Length / bit_in_byte;
            double intendsb = Math.Truncate(endsb);
            if (endsb != intendsb)
            {
                ful_hex_it = (int)intendsb + 1;
            }
            else
            {
                ful_hex_it = (int)intendsb;
            }

            for (int hi = 0; hi < ful_hex_it; hi++)
            {
                //������+8 �� ������ ������ �����
                //����� ����� �� 8 ����� bit � ��������� � hex
                //�������� � �����, �� ����� �������

                //������� ��� ����������
                int est_back = bit_in_byte;

                //�������� ����� ��� ��������� ��������� �� 1-� ���
                int bst_back = bit_in_byte * (hi + 1);

                //���� ����� �� ������ ���-�� ��� � �����, 
                //�� � ����� ����� �� ������ ����
                //����� �������, ������� ��� ��������
                if (bst_back > ret_bin.Length)
                {
                    bst_back = 0;
                    est_back = ret_bin.Length - (hi * bit_in_byte);
                }
                else
                {
                    //����� ��������� �����
                    bst_back = ret_bin.Length - bst_back;
                }
                //2-������ ��� ����� ���� ������ � ������ ����� ������
                ret += BinToHex(ret_bin.Substring(bst_back, est_back), "2");
            }

            //������ (��. �����) � ��������� �������� 0x00, ��� �� ��������??

            return new string[] { string.Format("{0}", IntToHex(str.Length, "2")), ret };
        }

        #endregion

        RPDUSMS[] ReadPDUInboxSMS(string pdu, out int[] index, out int[] message_status, out string[] address_text)
        {
            //RPDUSMS pdusms = new RPDUSMS();
            /*
            +CMGL: 11,0,,44
            07919730071111F1040B919730232933F10000904082904343611C31D98C56B3DD7039582C2693CD66345AAD66B3DD6E385C2E07
            OK
             */
            string pat1 = @"\+CMGL:\s(?<index>[0-9]+),(?<message_status>[0-9]+),(?<address_text>[0-9A-Za-z\-]*),(?<TPDU_length>[0-9]+)(\r\n)(?<SMSC_number_and_TPDU>[0-9A-F]+)[\r\n]";
            Regex reg1 = new Regex(pat1, RegexOptions.IgnoreCase);
            //string s = ReadFromPort();
            //Match m = reg1.Match(pdu);
            MatchCollection m = reg1.Matches(pdu);
            RPDUSMS[] pdusms = new RPDUSMS[m.Count];
            index = new int[m.Count];
            message_status = new int[m.Count];
            address_text = new string[m.Count];

            for (int i = 0; i < m.Count; i++)
            {
                //ret[i] = m[i].Groups["addr"].Value;
                index[i] = int.Parse(m[i].Groups["index"].Value);
                message_status[i] = int.Parse(m[i].Groups["message_status"].Value);
                address_text[i] = m[i].Groups["address_text"].Value;

                string stpdu = m[i].Groups["SMSC_number_and_TPDU"].Value;

                int cursor = 0;
                pdusms[i].SMSC_num_len = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor = 2;
                if (pdusms[i].SMSC_num_len != 0x00)
                {
                    pdusms[i].SMSC_type_of_num = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                    cursor += 2;
                    int chread = ((int)pdusms[i].SMSC_num_len * 2) - 2;//2-����� SMSC_num_len
                    pdusms[i].SMSC_num = BCDUnFixNum(stpdu.Substring(cursor, chread));
                    cursor += chread;
                }
                else
                {
                    pdusms[i].SMSC_type_of_num = 0x00;
                    pdusms[i].SMSC_num = string.Empty;
                }
                pdusms[i].TPDU = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].OA_ref_num_len = Convert.ToByte(stpdu.Substring(cursor, 2), 16);//TODO �� �����, ��� ������, �� �������, ��� �� 0x00
                cursor += 2;

                pdusms[i].OA_type_of_num = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                int OA_num_len = (int)pdusms[i].OA_ref_num_len;
                if (OA_num_len % 2 > 0)
                {
                    OA_num_len++;
                }

                pdusms[i].OA_num = BCDUnFixNum(stpdu.Substring(cursor, OA_num_len));
                cursor += OA_num_len;

                pdusms[i].PID = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].DCS = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].SCTS = GetSMSTime(stpdu.Substring(cursor, 14));
                cursor += 14;

                pdusms[i].UDL = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                switch (pdusms[i].DCS)
                {
                    case (byte)DEncProtocol.SbitDefault:
                        {
                            pdusms[i].UD = PDU7bToString(stpdu.Substring(cursor));
                        }
                        break;
                    case (byte)DEncProtocol.UTF7:
                        {
                            pdusms[i].UD = USC2toString(stpdu.Substring(cursor));
                        }
                        break;
                    default:
                        {
                            pdusms[i].UD = PDU7bToString(stpdu.Substring(cursor));
                        }
                        break;
                }
            }


            #region why
            /*
            +CMGL: index,message_status,[address_text],TPDU_length<CR><LF>SMSC_number_and_TPDU[<CR><LF>+CMGL: ...]

            Before we discuss each of the fields that appear in the +CMGL information response, let's see an example
            that gives you some idea of how an actual +CMGL information response should look like:

            +CMGL: 1,0,,62
            07915892000000F0040B915892214365F700007040213252242331493A283D0795C3F33C88FE06C9CB6132885EC6D341EDF27C1E3E97E7207B3A0C0A5241E377BB1D7693E72E

            The index Field
            The first field of the information response of the +CMGL AT command, index, is an integer that specifies
            the location of the SMS message in the message storage area.

            The message_status Field
            The second field of the information response of the +CMGL AT command, message_status,
            is an integer that indicates the status of the SMS message. It can be one of the following four values:
            0. It refers to the message status "received unread".
            1. It refers to the message status "received read".
            2. It refers to the message status "stored unsent".
            3. It refers to the message status "stored sent".

            The address_text Field
            The third field of the information response of the +CMGL AT command, address_text, is a string that
            contains the text associated to address in the phonebook, where address is the phone number encoded in the
            TPDU of the SMSC_number_and_TPDU field. For example, if the phone number encoded in the TPDU is "91234567"
            and the text "Alice" is associated to the phone number "91234567" in the phonebook, address_text will be
            "Alice". The AT command +CSCS (command name in text: Select TE Character Set) can be used to specify the
            character set for displaying address_text.

            Note that address_text is an optional field. Some GSM/GPRS modems and mobile phones leave this field empty.
            (Examples: Philips 598 supports this field, while most Nokia products, including my Nokia 6021, and 
            Sony Ericsson T68i does not.)

            The TPDU_length Field
            The fourth field of the information response of the +CMGL AT command, TPDU_length, is an integer that
            indicates the length (in octets. 1 octet = 8 bits) of the TPDU contained in the SMSC_number_and_TPDU field.
            In the earlier example command line, the value of the SMSC_number_and_TPDU field is:

            07915892000000F0040B915892214365F700007040213252242331493A283D0795C3F33C88FE06C9CB6132885EC6D341EDF27C1E3E97E7207B3A0C0A5241E377BB1D7693E72E

            It can be divided into two parts. The following part is the TPDU:

                            040B915892214365F700007040213252242331493A283D0795C3F33C88FE06C9CB6132885EC6D341EDF27C1E3E97E7207B3A0C0A5241E377BB1D7693E72E

            The TPDU is coded in hexadecimal format. Each character represents 4 bits, i.e. 1/2 octet.
            The TPDU has 124 characters and so there are totally 62 octets. That's why the value of the
            TPDU_length field is 62.

            The SMSC_number_and_TPDU Field
            The fifth field of the information response of the +CMGL AT command, SMSC_number_and_TPDU, specifies
            the SMSC number and the TPDU (Transfer Protocol Data Unit) in hexadecimal format.

            If the SMS message to be read is an incoming SMS message, the value of the SMSC_number_and_TPDU field
            will be something like this:

            07915892000000F0040B915892214365F700007040213252242331493A283D0795C3F33C88FE06C9CB6132885EC6D341EDF27C1E3E97E7207B3A0C0A5241E377BB1D7693E72E

            The TPDU embedded in the above hexadecimal sequence is of the type SMS-DELIVER. Here is some of the
            information encoded in the hexadecimal sequence:
            SMSC number from which the SMS message was received: +85290000000
            Sender phone number: +85291234567
            Time and date at which the SMSC received the SMS message: 12 April 2007, 23:25:42 GMT+8 hours
            Text message: "It is easy to read text messages via AT commands."
            For the details about how the hexadecimal sequence of an incoming SMS message is coded, 
            please refer to the section titled "Some Explanation about the Decoding of the SMSC_number_and_TPDU Field
            Value of the +CMGR AT Command" of this SMS tutorial.

            If the SMS message to be read is an outgoing SMS message, the value of the SMSC_number_and_TPDU
            field will be something like this:

            07915892000000F001000B915892214365F7000021493A283D0795C3F33C88FE06CDCB6E32885EC6D341EDF27C1E3E97E72E

            The TPDU embedded in the above hexadecimal sequence is of the type SMS-SUBMIT.
            Its format is different from that of an SMS-DELIVER TPDU. Below shows some of the information
            encoded in the hexadecimal sequence above:
            SMSC number to be used if the SMS message is sent out: +85290000000
            Destination phone number: +85291234567
            Text message: "It is easy to send text messages."
            For the details about how the hexadecimal sequence of an outgoing SMS message is coded, 
            please refer to the section titled "Some Explanation about the Coding of the 
            SMSC_number_and_TPDU Parameter Value of the +CMGS AT Command" of this SMS tutorial.
            */
            #endregion

            return pdusms;
        }

        SPDUSMS[] ReadPDUOutboxSMS(string pdu, out int[] index, out int[] message_status, out string[] address_text)
        {
            //RPDUSMS pdusms = new RPDUSMS();
            /*
            +CMGL: 0,3,,22
            07919772929090F011000B819830232933F10008FF080074006500730074
            OK
             */
            //07 919772929090F0 11 00 0B 81 9830232933F1 00 08 FF 08 0074006500730074
            string pat1 = @"\+CMGL:\s(?<index>[0-9]+),(?<message_status>[0-9]+),(?<address_text>[0-9A-Za-z\-]*),(?<TPDU_length>[0-9]+)(\r\n)(?<SMSC_number_and_TPDU>[0-9A-F]+)[\r\n]";
            Regex reg1 = new Regex(pat1, RegexOptions.IgnoreCase);

            MatchCollection m = reg1.Matches(pdu);
            SPDUSMS[] pdusms = new SPDUSMS[m.Count];
            index = new int[m.Count];
            message_status = new int[m.Count];
            address_text = new string[m.Count];

            for (int i = 0; i < m.Count; i++)
            {
                //ret[i] = m[i].Groups["addr"].Value;
                index[i] = int.Parse(m[i].Groups["index"].Value);
                message_status[i] = int.Parse(m[i].Groups["message_status"].Value);
                address_text[i] = m[i].Groups["address_text"].Value;

                string stpdu = m[i].Groups["SMSC_number_and_TPDU"].Value;

                int cursor = 0;
                pdusms[i].SMSC_num_len = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor = 2;
                if (pdusms[i].SMSC_num_len != 0x00)
                {
                    pdusms[i].SMSC_type_of_num = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                    cursor += 2;
                    int chread = ((int)pdusms[i].SMSC_num_len * 2) - 2;//2-����� SMSC_num_len
                    pdusms[i].SMSC_num = BCDUnFixNum(stpdu.Substring(cursor, chread));
                    cursor += chread;
                }
                else
                {
                    pdusms[i].SMSC_type_of_num = 0x00;
                    pdusms[i].SMSC_num = string.Empty;
                }
                pdusms[i].TPDU = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].MR = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].DA_ref_len = Convert.ToByte(stpdu.Substring(cursor, 2), 16);//TODO �� �����, ��� ������, �� �������, ��� �� 0x00
                cursor += 2;

                pdusms[i].DA_type_of_num = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                int DA_num_len = (int)pdusms[i].DA_ref_len;
                if (DA_num_len % 2 > 0)
                {
                    DA_num_len++;
                }

                pdusms[i].DA_num = BCDUnFixNum(stpdu.Substring(cursor, DA_num_len));
                cursor += DA_num_len;

                pdusms[i].PID = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].DCS = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].VP = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                pdusms[i].UDL = Convert.ToByte(stpdu.Substring(cursor, 2), 16);
                cursor += 2;

                switch (pdusms[i].DCS)
                {
                    case (byte)DEncProtocol.SbitDefault:
                        {
                            pdusms[i].UD = PDU7bToString(stpdu.Substring(cursor));
                        }
                        break;
                    case (byte)DEncProtocol.UTF7:
                        {
                            pdusms[i].UD = USC2toString(stpdu.Substring(cursor));
                        }
                        break;
                    default:
                        {
                            pdusms[i].UD = PDU7bToString(stpdu.Substring(cursor));
                        }
                        break;
                }
            }


            return pdusms;
        }

        /// <summary>
        /// ��������� ������ � �������� SMS
        /// </summary>
        /// <param name="smsc_num"></param>
        /// <param name="tsmsc_num"></param>
        /// <param name="da_num"></param>
        /// <param name="tda_num"></param>
        /// <param name="ep"></param>
        /// <param name="TimeLife"></param>
        /// <param name="text"></param>
        /// <param name="pdu_len">����� PDU, �������� ���� SCA</param>
        /// <returns></returns>
        string GetPDUSendStr(string smsc_num, TypeOfNumber tsmsc_num, string da_num, TypeOfNumber tda_num, DEncProtocol ep, string text, out int pdu_len)
        {
            int len_sca=1;
            SPDUSMS spdusms = new SPDUSMS();
            string res = string.Empty;
            if (smsc_num.Length == 0)
            {
                spdusms.SMSC_num_len = 0x00;
                spdusms.SMSC_type_of_num = 0x00;
                spdusms.SMSC_num = string.Empty;
                res+="00";
            }
            else
            {
                spdusms.SMSC_type_of_num = (byte)tsmsc_num;
                spdusms.SMSC_num = BCDFixNum(smsc_num);
                len_sca+=1 + (spdusms.SMSC_num.Length / 2);
                spdusms.SMSC_num_len = (byte)(len_sca-1);
                res += string.Format("{0:X2}", spdusms.SMSC_num_len) + string.Format("{0:X2}", spdusms.SMSC_type_of_num) + spdusms.SMSC_num; 
            }

            spdusms.TPDU = 0x31;//����� � ��������, ��.����� ����� 1 ����
            res += string.Format("{0:X2}", spdusms.TPDU);

            spdusms.MR = 0x00;
            res += string.Format("{0:X2}", spdusms.MR);

            spdusms.DA_ref_len = (byte)da_num.Length;
            res += string.Format("{0:X2}", spdusms.DA_ref_len);

            spdusms.DA_type_of_num = (byte)tda_num;
            res += string.Format("{0:X2}", spdusms.DA_type_of_num);

            spdusms.DA_num = BCDFixNum(da_num);
            res += spdusms.DA_num;

            spdusms.PID = 0x00;
            res += string.Format("{0:X2}", spdusms.PID);

            spdusms.DCS = (byte)ep;
            res += string.Format("{0:X2}", spdusms.DCS);

            spdusms.VP = 0xAA;
            res += string.Format("{0:X2}", spdusms.VP);

            string[] rt = new string[2];
            switch (ep)
            {
                case DEncProtocol.SbitDefault:
                    { 
                        rt=StringToPDU7b(text);
                        spdusms.UDL = Convert.ToByte(rt[0], 16);
                        spdusms.UD  = rt[1];
                    }
                    break;
                case DEncProtocol.UTF7:
                    {
                        rt = StringToUCS2(text);
                        spdusms.UDL = Convert.ToByte(rt[0], 16);
                        spdusms.UD = rt[1];
                    }
                    break;
                default:
                    break;
            }

            res += rt[0] + rt[1];

            pdu_len = (res.Length/2) - len_sca;
            return res;
        }
    }
}