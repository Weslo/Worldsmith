using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worldsmith.GameLogic.DataModels
{
    class MainFormDataModel : IDataModel
    {
        private string filepath = "";
        public string Filepath
        {
            get { return this.filepath; }
            set
            {
                if (this.filepath == value) return;

                this.filepath = value;
                OnPropertyChanged("Filepath");
            }
        }
    }
}
