using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APM_WorkingWithFiles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_fileStreamRead_Click(object sender, EventArgs e)
        {
            //prepare path to file
           string fullPath = ApplicationPath.PathTo("Files/MyFile.txt");
            
            //preparing for read in async manner
            FileStream fs = new FileStream(fullPath, FileMode.Open);
            byte[] array = new byte[fs.Length];


            var c = SynchronizationContext.Current;

            //we do operation in async manner so right here we will not get result..
          IAsyncResult asyncResult = fs.BeginRead(array, 0, array.Length,(t)=>
          {
              byte[] arrayData = t.AsyncState as byte[];

              //emulate long reading..
              Thread.Sleep(1200);
              c.Post(p =>
              {
                  rctxbx_data.Text = Encoding.UTF8.GetString(arrayData);
              }
              ,null);
              fs.Close();
          },array);

            //here we always will wait async for operation to complete
            fs.EndRead(asyncResult);
            //so,you can put here any code you want..
            //here also....
            this.Text = "File reading started before this message";
           

        }

        
    }
}
