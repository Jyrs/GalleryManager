using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Data.Entity;

namespace SQLiteApp
{
    public class Picture : INotifyPropertyChanged
    {


            private int id;
            private int galleryid;
            private string path;
            private string name;

            public int Id { get; set; }

            public string Path
            {
                get { return path; }
                set
                {
                    path = value;
                    OnPropertyChanged("Path");
                }
            }
            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                    OnPropertyChanged("name");
                }
            }

            public int GalleryID
            {
                get { return galleryid; }
                set
                {
                    galleryid = value;
                    OnPropertyChanged("galleryid");
                }
            }



            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName]string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
    }
}
