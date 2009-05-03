using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace AppSMS.Components.DB
{
    public class WrXML
    {
        string program_path;
        const string DB_file_Objects = "Objects.xml";
        DataTable dt_obj;

        public WrXML()
        {
            program_path = AppDomain.CurrentDomain.BaseDirectory;
        }

        public DataTable GetObjectShema()
        {
            if (dt_obj != null) { dt_obj.Clear(); }
            dt_obj = new DataTable("Objetcs");

            //Основные св-ва
            DataColumn IdObj = new DataColumn("IdObj", Type.GetType("System.Int32"));
            IdObj.AutoIncrement = true;
            IdObj.AutoIncrementSeed = 1;
            IdObj.AutoIncrementStep = 1;
            IdObj.AllowDBNull = false;
            DataColumn NameObj = new DataColumn("NameObj", Type.GetType("System.String"), "'Новый объект (' + IdObj + ')'");
            DataColumn StateObj = new DataColumn("StateObj", Type.GetType("System.String"));
            DataColumn GroupObj = new DataColumn("GroupObj", Type.GetType("System.String"));

            //Связь
            DataColumn NumTelObj = new DataColumn("NumTelObj", Type.GetType("System.String"));
            DataColumn SMSCObj = new DataColumn("SMSCObj", Type.GetType("System.String"));
            SMSCObj.Caption = "Номер SMS центра";
            DataColumn MsgFormatObj = new DataColumn("MsgFormatObj", Type.GetType("System.Int32"));//0: Plain text; 1: PDU
            MsgFormatObj.DefaultValue = 0;
            DataColumn LinkPwdObj = new DataColumn("LinkPwdObj", Type.GetType("System.String"));

            //Настройки отправки и приема
            DataColumn TrySendObj = new DataColumn("TrySendObj", Type.GetType("System.Int32"));
            DataColumn IsWaitSendObj = new DataColumn("IsWaitSendObj", Type.GetType("System.Int32"));//0: немедленно; 1:отложенно -- флаг отложенной отправки
            IsWaitSendObj.DefaultValue = 0;
            DataColumn WaitSendObj = new DataColumn("WaitSendObj", Type.GetType("System.Int32"));//секунды
            WaitSendObj.DefaultValue = 0;
            DataColumn IsWaitRecvObj = new DataColumn("IsWaitRecvObj", Type.GetType("System.Int32"));//0: немедленно; 1:отложенно -- флаг отложенной обработки
            IsWaitRecvObj.DefaultValue = 0;
            DataColumn WaitRecvObj = new DataColumn("WaitRecvObj", Type.GetType("System.Int32"));//секунды
            WaitRecvObj.DefaultValue = 0;

            dt_obj.Columns.AddRange(new DataColumn[] { 
                IdObj, NameObj, StateObj, GroupObj, 
                NumTelObj, SMSCObj, MsgFormatObj, LinkPwdObj, 
                TrySendObj, IsWaitSendObj, WaitSendObj, IsWaitRecvObj, WaitRecvObj
            });

            object[] Objetcs = new object[13];
            Objetcs[0] = "1";
            Objetcs[1] = "Название номер раз";
            Objetcs[2] = "Выполнена команда Х";
            Objetcs[3] = "Октябрьский р-н";
            
            Objetcs[4] = "+79206909090";
            Objetcs[5] = "+79270510984";
            Objetcs[6] = 0;
            Objetcs[7] = "12345678";
            
            Objetcs[8] = 2;
            Objetcs[9] = 0;
            Objetcs[10] = 0;
            Objetcs[11] = 0;
            Objetcs[12] = 0;


            dt_obj.Rows.Add(Objetcs);
            return dt_obj;
        }

        public DataTable GetObjectData()
        {
            if (dt_obj != null)  { dt_obj.Clear(); }
            dt_obj = new DataTable("Objetcs");
            string OjectsFile = Path.Combine(program_path, DB_file_Objects);
            if (File.Exists(OjectsFile))
            {
                dt_obj.ReadXml(OjectsFile);
                return dt_obj;
            }
            else
            {
                return GetObjectShema();
            }            
        }

        public void SaveObjectData()
        {
            dt_obj.WriteXml(Path.Combine(program_path, DB_file_Objects), XmlWriteMode.WriteSchema);
        }

    }
}
