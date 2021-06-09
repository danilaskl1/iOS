using Foundation;
using System;
using System.Collections.ObjectModel;
using UIKit;

namespace test1
{
    public partial class ViewController : UIViewController
    {
        NSDictionary<NSString, NSString> testInfo;
        string[] testInfoFiller;
        string question;
        bool next = false;
        int counter = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void OnClickButtonTest(Foundation.NSObject sender)
        {
            _mButtonChoise1.Enabled = true;
            _mButtonChoise2.Enabled = true;
            _mButtonChoise3.Enabled = true;
            _mButtonChoise4.Enabled = true;
            _mLabel.Enabled = true;
            _mTestButton.Enabled = false;

            StartTest();
        }

        void StartTest()
        {
            var keys = new object[] {
                "a", "i", "u", "e", "o", "ka", "ki", "ku", "ke", "ko",
                "sa", "shi", "su", "se", "so", "ta", "chi", "tsu", "te", "to",
                "na", "ni", "nu", "ne", "no", "ha", "hi", "fu", "he", "ho",
                "ma", "mi", "mu", "me", "mo", "ra", "ri", "ru", "re", "ro",
                "ya", "yu", "yo", "wa", "wo", "n"
            };
            var values = new Object[] {
                "あ", "い", "う", "え", "お", "か", "き", "く", "け", "こ",
                "さ", "し", "す", "せ", "そ", "た", "ち", "つ", "て", "と",
                "な", "に", "ぬ", "ね", "の", "は", "ひ", "ふ", "へ", "ほ",
                "ま", "み", "む", "め", "も", "ら", "り", "る", "れ", "ろ",
                "や", "ゆ", "よ", "わ", "を", "ん"
            };

            testInfo = (NSDictionary<NSString, NSString>)NSDictionary.FromObjectsAndKeys(keys, values);

            testInfoFiller = new string[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                testInfoFiller[i] = keys[i].ToString();
            }

            TestNext();
        }

        void TestNext()
        {
            _mButtonChoise1.BackgroundColor = UIColor.White;
            _mButtonChoise2.BackgroundColor = UIColor.White;
            _mButtonChoise3.BackgroundColor = UIColor.White;
            _mButtonChoise4.BackgroundColor = UIColor.White;

            if (counter >= (int)testInfo.Count) {
                _mButtonChoise1.Enabled = false;
                _mButtonChoise2.Enabled = false;
                _mButtonChoise3.Enabled = false;
                _mButtonChoise4.Enabled = false;
                _mLabel.Enabled = false;
                _mTestButton.Enabled = true;
                counter = 0;
                return;
            }
            next = false;


            Random rnd = new Random();

            question = testInfo.Keys[counter];
            _mLabel.Text = testInfo.Values[counter];
            var selection = new ObservableCollection<string>();
            selection.Add(question);
            for (int i = 0; i < 4; i++)
            {
                selection.Add(testInfoFiller[rnd.Next(0, testInfoFiller.Length - 1)]);
            }
            var rInt = rnd.Next(0, selection.Count - 1);
            _mButtonChoise1.SetTitle(selection[rInt], UIControlState.Normal);
            selection.RemoveAt(rInt);
            rInt = rnd.Next(0, selection.Count - 1);
            _mButtonChoise2.SetTitle(selection[rInt], UIControlState.Normal);
            selection.RemoveAt(rInt);
            rInt = rnd.Next(0, selection.Count - 1);
            _mButtonChoise3.SetTitle(selection[rInt], UIControlState.Normal);
            selection.RemoveAt(rInt);
            _mButtonChoise4.SetTitle(selection[0], UIControlState.Normal);

            counter++;
        }

        bool Choise(string choise)
        {
            next = true;

            if (choise == question)
                return true;

            if (_mButtonChoise1.CurrentTitle == question)
                _mButtonChoise1.BackgroundColor = UIColor.Green;
            if (_mButtonChoise2.CurrentTitle == question)
                _mButtonChoise2.BackgroundColor = UIColor.Green;
            if (_mButtonChoise2.CurrentTitle == question)
                _mButtonChoise2.BackgroundColor = UIColor.Green;
            if (_mButtonChoise2.CurrentTitle == question)
                _mButtonChoise2.BackgroundColor = UIColor.Green;

            return false;
        }

        partial void OnClickButtonChoise1(Foundation.NSObject sender)
        {
            if (next)
            {
                TestNext();
                return;
            }

            var answer = Choise(_mButtonChoise1.CurrentTitle);
            if (answer)
                _mButtonChoise1.BackgroundColor = UIColor.Green;
            else
                _mButtonChoise1.BackgroundColor = UIColor.Red;
        }

        partial void OnClickButtonChoise2(Foundation.NSObject sender)
        {
            if (next)
            {
                TestNext();
                return;
            }

            var answer = Choise(_mButtonChoise2.CurrentTitle);
            if (answer)
                _mButtonChoise2.BackgroundColor = UIColor.Green;
            else
                _mButtonChoise2.BackgroundColor = UIColor.Red;
        }

        partial void OnClickButtonChoise3(Foundation.NSObject sender)
        {
            if (next)
            {
                TestNext();
                return;
            }

            var answer = Choise(_mButtonChoise3.CurrentTitle);
            if (answer)
                _mButtonChoise3.BackgroundColor = UIColor.Green;
            else
                _mButtonChoise3.BackgroundColor = UIColor.Red;
        }

        partial void OnClickButtonChoise4(Foundation.NSObject sender)
        {
            if (next)
            {
                TestNext();
                return;
            }

            var answer = Choise(_mButtonChoise4.CurrentTitle);
            if (answer)
                _mButtonChoise4.BackgroundColor = UIColor.Green;
            else
                _mButtonChoise4.BackgroundColor = UIColor.Red;
        }
    }
}

