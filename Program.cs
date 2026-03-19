namespace StarBuko
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1(loginForm.LoggedInUser));
            }


            // ONE TWO THREE NEW COMMITS
        }
    }
}