using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace Part2
{
    [Activity(Label = "Part2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button button;
        private EditText textField;
        private ImageView imageView;
        private DatePicker datePicker;

        private int Counter { get; set; } = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            #region GetViews
            this.button = FindViewById<Button>(Resource.Id.button1);
            this.textField = FindViewById<EditText>(Resource.Id.textArea);
            this.imageView = FindViewById<ImageView>(Resource.Id.imageView1);
            this.datePicker = FindViewById<DatePicker>(Resource.Id.datePicker);
            #endregion

            datePicker.Click += DatePicker_Click;
            button.Click += Button_Click;
            imageView.Click += ImageView_Click;
        }

        private void ImageView_Click(object sender, System.EventArgs e)
        {
            this.imageView.SetImageResource(Resource.Drawable.gitHubPicture);
        }

        private void DatePicker_Click(object sender, System.EventArgs e)
        {
            this.textField.Text = this.datePicker.DateTime.ToString();
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            this.Counter++;
            this.textField.Text = Counter.ToString();
        }
    }
}

