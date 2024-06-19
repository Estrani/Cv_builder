using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublipostageDemo.Helper
{
    public class MsDocumentHelper
    {
        Hashtable myHashtable;
        public void Close(string status)
        {
            try
            {
                Process[] AllProcessesExcel = Process.GetProcessesByName("excel");
                Process[] AllProcessesWord = Process.GetProcessesByName("WINWORD");
                List<Process> AllProcesses = AllProcessesExcel.Concat(AllProcessesWord).ToList();

                if (myHashtable == null)
                    myHashtable = new Hashtable();

                foreach (Process ExcelProcess in AllProcesses)
                {
                    if (!myHashtable.ContainsKey(ExcelProcess.Id))
                    {
                        myHashtable.Add(ExcelProcess.Id, status);
                    }
                }


                if (status != "Loading")
                {
                    foreach (Process ExcelProcess in AllProcesses)
                    {
                        if (myHashtable.ContainsKey(ExcelProcess.Id) && (string)myHashtable[ExcelProcess.Id] == status && ExcelProcess.MainWindowHandle == IntPtr.Zero)
                            ExcelProcess.Kill();
                    }
                }
                AllProcesses = null;
            }
            catch (Exception)
            {

            }
        }
    }
}
