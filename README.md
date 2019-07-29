 Screen[] sc;
            sc = Screen.AllScreens;
            //get all the screen width and heights 
            mpf = new MissionForm();
            mpf.FormBorderStyle = FormBorderStyle.None;
            mpf.Left = sc[1].Bounds.Width;
            mpf.Top = sc[1].Bounds.Height;
            mpf.StartPosition = FormStartPosition.Manual;
            mpf.Location = sc[1].Bounds.Location;
            Point p = new Point(sc[1].Bounds.Location.X, sc[1].Bounds.Location.Y);
            mpf.Location = p;
            mpf.WindowState = FormWindowState.Maximized;
            mpf.Show();
