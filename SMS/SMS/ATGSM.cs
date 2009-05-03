using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SMS
{
    public class ATGSM
    {

        public delegate void OnReadBuffer(string buffer);
        public event OnReadBuffer ReadBuffer;

        System.IO.Ports.SerialPort port = new System.IO.Ports.SerialPort();
        public ATGSM(string PortName)
        {
            //далее необходимо настроить порт для работы с мобильным телефоном
            port.PortName = PortName;

            //Время ожидания записи и чтения с порта
            port.WriteTimeout = 5000;
            port.ReadTimeout = 5000;

            //Настраиваем скорость обмена данными с телефоном - телефон не может обрабатывать данный на максимальной скорости
            port.BaudRate = 9600;

            //Другие необходимые настройки - подходит для большинства телефонов - но возможно придется настраивать:
            port.BaudRate = 9600;
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;
            port.Handshake = Handshake.RequestToSend;
            port.DtrEnable = true;
            port.RtsEnable = true;
            port.NewLine = System.Environment.NewLine;
            OpenPort();
            System.Threading.Thread.Sleep(500);
        }

        /// <summary>
        /// Открыть порт
        /// </summary>
        /// <returns></returns>
        public bool OpenPort()
        {
            bool res = false;
            try
            {
                if (!port.IsOpen)
                {
                    //открываем порт
                    port.Open();
                    ATZ();
                    res = true;
                }
                else
                {
                    res = false;
                    throw new ArgumentException("Порт уже открыт");
                }
            }
            catch (IOException ex)
            {
                if (MessageBox.Show(ex.Message, "Порт " + port.PortName + " не существует", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    OpenPort();
                }
                else
                {
                    res = false;
                    throw new ArgumentException("ERROR: " + ex.Message);
                }
            }
            return res;
        }

        /// <summary>
        /// Закрыть порт
        /// </summary>
        /// <returns></returns>
        public bool ClosePort()
        {
            bool ret = false;
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                    ret = true;
                }
                else
                {
                    ret = false;
                    throw new ArgumentException("Порт не открыт");
                }
            }
            catch (InvalidOperationException)
            {
                ret = false;
            }
            return ret;
        }

        #region -------- Основные ---------
        /// <summary>
        /// Эта команда восстанавливает исходное состояние модема
        /// в соответствии с параметрами,
        /// хранящимися в энергонезависимой памяти.
        /// </summary>
        /// <returns></returns>
        public string ATZ()
        {
            port.Write("ATZ\r\n");
            return ReadFromPort();
        }

        public string AT()
        {
            port.Write("AT\r\n");
            return ReadFromPort();
        }

        /// <summary>
        /// Выполнить AT команду
        /// </summary>
        /// <param name="cmd">команда</param>
        /// <returns>буфер</returns>
        public string RunAT(string cmd, string delt)
        {
            port.Write(cmd + delt);
            return ReadFromPort();
        }

        /// <summary>
        /// Установить текстовый режим
        /// </summary>
        /// <returns></returns>
        public string SetTextMode()
        {
            port.Write("AT+CMGF=1\r\n");//текстовый режим
            return ReadFromPort();
        }

        #endregion

        #region -------- Кодировки --------
        /// <summary>
        /// Наборы символов
        /// </summary>
        /// <returns></returns>
        public string[] GetArraySupEnc()
        {
            port.Write("AT+CSCS=?\r\n");//текстовый режим
            //AT+CSCS=?\r\r\n+CSCS: (\"IRA\",\"GSM\",\"UCS2\")\r\n\r\nOK\r\n
            string pat1 = @"CSCS:\s\((?<addr>[(),.\""A-za-z0-9\-]+)\)[\r\n]";
            Regex reg1 = new Regex(pat1, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            Match match1 = reg1.Match(ReadFromPort());

            string s = match1.Groups["addr"].Value;

            string pat2 = @"\""(?<addr>[(),.A-za-z0-9\-]+)\""";
            Regex reg2 = new Regex(pat2, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MatchCollection matches = reg2.Matches(s);
            string[] ret = new string[matches.Count];

            for (int i = 0; i < matches.Count; i++)
            {
                ret[i] = matches[i].Groups["addr"].Value;
            }
            return ret;
        }

        /// <summary>
        /// Текущий набор символов
        /// </summary>
        /// <returns></returns>
        public string GetCurrentEnc()
        {
            port.Write("AT+CSCS?\r\n");//текстовый режим
            //AT+CSCS?\r\r\n+CSCS: \"IRA\"\r\n\r\nOK\r\n
            string pat1 = @"CSCS:\s\""(?<addr>[(),.A-za-z0-9\-]+)\""[\r\n]";
            Regex reg1 = new Regex(pat1, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            //string s = ReadFromPort();
            Match match1 = reg1.Match(ReadFromPort());
            return match1.Groups["addr"].Value;
        }

        /// <summary>
        /// Установить набор символов
        /// </summary>
        /// <param name="enc"></param>
        /// <returns></returns>
        public string SetEnc(string enc)
        {
            port.Write("AT+CMGF=1\r\n");//текстовый режим
            port.Write("AT+CSCS=\"" + enc + "\"");//установить набор
            string s = ReadFromPort();
            return s;
        }
        #endregion

        #region -------- Разное системное --------
        /// <summary>
        /// Получить уровень сигнала
        /// </summary>
        /// <returns>Уровень сигнала в db</returns>
        public double GetSignalLevel()
        {
            port.Write("AT+CSQ\r\n");//уровень сигнала
            //ответ обычно такой:  AT+CSQ\r\r\n+CSQ: 23,99\r\n\r\nOK\r\n
            string pat1 = @"CSQ:\s(?<addr>[0-9]+)\,[0-9]";
            Regex reg1 = new Regex(pat1, RegexOptions.IgnoreCase);
            string buffer = ReadFromPort();
            double level = 0.0;
            if (!buffer.Contains("ERROR"))
            {
                Match match1 = reg1.Match(buffer);
                string val = match1.Groups["addr"].Value;
                level = (Math.Truncate(Convert.ToDouble(val)) * 2) - 113;
            }
            else
            {
                level = 0;
                throw new ArgumentException("ERROR: " + buffer);
            }
            return level;
        }
        #endregion

        #region -------- Отправка SMS --------

        public string SendSMS(string phone, int icode, string mess)
        {
            string message = string.Empty;
            port.Write("AT+CMGF=1\r\n");//текстовый режим
            System.Threading.Thread.Sleep(500);
            port.Write("AT+CMGS=\""+phone+"\","+icode+"\r");//подготавливаем смс
            if (WaitBeforeContains(">", out message))
            {
                port.Write(mess + (char)(26));//текст смс и отправка
            }
            string answ = ReadFromPort();
            //ответ такой:    \r\nTest\r\n+CMGS: 6\r\n\r\nOK\r\n

            return answ;
        }

        public string SendPDUSMS()
        {
            string message = string.Empty;
            port.Write("AT+CMGF=0\r\n");//текстовый режим выкл
            System.Threading.Thread.Sleep(500);
            port.Write("AT+CMGS=22\r");//подготавливаем смс
            if (WaitBeforeContains(">", out message))
            {
                port.Write("0031000B919730232933F10008AA080422043504410442" + (char)(26));//текст смс и отправка
            }
            string answ = ReadFromPort();
            //ответ такой:    \r\nTest\r\n+CMGS: 6\r\n\r\nOK\r\n

            return answ;
        }

        #endregion

        #region -------- Получение SMS --------
        
        /// <summary>
        /// Чтение конкретной SMS в текстовом виде
        /// </summary>
        /// <returns></returns>
        public string ReadSMSText()
        {
            string message = string.Empty;
            port.Write("AT+CMGF=1\r\n");//текстовый режим
            port.Write("AT+CMGR=1\r\n");//читаем
            System.Threading.Thread.Sleep(500);
            if (WaitBeforeContains("OK", out message))
            {
            }
            //для никса писал код. аналогично
            return message;
        }

        #endregion

        #region -------- Вспомогательные --------
        /// <summary>
        /// Сбор данных из буфера, пока не встретится последовательность
        /// </summary>
        /// <param name="contains">Последовательность</param>
        /// <param name="reply">Ответ</param>
        /// <returns>Успех/Отказ</returns>
        bool WaitBeforeContains(string contains, out string reply)
        {
            DateTime timeout = DateTime.Now.AddSeconds(4);
            string buffer = "";
            do
            {
                buffer += port.ReadExisting();
                if (DateTime.Now > timeout || buffer.Contains("ERROR\r\n"))
                {
                    reply = buffer;
                    return false;
                }
            } while (!buffer.Contains(contains));
            reply = buffer;

            if (ReadBuffer != null)
            {
                ReadBuffer.Invoke(buffer);
            }
            return true;
        }

        /// <summary>
        /// Обертка над WaitBeforeContains
        /// </summary>
        /// <returns>Присланное сообщение</returns>
        public string ReadFromPort()
        {
            string message = string.Empty;
            WaitBeforeContains("OK", out message);
            return message;
        }

        /// <summary>
        /// Когда данные приходят в UCS2, то телефонный номер надо расшифровать таким образом
        /// </summary>
        /// <param name="number">номер в UCS2</param>
        /// <returns></returns>
        public string GetNumberFromBEU(string number)
        {
            int len = number.Length;
            if (len % 2 > 0)
            {
                throw new ArgumentException("Длина строки не кратна 2-м");
            }
            else
            {
                int len_num = (int)Math.Truncate(Convert.ToDouble( len / 2));
                byte[] numb = new byte[len_num];
                for (int i = 0; i < len_num; i++)
                {
                    string nextb = number.Substring(i * 2, 2);
                    numb[i] = Convert.ToByte(nextb, 16);
                }
                return Encoding.BigEndianUnicode.GetString(numb);
            }
        }

        /// <summary>
        /// Конвертирование даты SMS
        /// </summary>
        /// <param name="time">Дата SMS в текстовом виде 09/04/28,09:42:34+16</param>
        /// <returns>Дата</returns>
        public DateTime GetTimeFromText(string time)
        {
            string pat1 = @"(?<year>[0-9]+)\/(?<mon>[0-9]+)\/(?<day>[0-9]+),(?<hr>[0-9]+):(?<min>[0-9]+):(?<sec>[0-9]+)\+(?<shift>[0-9]+)";
            Regex reg1 = new Regex(pat1, RegexOptions.IgnoreCase);
            //string buffer = "09/04/28,09:42:34+16";//ReadFromPort();

            Match m = reg1.Match(time);
            int year = int.Parse(m.Groups["year"].Value)+2000;
            int mon = int.Parse(m.Groups["mon"].Value);
            int day = int.Parse(m.Groups["day"].Value);
            int hr = int.Parse(m.Groups["hr"].Value);
            int min = int.Parse(m.Groups["min"].Value);
            int sec = int.Parse(m.Groups["sec"].Value);
            int shift = int.Parse(m.Groups["shift"].Value);

            DateTime dt = new DateTime(year,mon,day,hr,min,sec);
            return dt;
        }
        
        #endregion
    }
}
