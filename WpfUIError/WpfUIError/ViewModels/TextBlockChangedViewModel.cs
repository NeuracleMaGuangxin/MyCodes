using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Threading;

namespace WpfUIError.ViewModels
{
    public class ListVIewModel : PropertyChangedBase
    {

        private string timeText;

        public string TimeText
        {
            get { return timeText; }
            set
            {
                timeText = value;
                NotifyOfPropertyChange(() => TimeText);
            }
        }

        private ImageSource _videoImage;

        public ImageSource VideoImage
        {
            get { return _videoImage; }
            set
            {
                _videoImage = value;
                NotifyOfPropertyChange(() => VideoImage);
            }
        }


    }
    public class TextBlockChangedViewModel : Caliburn.Micro.Screen
    {
        private Dispatcher _dispatcher;

        public TextBlockChangedViewModel()
        {
            _dispatcher = Dispatcher.CurrentDispatcher;
            //IniStart();
            Start();
        }

        private ObservableCollection<ListVIewModel> listViewSource;

        public ObservableCollection<ListVIewModel> ListViewSource
        {
            get { return listViewSource; }
            set
            {
                listViewSource = value;
                NotifyOfPropertyChange(() => ListViewSource);
            }
        }

        private string timeText;

        public string TimeText
        {
            get { return timeText; }
            set
            {
                timeText = value;
                NotifyOfPropertyChange(() => TimeText);
            }
        }

        private string timeText1;

        public string TimeText1
        {
            get { return timeText1; }
            set
            {
                timeText1 = value;
                NotifyOfPropertyChange(() => TimeText1);
            }
        }

        private ImageSource _videoImage;

        public ImageSource VideoImage
        {
            get { return _videoImage; }
            set
            {
                _videoImage = value;
                NotifyOfPropertyChange(() => VideoImage);
            }
        }

        private ImageSource _videoImage1;

        public ImageSource VideoImage1
        {
            get { return _videoImage1; }
            set
            {
                _videoImage1 = value;
                NotifyOfPropertyChange(() => VideoImage1);
            }
        }


        private int listcount = 1;

        public int Listcount
        {
            get { return listcount; }
            set
            {
                listcount = value;
                NotifyOfPropertyChange(() => Listcount);
            }
        }


        public bool IsStop = false;

        //public void IniStart()
        //{
        //    ListViewSource = new ObservableCollection<ListVIewModel>();
        //    for (int i = 0; i < Listcount; i++)
        //    {
        //        ListVIewModel listVIewModel = new ListVIewModel();
        //        ListViewSource.Add(listVIewModel);
        //    }
        //}
        private BitmapImage Bitmap2 = new BitmapImage();
        private BitmapImage Bitmap1 = new BitmapImage();
        public void Start()
        {

            IsStop = false;
            string absolutePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images\狂风绝息斩.jpg");
            Uri aa = new Uri("pack://application:,,,/Images/狂风绝息斩.jpg");
            string path = aa.AbsolutePath;
            //Bitmap2.BeginInit();
            Bitmap2 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/Images/蜡笔小新.jpg"));
            Bitmap1 = new System.Windows.Media.Imaging.BitmapImage(new Uri("pack://application:,,,/Images/狂风绝息斩.jpg"));
            //Bitmap1.BeginInit();
            //Bitmap1.UriSource = new Uri("Iamges/狂风绝息斩.jpg", UriKind.Relative);
            //Bitmap1.EndInit();
            int count = 1;
            Task.Run(() =>
            {
                bool showOne = false;
                while (!IsStop)
                {
                    _dispatcher.InvokeAsync(() =>
                    {
                        TimeText = DateTime.Now.AddHours(1 * count).ToString("hh:mm:ss ffff");
                    });
                    _dispatcher.InvokeAsync(() =>
                    {
                        if (showOne)
                        {
                            //Bitmap2 = new BitmapImage();
                            //Bitmap2.BeginInit();
                            //Bitmap2.UriSource = new Uri("C:\\Users\\Administrator\\Pictures\\蜡笔小新.jpg");
                            //Bitmap2.EndInit();
                            VideoImage = Bitmap2;
                        }
                        else
                        {
                            //Bitmap1 = new BitmapImage();
                            //Bitmap1.BeginInit();
                            //Bitmap1.UriSource = new Uri("C:\\Users\\Administrator\\Pictures\\狂风绝息斩.jpg");
                            //Bitmap1.EndInit();
                            VideoImage = Bitmap1;
                        }
                    });
                    Thread.Sleep(30);
                    showOne = !showOne;
                }
            });
            Task.Run(() =>
            {
                bool showOne = false;
                while (!IsStop)
                {
                    _dispatcher.InvokeAsync(() =>
                    {
                        TimeText1 = DateTime.Now.AddHours(1).ToString("hh:mm:ss ffff");
                    });
                    _dispatcher.InvokeAsync(() =>
                    {
                        if (showOne)
                        {
                            //Bitmap2 = new BitmapImage();
                            //Bitmap2.BeginInit();
                            //Bitmap2.UriSource = new Uri("C:\\Users\\Administrator\\Pictures\\蜡笔小新.jpg");
                            //Bitmap2.EndInit();
                            VideoImage1 = Bitmap1;
                        }
                        else
                        {
                            //Bitmap1 = new BitmapImage();
                            //Bitmap1.BeginInit();
                            //Bitmap1.UriSource = new Uri("C:\\Users\\Administrator\\Pictures\\狂风绝息斩.jpg");
                            //Bitmap1.EndInit();
                            VideoImage1 = Bitmap2;
                        }
                    });
                    Thread.Sleep(30);
                    showOne = !showOne;
                }
            });
            //Task.Run(() =>
            //{
            //    while (!IsStop)
            //    {
            //        _dispatcher.Invoke(() =>
            //        {
            //            foreach (ListVIewModel listVIewModel1 in ListViewSource)
            //            {
            //                listVIewModel1.TimeText = DateTime.Now.ToString();
            //            }
            //        });
            //Thread.Sleep(20);
            //    }
            //});
        }

        public void Stop()
        {
            IsStop = true;
        }

    }
}
