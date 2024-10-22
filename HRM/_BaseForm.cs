using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM
{
    public class _BaseForm : DevExpress.XtraEditors.XtraForm
    {
        

        public string _CFG_UPLOAD_FOLDER
        {
            get
            {
                return System.Configuration.ConfigurationSettings.AppSettings["UploadFolder"];
            }
        }
    }
}
